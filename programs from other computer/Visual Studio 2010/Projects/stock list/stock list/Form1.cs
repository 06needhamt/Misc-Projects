using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace stock_list
{
    public partial class Form1 : Form
    {

        private List<item> itemlist = new List<item>((1));
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();
            this.CenterToScreen();
            readfromfile();
            this.timer1.Interval = 100;
            this.timer1.Enabled = true;
            this.timer1.Start();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveitem(Convert.ToInt64(txtStallNumber.Text), Convert.ToInt64(txtStockNumber.Text), txtDescription.Text, Convert.ToDecimal(txtPaidprice.Text), Convert.ToDecimal(txtSoldPrice.Text));
        }

        private void readfromfile()
        {
            #warning Possible empty file
            var lines = System.IO.File.ReadAllLines(@"C:\Users\Thomas\Desktop\Source\items.csv");

            if (System.IO.File.Exists(@"C:\Users\Thomas\Desktop\Source\items.csv"))
            {
                foreach (string item in lines)
                {
                    var values = item.Split(',');
                    itemlist.Add(new item
                    {
                        stallnumber = long.Parse(values[0]),
                        stocknumber = long.Parse(values[1]),
                        itemdescription = values[2],
                        boughtprice = decimal.Parse(values[3]),
                        soldprice = decimal.Parse(values[4]),
                        profitorloss = decimal.Parse(values[5])
                    });
                }
            }
            else
            {
                return;
            }
                 
        }

        private void saveitem(long stallnumberpar, long stocknumberpar, string itemdiscriptionpar, decimal boughtpricepar, decimal soldpricepar, decimal profitorlosspar = 0)
        {
            var writer = new System.IO.StreamWriter(@"C:\Users\Thomas\Desktop\Source\items.csv", true);
            itemlist.Add(new item
            {
                stallnumber = stallnumberpar,
                stocknumber = stocknumberpar,
                itemdescription = itemdiscriptionpar,
                boughtprice = boughtpricepar,
                soldprice = soldpricepar,
                profitorloss = soldpricepar - boughtpricepar
            });

            profitorlosspar = soldpricepar - boughtpricepar;

            writer.WriteLine(stallnumberpar.ToString() + "," +
                stocknumberpar.ToString() + "," +
                itemdiscriptionpar + "," +
                boughtpricepar.ToString() + "," +
                soldpricepar.ToString() + "," +
                profitorlosspar.ToString());

            txtDescription.Clear();
            txtPaidprice.Clear();
            txtSoldPrice.Clear();
            txtStallNumber.Text = "";
            txtStockNumber.Clear();
            txtStallNumber.Focus();
            writer.Close();
            writer.Dispose();
            MessageBox.Show("Item Saved");
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            RunQueryDescription(Microsoft.VisualBasic.Interaction.InputBox("Enter Search Criteria", "Enter Search Criteria", ""));
        }

        private void RunQueryDescription(string description)
        {
            //List<item> products = new List<item>((1));
            System.IO.StreamWriter writer = null;
            item[] productsarr = new item[1000000];
            int index = 0;
            System.IO.File.WriteAllText(@"C:\Users\Thomas\Desktop\Source\query.csv", String.Empty);
            
            foreach (item product in itemlist)
            {
                if (product.itemdescription.Contains(description))
                {
                    productsarr[index] = product;
                    index++;
                }
                else
                {
                    continue;
                }
            }
            for (int i = 0; i < productsarr.Length; i++)
            {
                if (productsarr[i] != null)
                {
                    writer = new System.IO.StreamWriter(@"C:\Users\Thomas\Desktop\Source\query.csv", true, Encoding.UTF8);
                    writer.WriteLine(productsarr[i].stallnumber.ToString() + "," +
                    productsarr[i].stocknumber.ToString() + "," +
                    productsarr[i].itemdescription.ToString() + "," +
                    productsarr[i].boughtprice.ToString() + "," +
                    productsarr[i].soldprice.ToString() + "," +
                    productsarr[i].profitorloss.ToString());
                }
                else
                {
                    continue;
                }
                writer.Close();
                writer.Dispose();

                if (new System.IO.FileInfo(@"C:\Users\Thomas\Desktop\Source\query.csv").Length > 0)
                {
                    MessageBox.Show("Items Found");
                }
                else
                {
                    MessageBox.Show("No Items Found");
                }

            }

        }

        private void btnQueryStockNumber_Click(object sender, EventArgs e)
        {
            RunQueryStockNumber(Convert.ToInt64(Microsoft.VisualBasic.Interaction.InputBox("Enter Search Criteria", "Enter Search Criteria", "")));
        }

        private void RunQueryStockNumber(long stocknumber)
        {
            //List<item> products = new List<item>((1));
            System.IO.StreamWriter writer3 = null;
            item[] productsarr = new item[1000000];
            int index = 0;
            System.IO.File.WriteAllText(@"C:\Users\Thomas\Desktop\Source\query.csv", String.Empty);

            foreach (item product in itemlist)
            {
                if (product.stocknumber.Equals(stocknumber))
                {
                    productsarr[index] = product;
                    index++;
                }
                else
                {
                    continue;
                }
            }
            for (int i = 0; i < productsarr.Length; i++)
            {
                if (productsarr[i] != null)
                {
                    writer3 = new System.IO.StreamWriter(@"C:\Users\Thomas\Desktop\Source\query.csv", true, Encoding.UTF8);
                    writer3.WriteLine(productsarr[i].stallnumber.ToString() + "," +
                    productsarr[i].stocknumber.ToString() + "," +
                    productsarr[i].itemdescription.ToString() + "," +
                    productsarr[i].boughtprice.ToString() + "," +
                    productsarr[i].soldprice.ToString() + "," +
                    productsarr[i].profitorloss.ToString());
                }
                else
                {
                    continue;
                }
                writer3.Close();
                writer3.Dispose();

                if (new System.IO.FileInfo(@"C:\Users\Thomas\Desktop\Source\query.csv").Length > 0)
                {
                    MessageBox.Show("Items Found");
                }
                else
                {
                    MessageBox.Show("No Items Found");
                }

            }
        }

        private void btnQueryStallNumber_Click(object sender, EventArgs e)
        {
            RunQueryStallNumber(Convert.ToInt64(Microsoft.VisualBasic.Interaction.InputBox("Enter Search Criteria", "Enter Search Criteria", ""))); ;
        }

        private void RunQueryStallNumber(long stallnumber)
        {
            System.IO.StreamWriter writer2 = null;
            item[] productsarr = new item[1000000];
            int index = 0;
            System.IO.File.WriteAllText(@"C:\Users\Thomas\Desktop\Source\query.csv", String.Empty);
  
            foreach (item product in itemlist)
            {
                if (product.stallnumber.Equals(stallnumber))
                {
                    productsarr[index] = product;
                    index++;
                }
                else
                {
                    continue;
                }
            }
            for (int i = 0; i < productsarr.Length; i++)
            {
                if (productsarr[i] != null)
                {
                    writer2 = new System.IO.StreamWriter(@"C:\Users\Thomas\Desktop\Source\query.csv", true, Encoding.UTF8);
                    writer2.WriteLine(productsarr[i].stallnumber.ToString() + "," +
                    productsarr[i].stocknumber.ToString() + "," +
                    productsarr[i].itemdescription.ToString() + "," +
                    productsarr[i].boughtprice.ToString() + "," +
                    productsarr[i].soldprice.ToString() + "," +
                    productsarr[i].profitorloss.ToString());
                }
                else
                {
                    continue;
                }
                writer2.Close();
                writer2.Dispose();

                if (new System.IO.FileInfo(@"C:\Users\Thomas\Desktop\Source\query.csv").Length > 0)
                {
                    MessageBox.Show("Items Found");
                }
                else
                {
                    MessageBox.Show("No Items Found");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(GC.GetTotalMemory(true) / 1024);
        }
    }
}