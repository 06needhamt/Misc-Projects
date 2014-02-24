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
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.sound);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            timer1.Interval = 60000;
            timer1.Enabled = true;
            timer1.Start();
            //player.Play();
            
        }

        private void PlaySound()
        {
            player.Play();
            return;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PlaySound();
        }
    }
}
