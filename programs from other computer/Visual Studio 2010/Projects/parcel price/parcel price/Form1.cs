using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace parcel_price
{
    public partial class Form1 : Form
    {
        double parcellength;
        double parcelwidth;
        string Price;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();
            this.CenterToScreen();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculateprice();
            
        }
        public string Calculateprice()
        {
            parcellength = Convert.ToDouble(txtlength.Text);
            parcelwidth = Convert.ToDouble(txtwidth.Text);
            if (parcellength <= 16 && parcelwidth <= 16) 
            {
                Price = "£2.89";
                
            }
            else if (parcellength >= 16 && parcelwidth >= 16 )
            {
                Price = "£3.89";
            }
            
            MessageBox.Show(Price);
            return Price;
            
        }

    }

}
