using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Type: SlotMachine.frmMain
// Assembly: SlotMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// Assembly location: C:\Users\Thomas\Documents\SlotMachine\SlotMachine\bin\Debug\SlotMachine.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SlotMachine.My;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace SlotMachine
{
    // [DesignerGenerated]
    public class frmMain : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("lblReel1")]
        private Label _lblReel1;
        [AccessedThroughProperty("lblReel2")]
        private Label _lblReel2;
        [AccessedThroughProperty("lblReel3")]
        private Label _lblReel3;
        [AccessedThroughProperty("cmdSpin")]
        private Button _cmdSpin;
        [AccessedThroughProperty("cmdReset")]
        private Button _cmdReset;
        [AccessedThroughProperty("cmdQuit")]
        private Button _cmdQuit;
        [AccessedThroughProperty("lblMoney")]
        private Label _lblMoney;
        [AccessedThroughProperty("lblSpins")]
        private Label _lblSpins;
        [AccessedThroughProperty("lblWins")]
        private Label _lblWins;
        [AccessedThroughProperty("txtMoney")]
        private TextBox _txtMoney;
        [AccessedThroughProperty("txtSpins")]
        private TextBox _txtSpins;
        [AccessedThroughProperty("txtSingleWins")]
        private TextBox _txtSingleWins;
        [AccessedThroughProperty("lblDouble")]
        private Label _lblDouble;
        [AccessedThroughProperty("lblJackpot")]
        private Label _lblJackpot;
        [AccessedThroughProperty("txtDouble")]
        private TextBox _txtDouble;
        [AccessedThroughProperty("txtJackpot")]
        private TextBox _txtJackpot;
        [AccessedThroughProperty("cmdAutoplay")]
        private Button _cmdAutoplay;
        [AccessedThroughProperty("MenuStrip1")]
        private MenuStrip _MenuStrip1;
        [AccessedThroughProperty("GameToolStripMenuItem")]
        private ToolStripMenuItem _GameToolStripMenuItem;
        [AccessedThroughProperty("PayTableToolStripMenuItem")]
        private ToolStripMenuItem _PayTableToolStripMenuItem;
        [AccessedThroughProperty("txtTotal")]
        private TextBox _txtTotal;
        [AccessedThroughProperty("lblTotal")]
        private Label _lblTotal;
        [AccessedThroughProperty("lblPercent")]
        private Label _lblPercent;
        [AccessedThroughProperty("txtPercent")]
        private TextBox _txtPercent;
        [AccessedThroughProperty("QuitToolStripMenuItem")]
        private ToolStripMenuItem _QuitToolStripMenuItem;
        public Decimal Money;
        public int Spins;
        public int SingleWins;
        public int DoubleWins;
        public int JackpotWins;
        public int TotalWins;
        public Decimal PercentageWins;
        public bool SingleWinner;
        public bool DoubleWinner;
        public bool JackpotWinner;

        internal virtual Label lblReel1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblReel1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblReel1 = WithEventsValue;
            }
        }

        internal virtual Label lblReel2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblReel2;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblReel2 = WithEventsValue;
            }
        }

        internal virtual Label lblReel3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblReel3;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblReel3 = WithEventsValue;
            }
        }

        internal virtual Button cmdSpin
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cmdSpin;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.cmdSpin_Click);
                if (this._cmdSpin != null)
                    this._cmdSpin.Click -= eventHandler;
                this._cmdSpin = WithEventsValue;
                if (this._cmdSpin == null)
                    return;
                this._cmdSpin.Click += eventHandler;
            }
        }

        internal virtual Button cmdReset
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cmdReset;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.cmdReset_Click);
                if (this._cmdReset != null)
                    this._cmdReset.Click -= eventHandler;
                this._cmdReset = WithEventsValue;
                if (this._cmdReset == null)
                    return;
                this._cmdReset.Click += eventHandler;
            }
        }

        internal virtual Button cmdQuit
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cmdQuit;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.cmdQuit_Click);
                if (this._cmdQuit != null)
                    this._cmdQuit.Click -= eventHandler;
                this._cmdQuit = WithEventsValue;
                if (this._cmdQuit == null)
                    return;
                this._cmdQuit.Click += eventHandler;
            }
        }

        internal virtual Label lblMoney
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblMoney;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblMoney = WithEventsValue;
            }
        }

        internal virtual Label lblSpins
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblSpins;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblSpins = WithEventsValue;
            }
        }

        internal virtual Label lblWins
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblWins;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblWins = WithEventsValue;
            }
        }

        internal virtual TextBox txtMoney
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtMoney;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtMoney = WithEventsValue;
            }
        }

        internal virtual TextBox txtSpins
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtSpins;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtSpins = WithEventsValue;
            }
        }

        internal virtual TextBox txtSingleWins
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtSingleWins;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtSingleWins = WithEventsValue;
            }
        }

        internal virtual Label lblDouble
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblDouble;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblDouble = WithEventsValue;
            }
        }

        internal virtual Label lblJackpot
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblJackpot;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblJackpot = WithEventsValue;
            }
        }

        internal virtual TextBox txtDouble
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtDouble;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtDouble = WithEventsValue;
            }
        }

        internal virtual TextBox txtJackpot
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtJackpot;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtJackpot = WithEventsValue;
            }
        }

        internal virtual Button cmdAutoplay
        {
            [DebuggerNonUserCode]
            get
            {
                return this._cmdAutoplay;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.cmdAutoplay_Click);
                if (this._cmdAutoplay != null)
                    this._cmdAutoplay.Click -= eventHandler;
                this._cmdAutoplay = WithEventsValue;
                if (this._cmdAutoplay == null)
                    return;
                this._cmdAutoplay.Click += eventHandler;
            }
        }

        internal virtual MenuStrip MenuStrip1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._MenuStrip1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._MenuStrip1 = WithEventsValue;
            }
        }

        internal virtual ToolStripMenuItem GameToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._GameToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._GameToolStripMenuItem = WithEventsValue;
            }
        }

        internal virtual ToolStripMenuItem PayTableToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._PayTableToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.PayTableToolStripMenuItem_Click);
                if (this._PayTableToolStripMenuItem != null)
                    this._PayTableToolStripMenuItem.Click -= eventHandler;
                this._PayTableToolStripMenuItem = WithEventsValue;
                if (this._PayTableToolStripMenuItem == null)
                    return;
                this._PayTableToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual TextBox txtTotal
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtTotal;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtTotal = WithEventsValue;
            }
        }

        internal virtual Label lblTotal
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblTotal;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblTotal = WithEventsValue;
            }
        }

        internal virtual Label lblPercent
        {
            [DebuggerNonUserCode]
            get
            {
                return this._lblPercent;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblPercent = WithEventsValue;
            }
        }

        internal virtual TextBox txtPercent
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtPercent;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtPercent = WithEventsValue;
            }
        }

        internal virtual ToolStripMenuItem QuitToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._QuitToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.QuitToolStripMenuItem_Click);
                if (this._QuitToolStripMenuItem != null)
                    this._QuitToolStripMenuItem.Click -= eventHandler;
                this._QuitToolStripMenuItem = WithEventsValue;
                if (this._QuitToolStripMenuItem == null)
                    return;
                this._QuitToolStripMenuItem.Click += eventHandler;
            }
        }

        [DebuggerNonUserCode]
        static frmMain()
        {
        }

        public frmMain()
        {
            this.Load += new EventHandler(this.frmMain_Load);
            frmMain.__ENCAddToList((object)this);
            this.InitializeComponent();
        }

        [DebuggerNonUserCode]
        private static void __ENCAddToList(object value)
        {
            List<WeakReference> list = frmMain.__ENCList;
            bool lockTaken = false;
            try
            {
                Monitor.Enter((object)list, ref lockTaken);
                if (frmMain.__ENCList.Count == frmMain.__ENCList.Capacity)
                {
                    int index1 = 0;
                    int num1 = 0;
                    int num2 = checked(frmMain.__ENCList.Count - 1);
                    int index2 = num1;
                    while (index2 <= num2)
                    {
                        if (frmMain.__ENCList[index2].IsAlive)
                        {
                            if (index2 != index1)
                                frmMain.__ENCList[index1] = frmMain.__ENCList[index2];
                            checked { ++index1; }
                        }
                        checked { ++index2; }
                    }
                    frmMain.__ENCList.RemoveRange(index1, checked(frmMain.__ENCList.Count - index1));
                    frmMain.__ENCList.Capacity = frmMain.__ENCList.Count;
                }
                frmMain.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
            }
            finally
            {
                if (lockTaken)
                    Monitor.Exit((object)list);
            }
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if ((!disposing || this.components == null) && !false)
                    return;
                this.components.Dispose();
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.lblReel1 = new Label();
            this.lblReel2 = new Label();
            this.lblReel3 = new Label();
            this.cmdSpin = new Button();
            this.cmdReset = new Button();
            this.cmdQuit = new Button();
            this.lblMoney = new Label();
            this.lblSpins = new Label();
            this.lblWins = new Label();
            this.txtMoney = new TextBox();
            this.txtSpins = new TextBox();
            this.txtSingleWins = new TextBox();
            this.lblDouble = new Label();
            this.lblJackpot = new Label();
            this.txtDouble = new TextBox();
            this.txtJackpot = new TextBox();
            this.cmdAutoplay = new Button();
            this.MenuStrip1 = new MenuStrip();
            this.GameToolStripMenuItem = new ToolStripMenuItem();
            this.PayTableToolStripMenuItem = new ToolStripMenuItem();
            this.txtTotal = new TextBox();
            this.lblTotal = new Label();
            this.lblPercent = new Label();
            this.txtPercent = new TextBox();
            this.QuitToolStripMenuItem = new ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            this.lblReel1.AutoSize = true;
            this.lblReel1.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            Label lblReel1_1 = this.lblReel1;
            Point point1 = new Point(83, 55);
            Point point2 = point1;
            lblReel1_1.Location = point2;
            this.lblReel1.Name = "lblReel1";
            Label lblReel1_2 = this.lblReel1;
            Size size1 = new Size(24, 25);
            Size size2 = size1;
            lblReel1_2.Size = size2;
            this.lblReel1.TabIndex = 0;
            this.lblReel1.Text = "0";
            this.lblReel2.AutoSize = true;
            this.lblReel2.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            Label lblReel2_1 = this.lblReel2;
            point1 = new Point(182, 55);
            Point point3 = point1;
            lblReel2_1.Location = point3;
            this.lblReel2.Name = "lblReel2";
            Label lblReel2_2 = this.lblReel2;
            size1 = new Size(24, 25);
            Size size3 = size1;
            lblReel2_2.Size = size3;
            this.lblReel2.TabIndex = 1;
            this.lblReel2.Text = "0";
            this.lblReel3.AutoSize = true;
            this.lblReel3.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            Label lblReel3_1 = this.lblReel3;
            point1 = new Point(276, 55);
            Point point4 = point1;
            lblReel3_1.Location = point4;
            this.lblReel3.Name = "lblReel3";
            Label lblReel3_2 = this.lblReel3;
            size1 = new Size(24, 25);
            Size size4 = size1;
            lblReel3_2.Size = size4;
            this.lblReel3.TabIndex = 2;
            this.lblReel3.Text = "0";
            Button cmdSpin1 = this.cmdSpin;
            point1 = new Point(59, 182);
            Point point5 = point1;
            cmdSpin1.Location = point5;
            this.cmdSpin.Name = "cmdSpin";
            Button cmdSpin2 = this.cmdSpin;
            size1 = new Size(75, 23);
            Size size5 = size1;
            cmdSpin2.Size = size5;
            this.cmdSpin.TabIndex = 3;
            this.cmdSpin.Text = "Spin";
            this.cmdSpin.UseVisualStyleBackColor = true;
            Button cmdReset1 = this.cmdReset;
            point1 = new Point(162, 182);
            Point point6 = point1;
            cmdReset1.Location = point6;
            this.cmdReset.Name = "cmdReset";
            Button cmdReset2 = this.cmdReset;
            size1 = new Size(75, 23);
            Size size6 = size1;
            cmdReset2.Size = size6;
            this.cmdReset.TabIndex = 4;
            this.cmdReset.Text = "Reset";
            this.cmdReset.UseVisualStyleBackColor = true;
            Button cmdQuit1 = this.cmdQuit;
            point1 = new Point(259, 182);
            Point point7 = point1;
            cmdQuit1.Location = point7;
            this.cmdQuit.Name = "cmdQuit";
            Button cmdQuit2 = this.cmdQuit;
            size1 = new Size(75, 23);
            Size size7 = size1;
            cmdQuit2.Size = size7;
            this.cmdQuit.TabIndex = 5;
            this.cmdQuit.Text = "Quit";
            this.cmdQuit.UseVisualStyleBackColor = true;
            this.lblMoney.AutoSize = true;
            Label lblMoney1 = this.lblMoney;
            point1 = new Point(418, 58);
            Point point8 = point1;
            lblMoney1.Location = point8;
            this.lblMoney.Name = "lblMoney";
            Label lblMoney2 = this.lblMoney;
            size1 = new Size(39, 13);
            Size size8 = size1;
            lblMoney2.Size = size8;
            this.lblMoney.TabIndex = 6;
            this.lblMoney.Text = "Money";
            this.lblSpins.AutoSize = true;
            Label lblSpins1 = this.lblSpins;
            point1 = new Point(418, 91);
            Point point9 = point1;
            lblSpins1.Location = point9;
            this.lblSpins.Name = "lblSpins";
            Label lblSpins2 = this.lblSpins;
            size1 = new Size(33, 13);
            Size size9 = size1;
            lblSpins2.Size = size9;
            this.lblSpins.TabIndex = 7;
            this.lblSpins.Text = "Spins";
            this.lblWins.AutoSize = true;
            Label lblWins1 = this.lblWins;
            point1 = new Point(388, 124);
            Point point10 = point1;
            lblWins1.Location = point10;
            this.lblWins.Name = "lblWins";
            Label lblWins2 = this.lblWins;
            size1 = new Size(63, 13);
            Size size10 = size1;
            lblWins2.Size = size10;
            this.lblWins.TabIndex = 8;
            this.lblWins.Text = "Single Wins";
            TextBox txtMoney1 = this.txtMoney;
            point1 = new Point(463, 55);
            Point point11 = point1;
            txtMoney1.Location = point11;
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            TextBox txtMoney2 = this.txtMoney;
            size1 = new Size(100, 20);
            Size size11 = size1;
            txtMoney2.Size = size11;
            this.txtMoney.TabIndex = 9;
            TextBox txtSpins1 = this.txtSpins;
            point1 = new Point(463, 88);
            Point point12 = point1;
            txtSpins1.Location = point12;
            this.txtSpins.Name = "txtSpins";
            this.txtSpins.ReadOnly = true;
            TextBox txtSpins2 = this.txtSpins;
            size1 = new Size(100, 20);
            Size size12 = size1;
            txtSpins2.Size = size12;
            this.txtSpins.TabIndex = 10;
            TextBox txtSingleWins1 = this.txtSingleWins;
            point1 = new Point(463, 121);
            Point point13 = point1;
            txtSingleWins1.Location = point13;
            this.txtSingleWins.Name = "txtSingleWins";
            this.txtSingleWins.ReadOnly = true;
            TextBox txtSingleWins2 = this.txtSingleWins;
            size1 = new Size(100, 20);
            Size size13 = size1;
            txtSingleWins2.Size = size13;
            this.txtSingleWins.TabIndex = 11;
            this.lblDouble.AutoSize = true;
            Label lblDouble1 = this.lblDouble;
            point1 = new Point(383, 150);
            Point point14 = point1;
            lblDouble1.Location = point14;
            this.lblDouble.Name = "lblDouble";
            Label lblDouble2 = this.lblDouble;
            size1 = new Size(68, 13);
            Size size14 = size1;
            lblDouble2.Size = size14;
            this.lblDouble.TabIndex = 12;
            this.lblDouble.Text = "Double Wins";
            this.lblJackpot.AutoSize = true;
            Label lblJackpot1 = this.lblJackpot;
            point1 = new Point(379, 179);
            Point point15 = point1;
            lblJackpot1.Location = point15;
            this.lblJackpot.Name = "lblJackpot";
            Label lblJackpot2 = this.lblJackpot;
            size1 = new Size(72, 13);
            Size size15 = size1;
            lblJackpot2.Size = size15;
            this.lblJackpot.TabIndex = 13;
            this.lblJackpot.Text = "Jackpot Wins";
            TextBox txtDouble1 = this.txtDouble;
            point1 = new Point(463, 147);
            Point point16 = point1;
            txtDouble1.Location = point16;
            this.txtDouble.Name = "txtDouble";
            this.txtDouble.ReadOnly = true;
            TextBox txtDouble2 = this.txtDouble;
            size1 = new Size(100, 20);
            Size size16 = size1;
            txtDouble2.Size = size16;
            this.txtDouble.TabIndex = 14;
            TextBox txtJackpot1 = this.txtJackpot;
            point1 = new Point(463, 180);
            Point point17 = point1;
            txtJackpot1.Location = point17;
            this.txtJackpot.Name = "txtJackpot";
            this.txtJackpot.ReadOnly = true;
            TextBox txtJackpot2 = this.txtJackpot;
            size1 = new Size(100, 20);
            Size size17 = size1;
            txtJackpot2.Size = size17;
            this.txtJackpot.TabIndex = 15;
            Button cmdAutoplay1 = this.cmdAutoplay;
            point1 = new Point(162, 221);
            Point point18 = point1;
            cmdAutoplay1.Location = point18;
            this.cmdAutoplay.Name = "cmdAutoplay";
            Button cmdAutoplay2 = this.cmdAutoplay;
            size1 = new Size(75, 23);
            Size size18 = size1;
            cmdAutoplay2.Size = size18;
            this.cmdAutoplay.TabIndex = 16;
            this.cmdAutoplay.Text = "Autoplay";
            this.cmdAutoplay.UseVisualStyleBackColor = true;
            this.MenuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.GameToolStripMenuItem
      });
            MenuStrip menuStrip1_1 = this.MenuStrip1;
            point1 = new Point(0, 0);
            Point point19 = point1;
            menuStrip1_1.Location = point19;
            this.MenuStrip1.Name = "MenuStrip1";
            MenuStrip menuStrip1_2 = this.MenuStrip1;
            size1 = new Size(625, 24);
            Size size19 = size1;
            menuStrip1_2.Size = size19;
            this.MenuStrip1.TabIndex = 17;
            this.MenuStrip1.Text = "MenuStrip1";
            this.GameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.PayTableToolStripMenuItem,
        (ToolStripItem) this.QuitToolStripMenuItem
      });
            this.GameToolStripMenuItem.Name = "GameToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem1 = this.GameToolStripMenuItem;
            size1 = new Size(50, 20);
            Size size20 = size1;
            toolStripMenuItem1.Size = size20;
            this.GameToolStripMenuItem.Text = "Game";
            this.PayTableToolStripMenuItem.Name = "PayTableToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem2 = this.PayTableToolStripMenuItem;
            size1 = new Size(152, 22);
            Size size21 = size1;
            toolStripMenuItem2.Size = size21;
            this.PayTableToolStripMenuItem.Text = "Pay Table";
            TextBox txtTotal1 = this.txtTotal;
            point1 = new Point(463, 207);
            Point point20 = point1;
            txtTotal1.Location = point20;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            TextBox txtTotal2 = this.txtTotal;
            size1 = new Size(100, 20);
            Size size22 = size1;
            txtTotal2.Size = size22;
            this.txtTotal.TabIndex = 18;
            this.lblTotal.AutoSize = true;
            Label lblTotal1 = this.lblTotal;
            point1 = new Point(382, 207);
            Point point21 = point1;
            lblTotal1.Location = point21;
            this.lblTotal.Name = "lblTotal";
            Label lblTotal2 = this.lblTotal;
            size1 = new Size(58, 13);
            Size size23 = size1;
            lblTotal2.Size = size23;
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "Total Wins";
            this.lblPercent.AutoSize = true;
            Label lblPercent1 = this.lblPercent;
            point1 = new Point(362, 230);
            Point point22 = point1;
            lblPercent1.Location = point22;
            this.lblPercent.Name = "lblPercent";
            Label lblPercent2 = this.lblPercent;
            size1 = new Size(89, 13);
            Size size24 = size1;
            lblPercent2.Size = size24;
            this.lblPercent.TabIndex = 20;
            this.lblPercent.Text = "Percentage Wins";
            TextBox txtPercent1 = this.txtPercent;
            point1 = new Point(463, 230);
            Point point23 = point1;
            txtPercent1.Location = point23;
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.ReadOnly = true;
            TextBox txtPercent2 = this.txtPercent;
            size1 = new Size(100, 20);
            Size size25 = size1;
            txtPercent2.Size = size25;
            this.txtPercent.TabIndex = 21;
            this.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem3 = this.QuitToolStripMenuItem;
            size1 = new Size(152, 22);
            Size size26 = size1;
            toolStripMenuItem3.Size = size26;
            this.QuitToolStripMenuItem.Text = "Quit";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            frmMain frmMain = this;
            size1 = new Size(625, 279);
            Size size27 = size1;
            frmMain.ClientSize = size27;
            this.Controls.Add((Control)this.txtPercent);
            this.Controls.Add((Control)this.lblPercent);
            this.Controls.Add((Control)this.lblTotal);
            this.Controls.Add((Control)this.txtTotal);
            this.Controls.Add((Control)this.cmdAutoplay);
            this.Controls.Add((Control)this.txtJackpot);
            this.Controls.Add((Control)this.txtDouble);
            this.Controls.Add((Control)this.lblJackpot);
            this.Controls.Add((Control)this.lblDouble);
            this.Controls.Add((Control)this.txtSingleWins);
            this.Controls.Add((Control)this.txtSpins);
            this.Controls.Add((Control)this.txtMoney);
            this.Controls.Add((Control)this.lblWins);
            this.Controls.Add((Control)this.lblSpins);
            this.Controls.Add((Control)this.lblMoney);
            this.Controls.Add((Control)this.cmdQuit);
            this.Controls.Add((Control)this.cmdReset);
            this.Controls.Add((Control)this.cmdSpin);
            this.Controls.Add((Control)this.lblReel3);
            this.Controls.Add((Control)this.lblReel2);
            this.Controls.Add((Control)this.lblReel1);
            this.Controls.Add((Control)this.MenuStrip1);
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "frmMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Slot machine";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.SingleWinner = false;
            this.DoubleWinner = false;
            this.JackpotWinner = false;
            this.Money = new Decimal(2L);
            this.Spins = 0;
            this.SingleWins = 0;
            this.DoubleWins = 0;
            this.JackpotWins = 0;
            this.TotalWins = checked(this.SingleWins + this.DoubleWins + this.JackpotWins);
            this.txtMoney.Text = Strings.Format((object)this.Money, "Currency");
            this.txtSpins.Text = Conversions.ToString(this.Spins);
            this.txtSingleWins.Text = Conversions.ToString(this.SingleWins);
            this.txtDouble.Text = Conversions.ToString(this.DoubleWins);
            this.txtJackpot.Text = Conversions.ToString(this.JackpotWins);
            this.txtTotal.Text = Conversions.ToString(this.TotalWins);
            this.PercentageWins = new Decimal((double)this.TotalWins / (double)this.Spins);
            this.txtPercent.Text = Strings.Format((object)this.PercentageWins, "0.0%");
        }

        private void cmdSpin_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(this.Money) == 0.0)
            {
                int num = (int)MessageBox.Show("You Are out of money");
            }
            else
            {
                this.Money = new Decimal(Convert.ToDouble(this.Money) - 0.1);
                this.lblReel1.Text = Conversions.ToString(Conversion.Int(VBMath.Rnd() * 10f));
                this.lblReel2.Text = Conversions.ToString(Conversion.Int(VBMath.Rnd() * 10f));
                this.lblReel3.Text = Conversions.ToString(Conversion.Int(VBMath.Rnd() * 10f));
                this.Spins = checked(this.Spins + 1);
                this.Wincheck();
                this.Refresh();
            }
        }

        public void Wincheck()
        {
            this.JackpotWinner = Conversions.ToDouble(this.lblReel1.Text) == 7.0 & Conversions.ToDouble(this.lblReel2.Text) == 7.0 & Conversions.ToDouble(this.lblReel3.Text) == 7.0;
            this.DoubleWinner = Conversions.ToDouble(this.lblReel1.Text) == 7.0 & Conversions.ToDouble(this.lblReel2.Text) == 7.0;
            this.SingleWinner = Conversions.ToDouble(this.lblReel1.Text) == 7.0;
            if (this.SingleWinner)
            {
                this.Money = new Decimal(Convert.ToDouble(this.Money) + 1.0);
                this.SingleWins = checked(this.SingleWins + 1);
                this.TotalWins = checked(this.TotalWins + 1);
                this.PercentageWins = new Decimal((double)this.TotalWins / (double)this.Spins);
                this.SingleWinner = false;
            }
            if (this.DoubleWinner)
            {
                this.Money = new Decimal(Convert.ToDouble(this.Money) + 2.0);
                this.DoubleWins = checked(this.DoubleWins + 1);
                this.TotalWins = checked(this.TotalWins + 1);
                this.PercentageWins = new Decimal((double)this.TotalWins / (double)this.Spins);
                this.DoubleWinner = false;
            }
            if (this.JackpotWinner)
            {
                this.Money = new Decimal(Convert.ToDouble(this.Money) + 5.0);
                this.JackpotWins = checked(this.JackpotWins + 1);
                this.TotalWins = checked(this.TotalWins + 1);
                this.PercentageWins = new Decimal((double)this.TotalWins / (double)this.Spins);
                this.JackpotWinner = false;
            }
            this.PercentageWins = new Decimal((double)this.TotalWins / (double)this.Spins);
            this.txtMoney.Text = Strings.Format((object)this.Money, "Currency");
            this.txtSpins.Text = Conversions.ToString(this.Spins);
            this.txtSingleWins.Text = Conversions.ToString(this.SingleWins);
            this.txtDouble.Text = Conversions.ToString(this.DoubleWins);
            this.txtJackpot.Text = Conversions.ToString(this.JackpotWins);
            this.txtTotal.Text = Conversions.ToString(this.TotalWins);
            this.txtPercent.Text = Strings.Format((object)this.PercentageWins, "0.0%");
            this.Refresh();
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            this.SingleWinner = false;
            this.DoubleWinner = false;
            this.JackpotWinner = false;
            this.Money = new Decimal(2L);
            this.Spins = 0;
            this.SingleWins = 0;
            this.DoubleWins = 0;
            this.JackpotWins = 0;
            this.PercentageWins = new Decimal((double)this.TotalWins / (double)this.Spins);
            this.txtMoney.Text = Strings.Format((object)this.Money, "Currency");
            this.txtSpins.Text = Conversions.ToString(this.Spins);
            this.txtSingleWins.Text = Conversions.ToString(this.SingleWins);
            this.txtDouble.Text = Conversions.ToString(this.DoubleWins);
            this.txtJackpot.Text = Conversions.ToString(this.JackpotWins);
            this.txtTotal.Text = Conversions.ToString(this.TotalWins);
            this.txtPercent.Text = Strings.Format((object)this.PercentageWins, "0.0%");
            this.Refresh();
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private void cmdQuit_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            ProjectData.EndApp();
        }

        private void cmdAutoplay_Click(object sender, EventArgs e)
        {
            while (Convert.ToDouble(this.Money) != 0.0)
            {
                Application.DoEvents();
                this.Money = new Decimal(Convert.ToDouble(this.Money) - 0.1);
                this.lblReel1.Text = Conversions.ToString(Conversion.Int(VBMath.Rnd() * 10f));
                this.lblReel2.Text = Conversions.ToString(Conversion.Int(VBMath.Rnd() * 10f));
                this.lblReel3.Text = Conversions.ToString(Conversion.Int(VBMath.Rnd() * 10f));
                this.Spins = checked(this.Spins + 1);
                this.Wincheck();
                this.Refresh();
            }
            if (Convert.ToDouble(this.Money) != 0.0)
                return;
            int num = (int)MessageBox.Show("You are out of money");
        }

        private void PayTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Control)MyProject.Forms.frmPayout).Show();
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
