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
    public partial class Calculations : Form
    {
        public Calculations()
        {
            InitializeComponent();
        }

        private void Calculations_Load(object sender, EventArgs e)
        {
            listBox1.Text = Convert.ToString(Form1.Results[0]);
        }
    }
}
