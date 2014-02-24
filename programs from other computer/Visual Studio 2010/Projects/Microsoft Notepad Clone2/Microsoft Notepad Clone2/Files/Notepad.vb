'NOTE TO ALL VIEWERS OF THIS FILE:

'ALL CONTRIBUTIONS TO THIS PROJECT MUST BE CREDITED TO THEIR CREATORS

'Version T1.00.03
'19/08/12
Imports System.IO
Imports System.Text
Imports System.Net.Mail
Namespace Notepad
    Public Class Editing
        Shared Sub SelectAll(txt As TextBox)
            txt.SelectAll()
        End Sub
        Shared Sub Undo(txt As TextBox)
            'Check if txt can undo to prevent errors
            If txt.CanUndo = True Then
                txt.Undo()
            End If
        End Sub
        Shared Sub Copy(txt As TextBox)
            'txt.copy didn't copy all of the text if it was above a certain amount of characters
            'so i used clipboard.settext instead
            If txt.SelectionLength > 0 Then
                Clipboard.SetText(txt.SelectedText)
            End If
        End Sub
        Shared Sub Cut(txt As TextBox)
            'txt.cut didn't copy all of the text if it was above a certain amount of characters
            'so i used clipboard.settext instead, and used txt.selected text = "" to remove the 
            '"cut" characters from the document
            If txt.SelectionLength > 0 Then
                Clipboard.SetText(txt.SelectedText)
                txt.SelectedText = ""
            End If

            'make txt.modified = true
            txt.Modified = True
        End Sub
        Shared Sub Paste(txt As TextBox)
            'This sub is retarded, but I wanted this code file to be used by absolute beginners
            'so I added this sub
            txt.SelectedText = Clipboard.GetText

            'make txt.modified = true
            txt.Modified = True
        End Sub
        Shared Sub insertDateTime(txt As TextBox)
            txt.SelectedText = Now

            'make txt.modified = true
            txt.Modified = True
        End Sub

        Shared Function ChooseColour()
            'Create the dialog
            Dim ColourDialog1 As New ColorDialog
            'Show the dialog
            ColourDialog1.ShowDialog()
            'Declare a variable to hold the colour selected by the user
            Dim Colour As Color = ColourDialog1.Color
            'Return the colour
            Return Colour
        End Function

        Shared Sub ChangeWordWrap()
            'If the value of wordwraptool = true then change both wrdwrp relevant controls to false
            If EditorForm.wordWrapTool.Checked = True Then
                EditorForm.txtMain.WordWrap = False
                EditorForm.wordWrapTool.Checked = False
                'If the value of wordwraptool = true then change both wrdwrp relevant controls to false
            ElseIf EditorForm.wordWrapTool.Checked = False Then
                EditorForm.txtMain.WordWrap = True
                EditorForm.wordWrapTool.Checked = True
            End If
        End Sub
        Shared Sub ChooseFont(txt As TextBox)
            Dim FontDialog1 As New FontDialog
            'Make the selected font the current font
            FontDialog1.Font = txt.Font
            FontDialog1.ShowDialog()
            txt.Font = FontDialog1.Font
        End Sub

        'Declare a variable to hold the position of the search
        'for use by the find next function
        Public Shared targetPosition As Integer = 0
        Shared Function FindText(StartPosition As Integer, textToSearch As TextBox, textToFind As TextBox, MatchCase As Boolean)
            Dim FindMore As Boolean
            'Declare the variable that will hold the location of the found text
            Dim Position As Integer
            'Determine whether or not the user wants to match the case
            If MatchCase = True Then
                'Look for the textToFind in the string(textToSearch) 
                Position = InStr(StartPosition, textToSearch.Text, textToFind.Text)
            Else
                'Look for the textToFind in the string(textToSearch) converting both
                'strings to lower case to allow the finding of different cases
                Position = InStr(StartPosition, textToSearch.Text.ToLower, textToFind.Text.ToLower)
            End If

            'If the text has been found
            If Position > 0 Then
                'Save the position of the found text to targetPosition for use by find Next
                targetPosition = Position
                'Start the selection at the begining of the found text
                textToSearch.SelectionStart = targetPosition - 1
                'End the selection at the end of the found text
                textToSearch.SelectionLength = Len(textToFind.Text)
                'Focus the TextToSearch control to complette the selection process
                textToSearch.Focus()
                'State that more can be found
                FindMore = True
            Else 'If the text can't be found
                'Inform the user
                MsgBox("Cannot find '" & textToFind.Text & "'.")
                'Reset the targetPosition to zero to prevent search lock
                targetPosition = 0
                'State that more can't be found
                FindMore = False
            End If

            'Return a bool value regarding whether or not there are any more instances
            'of the text to be found
            Return FindMore
        End Function
        Shared Sub ReplaceText(StartPosition As Integer, textToSearch As TextBox, textToFind As TextBox, MatchCase As Boolean, ReplacementText As TextBox)
            'Select the text the user wants to replace
            FindText(StartPosition, textToSearch, textToFind, MatchCase)
            'If for some reason, the selected text ISNOT the same text as
            'the intended text then do nothing(text is converted to lower case to prevent errors
            'that occur when chkCase = false)
            If textToSearch.SelectedText.ToLower <> textToFind.Text.ToLower Then
            Else
                'Replace the selected text with the replacement text
                textToSearch.SelectedText = ReplacementText.Text
            End If

        End Sub
        Shared Sub ReplaceAll(textToSearch As TextBox, textToFind As TextBox, matchCase As Boolean, ReplacementText As TextBox)
            Dim FindMore As Boolean = True
            Do While FindMore
                FindMore = FindText(targetPosition + 1, textToSearch, textToFind, matchCase)
                'If for some reason, the selected text ISNOT
                'the intended text then do nothing
                If textToSearch.SelectedText <> textToFind.Text Then
                Else
                    'Replace the selected text with the repllacement text
                    textToSearch.SelectedText = ReplacementText.Text
                End If
            Loop

        End Sub
    End Class 'Editing
    Public Class FileManipulation
        Public Shared CurrentVersion As String = "T-1.00.03"

        Shared Sub Open(txtDisplay As TextBox)
            'Check if the file has been modified before opening a new file
            If txtDisplay.Modified = True Then
                'If it has; the user will be given some options
                Dim saveChanges As MsgBoxResult = MsgBox("Do you want to save the changes to " & EditorForm.DocumentName & "?", MsgBoxStyle.YesNoCancel, "Notepad")
                'Obtain the results of that question
                If saveChanges = MsgBoxResult.Yes Then
                    'If yes then save, then open a new file
                    Save(txtDisplay)
                ElseIf saveChanges = MsgBoxResult.No Then
                    'If no then continue and open selected file
                ElseIf saveChanges = MsgBoxResult.Cancel Then
                    'If cancel then exit the open sub and return to editing mode
                    Return
                End If
            End If

            'Initialize the openfiledialog
            Dim OpenFileDialog1 As New OpenFileDialog
            'Initialize the streamreader for converting the bytes in the file to a string
            Dim oReader As StreamReader
            With OpenFileDialog1
                'Set the initial values for the openfiledialog1 object
                OpenFileDialog1.DefaultExt = "txt"
                OpenFileDialog1.Title = "Open"
                OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
                OpenFileDialog1.Multiselect = False
                'Once the user has selected a file and pressed OK run this code
                If OpenFileDialog1.ShowDialog = DialogResult.OK Then

                    'Set the document path to the path of the file to be opened for use by the save function
                    EditorForm.DocumentPath = .FileName
                    'Find the file info of the file to obtain the name of the file
                    Dim FileInfo As New FileInfo(EditorForm.DocumentPath)
                    'Set the name of the document to the name of the file to be opened
                    EditorForm.DocumentName = FileInfo.Name

                    'Load the file and display it in the textbox specified
                    oReader = New StreamReader(EditorForm.DocumentPath, True)
                    txtDisplay.Text = oReader.ReadToEnd
                    'Close the stream reader
                    oReader.Close()
                End If
            End With
        End Sub
        Shared Sub Save(txtDisplay As TextBox)
            'Check if the file has been saved yet
            If EditorForm.DocumentName = "Untitled" Then
                SaveAs(txtDisplay)
            Else 'if the file has been saved before; save the document using the path of the existing file
                'Write the information to the file
                Dim SaveFile As New StreamWriter(EditorForm.DocumentPath)
                SaveFile.Write(txtDisplay.Text)
                'close the sreamwriter
                SaveFile.Close()
                'Make it so that txtDisplay shows that it hasn't been modified
                txtDisplay.Modified = False
            End If

        End Sub
        Shared Sub SaveAs(txtDisplay As TextBox)
            Dim SaveFileDialog1 As New SaveFileDialog
            With SaveFileDialog1
                SaveFileDialog1.Filter = "Text Files (*.txt) |*.txt| All Files (*.*)|*.*"
                SaveFileDialog1.Title = "Save As"
                If .ShowDialog = DialogResult.OK Then
                    'Assign the chosen path to the documentPath variable for use in the SaveFile function
                    EditorForm.DocumentPath = .FileName
                    'Create the SaveFile function to write the information to the location
                    'specified by the DocumentPath variable
                    Dim SaveFile As New StreamWriter(EditorForm.DocumentPath)
                    'Write the information from EditorForm.maintxt.text to the selected file
                    SaveFile.Write(txtDisplay.Text)
                    'Close the streamwriter "FileName"
                    SaveFile.Close()
                    'Make it so that txtDisplay shows that it hasn't been modified
                    txtDisplay.Modified = False

                    'Obtain the saved file's name
                    Dim FileInfo As New FileInfo(EditorForm.DocumentPath)
                    EditorForm.DocumentName = FileInfo.Name
                End If
            End With

        End Sub
        Shared Sub NewDocument(txtDisplay As TextBox)
            If txtDisplay.Modified = True Then
                Dim saveChanges As MsgBoxResult = MsgBox("Do you want to save the changes to " & EditorForm.DocumentName & "?", MsgBoxStyle.YesNoCancel, "Notepad")
                If saveChanges = MsgBoxResult.No Then
                ElseIf saveChanges = MsgBoxResult.Cancel Then
                    Return
                ElseIf saveChanges = MsgBoxResult.Yes Then
                    Save(txtDisplay)
                    txtDisplay.Clear()
                End If
            Else
                txtDisplay.Clear()
            End If
            EditorForm.DocumentName = "Untitled"
        End Sub

        Shared Sub OpenRTFResource(Resource As String, RichTextBox As RichTextBox)
            'To open the rtf resource the contents of the file must be in the Resource string
            'e.g: Notepad.FileManipulation.OpenRTFResource(My.Resources.RTFExample, rtExamlpe)
            'This loads the contents of the resource into the Resource String to be decoded by
            'by the rtBox.LoadFile function
            Using ms As New MemoryStream()
                Dim buffer As Byte() = Encoding.UTF8.GetBytes(Resource)
                ms.Write(buffer, 0, buffer.Length)
                ms.Seek(0, SeekOrigin.Begin)
                RichTextBox.LoadFile(ms, RichTextBoxStreamType.RichText)
            End Using
        End Sub
        Shared Sub CheckCommandLine(txtDisplay As TextBox)
            'Check if there is a path waiting to be opened
            If Microsoft.VisualBasic.Command IsNot "" Then
                'The variable used to obtain the path is different than the variable used in the testing due to errors 
                'caused by code in parts of both methods.

                'Load the path of the file
                Dim Path As String = My.Application.CommandLineArgs(0)
                'Open the file in Notepad
                OpenPath(Path, txtDisplay)
            Else
            End If
        End Sub
        Shared Sub OpenPath(Path As String, txtDisplay As TextBox)
            If File.Exists(Path) Then
                'Find the file information of the path
                Dim FileInfo As New FileInfo(Path)
                'Set the name of the document to the name of the file to be opened
                EditorForm.DocumentName = FileInfo.Name
                'Set the path of the current document in editor form to the file to be opened
                EditorForm.DocumentPath = FileInfo.FullName
                'Load the file and display it in the textbox specified

                Dim oReader As StreamReader
                oReader = New StreamReader(Path, True)
                txtDisplay.Text = oReader.ReadToEnd
                'Close the stream reader
                oReader.Close()
            End If
        End Sub
        Shared Sub OpenFileForAdding(txtDisplay As TextBox)
            'Initialize the openfiledialog
            Dim OpenFileDialog1 As New OpenFileDialog
            'Initialize the streamreader for converting the bytes in the file to a string
            Dim oReader As StreamReader
            With OpenFileDialog1
                'Set the initial values for the openfiledialog1 object
                OpenFileDialog1.DefaultExt = "txt"
                OpenFileDialog1.Title = "Open"
                OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
                OpenFileDialog1.Multiselect = False
                'Once the user has selected a file and pressed OK run this code
                If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                    oReader = New StreamReader(.FileName, True)
                    txtDisplay.Text = oReader.ReadToEnd
                    'Close the stream reader
                    oReader.Close()
                End If
            End With
        End Sub

        Shared Sub LoadUserSettings()
            'Make the form the same size it was last time
            EditorForm.Size = My.Settings.MainFrmSize
            'Make the font the same font it was last time
            EditorForm.txtMain.Font = My.Settings.Font
            'Make the value of txtMain.wordwrap same as it was last time
            EditorForm.txtMain.WordWrap = My.Settings.WordWrap
            EditorForm.wordWrapTool.Checked = My.Settings.WordWrap
            'Make the colours of txtmain the same as last time
            EditorForm.txtMain.BackColor = My.Settings.BackgroundColour
            EditorForm.txtMain.ForeColor = My.Settings.TextColour
        End Sub
        Shared Sub SaveUserSettings()
            'Save the size of the editor form for the next time the program is run
            'If it is maximized, then just save it as the default size
            If EditorForm.WindowState = FormWindowState.Maximized Then
                My.Settings.MainFrmSize = New Size(600, 400)
                'If it is minimized than save it as the default size
            ElseIf EditorForm.WindowState = FormWindowState.Minimized Then
                My.Settings.MainFrmSize = New Size(600, 400)
                'If the form isn't min, or max then just save it as its size
            ElseIf EditorForm.WindowState = FormWindowState.Normal Then
                My.Settings.MainFrmSize = EditorForm.Size
            End If
            'Save the font used for the next time the program is run
            My.Settings.Font = EditorForm.txtMain.Font
            'Save the wordwrap value from txtmain
            My.Settings.WordWrap = EditorForm.txtMain.WordWrap
            'Save the colours used in the txtmain
            My.Settings.BackgroundColour = EditorForm.txtMain.BackColor
            My.Settings.TextColour = EditorForm.txtMain.ForeColor
            'Save the values
            My.Settings.Save()
        End Sub
    End Class 'FileManipulation
    Public Class Help
        'Find the name of the account program is being run on
        'for use by licencing and help
        Public Shared currentUser As String = SystemInformation.UserName
        Shared Sub sendUserRequest(ByRef UserRequest As String, ByVal UserEmail As String)
            'NOTE; THIS WILL ONLY LOG INTO A GMAIL ACCOUNT, 
            'EITHER CREATE ONE FOR YOUR PURPOSES
            'OR DON'T USE THIS FEATURE

            Dim smtpServer As New SmtpClient
            smtpServer.Credentials = New Net.NetworkCredential("exampleEmailSendingAddress", "ExamplePassword")
            smtpServer.Port = 587
            smtpServer.Host = "smtp.gmail.com"
            smtpServer.EnableSsl = True

            Dim mail As New MailMessage()
            mail = New MailMessage()
            mail.From = New MailAddress("User@user.com")
            mail.To.Add("YOUR-COMPANY'S-SUPPORT-EMAIL")
            mail.Subject = "Notepad Question from: " & currentUser & "|Notepad V.1.00.03|"
            mail.Body = UserRequest & "     Email response to: " & UserEmail
            smtpServer.Send(mail)
            MsgBox("Your message has been sent. EXAMPLE COMPANY Support will try to respond as soon as possible.", MsgBoxStyle.OkOnly, "Message Sent")
        End Sub
    End Class 'Help
    Public Class Filtering
        Shared Sub DoubleMask(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs, TextBox As TextBox)
            Dim keyascii As Integer
            keyascii = Asc(e.KeyChar)
            Select Case keyascii
                Case 48 To 57, 8, 13
                Case 45
                    If InStr(TextBox.Text, "-") <> 0 Then
                        keyascii = 0
                    End If
                    If TextBox.SelectionStart <> 0 Then
                        keyascii = 0
                    End If
                Case 46
                    If InStr(TextBox.Text, ".") <> 0 Then
                        keyascii = 0
                    End If
                Case Else
                    keyascii = 0
            End Select
            If keyascii = 0 Then
                e.Handled = True
            Else
                e.Handled = False
            End If

        End Sub
        Shared Sub NumberMask(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs, TextBox As TextBox)
            Dim keyascii As Integer
            keyascii = Asc(e.KeyChar)
            Select Case keyascii
                Case 48 To 57, 8, 13
                Case Else
                    keyascii = 0
            End Select
            If keyascii = 0 Then
                e.Handled = True
            Else
                e.Handled = False
            End If

        End Sub
        Shared Sub BinaryMask(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs, TextBox As TextBox)
            Dim keyascii As Integer
            keyascii = Asc(e.KeyChar)
            Select Case keyascii
                Case 48, 49, 8, 13
                Case Else
                    keyascii = 0
            End Select
            If keyascii = 0 Then
                e.Handled = True
            Else
                e.Handled = False
            End If

        End Sub
    End Class 'Filtering    
End Namespace
