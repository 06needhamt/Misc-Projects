#pragma once

namespace Allignment {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for Form1
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  cmdChangeAllignment;
	protected: 
	private: System::Windows::Forms::TextBox^  txtChangeAllignment;

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->cmdChangeAllignment = (gcnew System::Windows::Forms::Button());
			this->txtChangeAllignment = (gcnew System::Windows::Forms::TextBox());
			this->SuspendLayout();
			// 
			// cmdChangeAllignment
			// 
			this->cmdChangeAllignment->Location = System::Drawing::Point(93, 153);
			this->cmdChangeAllignment->Name = L"cmdChangeAllignment";
			this->cmdChangeAllignment->Size = System::Drawing::Size(121, 23);
			this->cmdChangeAllignment->TabIndex = 0;
			this->cmdChangeAllignment->Text = L"Change Allignment";
			this->cmdChangeAllignment->UseVisualStyleBackColor = true;
			this->cmdChangeAllignment->Click += gcnew System::EventHandler(this, &Form1::cmdChangeAllignment_Click);
			// 
			// txtChangeAllignment
			// 
			this->txtChangeAllignment->Location = System::Drawing::Point(93, 52);
			this->txtChangeAllignment->Name = L"txtChangeAllignment";
			this->txtChangeAllignment->Size = System::Drawing::Size(100, 20);
			this->txtChangeAllignment->TabIndex = 1;
			this->txtChangeAllignment->Text = L"Hello";
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(284, 262);
			this->Controls->Add(this->txtChangeAllignment);
			this->Controls->Add(this->cmdChangeAllignment);
			this->Name = L"Form1";
			this->Text = L"Form1";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void cmdChangeAllignment_Click(System::Object^  sender, System::EventArgs^  e) {
				txtChangeAllignment);
			 ;}
	};
}

