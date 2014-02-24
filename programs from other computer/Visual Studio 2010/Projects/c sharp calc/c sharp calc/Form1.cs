using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        public static int[] Results = new int[1000];
        public static string[] ResultsRead;

        private void Form1_Load(object sender, EventArgs e)
        {
            int count;
            textBox1.Focus();
            for (count = 0; count <= Results.Length - 1; count++)
            {

                Results[count] = 0;

            }

            timer1.Enabled = true;
            timer1.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int total;
            try
            {
                num1 = Convert.ToInt32(textBox2.Text);
                num2 = Convert.ToInt32(textBox1.Text);
                total = num1 + num2;
                textBox3.Text = Convert.ToString(total);
                textBox2.Clear();
                textBox1.Clear();
                SaveAnswerInArray();
                listBox1.Items.Add(total);
                Array.Sort(Results);
                num1 = 0;
                num2 = 0;
                total = 0;
                return;
            }

            catch (FormatException ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.StackTrace);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int total;
            try
            {
                num1 = Convert.ToInt32(textBox2.Text);
                num2 = Convert.ToInt32(textBox1.Text);
                total = num1 - num2;
                textBox3.Text = Convert.ToString(total);
                textBox2.Clear();
                textBox1.Clear();
                SaveAnswerInArray();
                Array.Sort(Results);
                listBox1.Items.Add(total);
                num1 = 0;
                num2 = 0;
                total = 0;
                return;
            }

            catch (FormatException ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.StackTrace);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int total;
            try
            {
                num1 = Convert.ToInt32(textBox2.Text);
                num2 = Convert.ToInt32(textBox1.Text);
                total = num1 * num2;
                textBox3.Text = Convert.ToString(total);
                textBox2.Clear();
                textBox1.Clear();
                SaveAnswerInArray();
                Array.Sort(Results);
                listBox1.Items.Add(total);
                num1 = 0;
                num2 = 0;
                total = 0;
                return;
            }

            catch (FormatException ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.StackTrace);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                int num1;
                int num2;
                int total;
                try
                {
                    num1 = Convert.ToInt32(textBox2.Text);
                    num2 = Convert.ToInt32(textBox1.Text);
                    total = num1 / num2;
                    textBox3.Text = Convert.ToString(total);
                    textBox2.Clear();
                    textBox1.Clear();
                    SaveAnswerInArray();
                    listBox1.Items.Add(total);
                    Array.Sort(Results);
                    num1 = 0;
                    num2 = 0;
                    total = 0;
                    return;
                }

                catch (FormatException ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.StackTrace);
                }
            }
        }

        public void SaveArrayToFile()
        {
            int count;
            var writer = new System.IO.StreamWriter("C:/calc/calculations.txt", false);
            for (count = 0; count <= Results.Length - 1; count++)
            {
                if (Results[count] == 0)
                {
                    continue;
                }
                writer.Write(Results[count]);
                writer.WriteLine();
            }
            writer.Dispose();

        }

        public void SaveAnswerInArray()
        {
            int count;
            for (count = 0; count <= Results.Length - 1; count++)
            {
                if (Results[count] < 1 && Results[count] > -1)
                {
                    Results[count] = Convert.ToInt32(textBox3.Text);
                    break;
                }
            }


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveArrayToFile();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(DateTime.Now);
            label2.Text = Convert.ToString(GC.GetTotalMemory(true));
            this.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();

        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ScientificForm = new Scientific();
            ScientificForm.Show();
        }


        public void ReadIntoArray()
        {
            ResultsRead = System.IO.File.ReadAllLines("C:/calc/calculations.txt", UTF8Encoding.UTF8);
            listBox1.Items.Clear();
            foreach (string line in ResultsRead)
            {
                listBox1.Items.Add(line);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReadIntoArray();
            this.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaveArrayToFile();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            Application.Exit();
        }

        public void optional(int par1 = 0)
        {
            MessageBox.Show(Convert.ToString(par1));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            optional();
            optional(100);
        }

    }
}

