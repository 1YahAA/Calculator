namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelTitle = new Panel();
            buttonFold = new Button();
            buttonWindow = new Button();
            buttonExit = new Button();
            panel1 = new Panel();
            buttonHistory = new Button();
            textDisplay2 = new TextBox();
            textDisplay1 = new TextBox();
            textDisplat1 = new TextBox();
            buttonBackspace = new Button();
            buttonC = new Button();
            buttonPRO = new Button();
            buttonCE = new Button();
            buttonSQR = new Button();
            buttonDIV = new Button();
            buttonROOT = new Button();
            buttonDIVISION = new Button();
            buttonMULT = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            buttonPlus = new Button();
            button0 = new Button();
            buttonPlusMinuse = new Button();
            buttonDOT = new Button();
            buttonTOTAL = new Button();
            buttonMR = new Button();
            buttonMC = new Button();
            buttonMPlus = new Button();
            buttonMMinuse = new Button();
            buttonMS = new Button();
            buttonM = new Button();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button6 = new Button();
            button8 = new Button();
            button7 = new Button();
            button9 = new Button();
            buttonMinuse = new Button();
            panelHistory = new Panel();
            RTBoxDisplayHistory = new RichTextBox();
            buttonClear = new Button();
            panelTitle.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelHistory.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.BackgroundImage = (Image)resources.GetObject("panelTitle.BackgroundImage");
            panelTitle.Controls.Add(buttonFold);
            panelTitle.Controls.Add(buttonWindow);
            panelTitle.Controls.Add(buttonExit);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Margin = new Padding(0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(350, 40);
            panelTitle.TabIndex = 0;
            // 
            // buttonFold
            // 
            buttonFold.BackgroundImage = (Image)resources.GetObject("buttonFold.BackgroundImage");
            buttonFold.Dock = DockStyle.Right;
            buttonFold.FlatAppearance.BorderSize = 0;
            buttonFold.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 0, 75);
            buttonFold.FlatStyle = FlatStyle.Flat;
            buttonFold.ForeColor = Color.FromArgb(25, 25, 25);
            buttonFold.Image = (Image)resources.GetObject("buttonFold.Image");
            buttonFold.Location = new Point(200, 0);
            buttonFold.Margin = new Padding(0);
            buttonFold.Name = "buttonFold";
            buttonFold.Size = new Size(50, 40);
            buttonFold.TabIndex = 2;
            buttonFold.UseVisualStyleBackColor = true;
            buttonFold.Click += buttonFold_Click;
            // 
            // buttonWindow
            // 
            buttonWindow.BackgroundImage = (Image)resources.GetObject("buttonWindow.BackgroundImage");
            buttonWindow.Dock = DockStyle.Right;
            buttonWindow.FlatAppearance.BorderSize = 0;
            buttonWindow.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 0, 75);
            buttonWindow.FlatStyle = FlatStyle.Flat;
            buttonWindow.ForeColor = Color.FromArgb(25, 25, 25);
            buttonWindow.Image = (Image)resources.GetObject("buttonWindow.Image");
            buttonWindow.Location = new Point(250, 0);
            buttonWindow.Margin = new Padding(0);
            buttonWindow.Name = "buttonWindow";
            buttonWindow.Size = new Size(50, 40);
            buttonWindow.TabIndex = 1;
            buttonWindow.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.DarkMagenta;
            buttonExit.Dock = DockStyle.Right;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 0, 75);
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.ForeColor = Color.FromArgb(25, 25, 25);
            buttonExit.Image = (Image)resources.GetObject("buttonExit.Image");
            buttonExit.Location = new Point(300, 0);
            buttonExit.Margin = new Padding(0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(50, 40);
            buttonExit.TabIndex = 0;
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(buttonHistory);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 40);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 40);
            panel1.TabIndex = 2;
            // 
            // buttonHistory
            // 
            buttonHistory.BackgroundImage = (Image)resources.GetObject("buttonHistory.BackgroundImage");
            buttonHistory.Dock = DockStyle.Right;
            buttonHistory.FlatAppearance.BorderSize = 0;
            buttonHistory.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 0, 75);
            buttonHistory.FlatStyle = FlatStyle.Flat;
            buttonHistory.ForeColor = Color.FromArgb(25, 25, 25);
            buttonHistory.Image = (Image)resources.GetObject("buttonHistory.Image");
            buttonHistory.Location = new Point(300, 0);
            buttonHistory.Margin = new Padding(0);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Size = new Size(50, 40);
            buttonHistory.TabIndex = 0;
            buttonHistory.UseVisualStyleBackColor = true;
            buttonHistory.Click += buttonHistory_Click;
            // 
            // textDisplay2
            // 
            textDisplay2.BackColor = Color.FromArgb(25, 25, 25);
            textDisplay2.BorderStyle = BorderStyle.None;
            textDisplay2.Dock = DockStyle.Top;
            textDisplay2.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textDisplay2.ForeColor = Color.Silver;
            textDisplay2.Location = new Point(0, 80);
            textDisplay2.Margin = new Padding(0);
            textDisplay2.Multiline = true;
            textDisplay2.Name = "textDisplay2";
            textDisplay2.Size = new Size(350, 30);
            textDisplay2.TabIndex = 3;
            textDisplay2.Text = "0";
            textDisplay2.TextAlign = HorizontalAlignment.Right;
            // 
            // textDisplay1
            // 
            textDisplay1.BackColor = Color.FromArgb(25, 25, 25);
            textDisplay1.BorderStyle = BorderStyle.None;
            textDisplay1.Dock = DockStyle.Top;
            textDisplay1.Font = new Font("Montserrat", 25F, FontStyle.Bold, GraphicsUnit.Point);
            textDisplay1.ForeColor = Color.White;
            textDisplay1.Location = new Point(0, 110);
            textDisplay1.Margin = new Padding(0);
            textDisplay1.Multiline = true;
            textDisplay1.Name = "textDisplay1";
            textDisplay1.Size = new Size(350, 5);
            textDisplay1.TabIndex = 4;
            textDisplay1.Text = "0";
            textDisplay1.TextAlign = HorizontalAlignment.Right;
            // 
            // textDisplat1
            // 
            textDisplat1.BackColor = Color.FromArgb(25, 25, 25);
            textDisplat1.BorderStyle = BorderStyle.None;
            textDisplat1.Dock = DockStyle.Top;
            textDisplat1.Font = new Font("Montserrat", 25F, FontStyle.Bold, GraphicsUnit.Point);
            textDisplat1.ForeColor = Color.White;
            textDisplat1.Location = new Point(0, 115);
            textDisplat1.Margin = new Padding(0);
            textDisplat1.Multiline = true;
            textDisplat1.Name = "textDisplat1";
            textDisplat1.Size = new Size(350, 65);
            textDisplat1.TabIndex = 4;
            textDisplat1.Text = "0";
            textDisplat1.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonBackspace
            // 
            buttonBackspace.BackColor = Color.FromArgb(25, 25, 25);
            buttonBackspace.FlatAppearance.BorderSize = 0;
            buttonBackspace.FlatStyle = FlatStyle.Flat;
            buttonBackspace.ForeColor = Color.White;
            buttonBackspace.Image = (Image)resources.GetObject("buttonBackspace.Image");
            buttonBackspace.Location = new Point(263, 237);
            buttonBackspace.Margin = new Padding(0);
            buttonBackspace.Name = "buttonBackspace";
            buttonBackspace.Size = new Size(80, 50);
            buttonBackspace.TabIndex = 6;
            buttonBackspace.UseVisualStyleBackColor = false;
            buttonBackspace.Click += buttonBackspace_Click;
            // 
            // buttonC
            // 
            buttonC.BackColor = Color.FromArgb(25, 25, 25);
            buttonC.FlatAppearance.BorderSize = 0;
            buttonC.FlatStyle = FlatStyle.Flat;
            buttonC.ForeColor = Color.White;
            buttonC.Location = new Point(177, 237);
            buttonC.Margin = new Padding(0);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(80, 50);
            buttonC.TabIndex = 13;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = false;
            buttonC.Click += buttonC_Click;
            // 
            // buttonPRO
            // 
            buttonPRO.BackColor = Color.FromArgb(25, 25, 25);
            buttonPRO.FlatAppearance.BorderSize = 0;
            buttonPRO.FlatStyle = FlatStyle.Flat;
            buttonPRO.ForeColor = Color.White;
            buttonPRO.Location = new Point(5, 237);
            buttonPRO.Margin = new Padding(0);
            buttonPRO.Name = "buttonPRO";
            buttonPRO.Size = new Size(80, 50);
            buttonPRO.TabIndex = 14;
            buttonPRO.Text = "%";
            buttonPRO.UseVisualStyleBackColor = false;
            buttonPRO.Click += BtnOperation_Click;
            // 
            // buttonCE
            // 
            buttonCE.BackColor = Color.FromArgb(25, 25, 25);
            buttonCE.FlatAppearance.BorderSize = 0;
            buttonCE.FlatStyle = FlatStyle.Flat;
            buttonCE.ForeColor = Color.White;
            buttonCE.Location = new Point(91, 237);
            buttonCE.Margin = new Padding(0);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(80, 50);
            buttonCE.TabIndex = 15;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = false;
            buttonCE.Click += buttonCE_Click;
            // 
            // buttonSQR
            // 
            buttonSQR.BackColor = Color.FromArgb(25, 25, 25);
            buttonSQR.FlatAppearance.BorderSize = 0;
            buttonSQR.FlatStyle = FlatStyle.Flat;
            buttonSQR.ForeColor = Color.White;
            buttonSQR.Location = new Point(91, 292);
            buttonSQR.Margin = new Padding(0);
            buttonSQR.Name = "buttonSQR";
            buttonSQR.Size = new Size(80, 50);
            buttonSQR.TabIndex = 20;
            buttonSQR.Text = "x²";
            buttonSQR.UseVisualStyleBackColor = false;
            buttonSQR.Click += BtnOperation_Click;
            // 
            // buttonDIV
            // 
            buttonDIV.BackColor = Color.FromArgb(25, 25, 25);
            buttonDIV.FlatAppearance.BorderSize = 0;
            buttonDIV.FlatStyle = FlatStyle.Flat;
            buttonDIV.ForeColor = Color.White;
            buttonDIV.Location = new Point(5, 292);
            buttonDIV.Margin = new Padding(0);
            buttonDIV.Name = "buttonDIV";
            buttonDIV.Size = new Size(80, 50);
            buttonDIV.TabIndex = 19;
            buttonDIV.Text = "¹/";
            buttonDIV.UseVisualStyleBackColor = false;
            buttonDIV.Click += BtnOperation_Click;
            // 
            // buttonROOT
            // 
            buttonROOT.BackColor = Color.FromArgb(25, 25, 25);
            buttonROOT.FlatAppearance.BorderSize = 0;
            buttonROOT.FlatStyle = FlatStyle.Flat;
            buttonROOT.Font = new Font("Montserrat", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonROOT.ForeColor = Color.White;
            buttonROOT.Location = new Point(177, 292);
            buttonROOT.Margin = new Padding(0);
            buttonROOT.Name = "buttonROOT";
            buttonROOT.Size = new Size(80, 50);
            buttonROOT.TabIndex = 18;
            buttonROOT.Text = "√";
            buttonROOT.UseVisualStyleBackColor = false;
            buttonROOT.Click += BtnOperation_Click;
            // 
            // buttonDIVISION
            // 
            buttonDIVISION.BackColor = Color.FromArgb(25, 25, 25);
            buttonDIVISION.FlatAppearance.BorderSize = 0;
            buttonDIVISION.FlatStyle = FlatStyle.Flat;
            buttonDIVISION.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDIVISION.ForeColor = Color.White;
            buttonDIVISION.Location = new Point(263, 292);
            buttonDIVISION.Margin = new Padding(0);
            buttonDIVISION.Name = "buttonDIVISION";
            buttonDIVISION.Size = new Size(80, 50);
            buttonDIVISION.TabIndex = 17;
            buttonDIVISION.Text = "÷";
            buttonDIVISION.UseVisualStyleBackColor = false;
            buttonDIVISION.Click += BtmMathOper_Click;
            // 
            // buttonMULT
            // 
            buttonMULT.BackColor = Color.FromArgb(25, 25, 25);
            buttonMULT.FlatAppearance.BorderSize = 0;
            buttonMULT.FlatStyle = FlatStyle.Flat;
            buttonMULT.Font = new Font("Montserrat", 19F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMULT.ForeColor = Color.White;
            buttonMULT.Location = new Point(263, 347);
            buttonMULT.Margin = new Padding(0);
            buttonMULT.Name = "buttonMULT";
            buttonMULT.Size = new Size(80, 50);
            buttonMULT.TabIndex = 21;
            buttonMULT.Text = "×";
            buttonMULT.UseVisualStyleBackColor = false;
            buttonMULT.Click += BtmMathOper_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(25, 25, 25);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(91, 457);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(80, 50);
            button2.TabIndex = 32;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += BtnNum_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(25, 25, 25);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(5, 457);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(80, 50);
            button1.TabIndex = 31;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnNum_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(25, 25, 25);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(177, 457);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(80, 50);
            button3.TabIndex = 30;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += BtnNum_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.BackColor = Color.FromArgb(25, 25, 25);
            buttonPlus.FlatAppearance.BorderSize = 0;
            buttonPlus.FlatStyle = FlatStyle.Flat;
            buttonPlus.Font = new Font("Montserrat", 19F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPlus.ForeColor = Color.White;
            buttonPlus.Location = new Point(263, 457);
            buttonPlus.Margin = new Padding(0);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(80, 50);
            buttonPlus.TabIndex = 29;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += BtmMathOper_Click;
            // 
            // button0
            // 
            button0.BackColor = Color.FromArgb(25, 25, 25);
            button0.FlatAppearance.BorderSize = 0;
            button0.FlatStyle = FlatStyle.Flat;
            button0.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button0.ForeColor = Color.White;
            button0.Location = new Point(91, 512);
            button0.Margin = new Padding(0);
            button0.Name = "button0";
            button0.Size = new Size(80, 50);
            button0.TabIndex = 36;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += BtnNum_Click;
            // 
            // buttonPlusMinuse
            // 
            buttonPlusMinuse.BackColor = Color.FromArgb(25, 25, 25);
            buttonPlusMinuse.FlatAppearance.BorderSize = 0;
            buttonPlusMinuse.FlatStyle = FlatStyle.Flat;
            buttonPlusMinuse.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPlusMinuse.ForeColor = Color.White;
            buttonPlusMinuse.Location = new Point(5, 512);
            buttonPlusMinuse.Margin = new Padding(0);
            buttonPlusMinuse.Name = "buttonPlusMinuse";
            buttonPlusMinuse.Size = new Size(80, 50);
            buttonPlusMinuse.TabIndex = 35;
            buttonPlusMinuse.Text = "±";
            buttonPlusMinuse.UseVisualStyleBackColor = false;
            buttonPlusMinuse.Click += BtnOperation_Click;
            // 
            // buttonDOT
            // 
            buttonDOT.BackColor = Color.FromArgb(25, 25, 25);
            buttonDOT.FlatAppearance.BorderSize = 0;
            buttonDOT.FlatStyle = FlatStyle.Flat;
            buttonDOT.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDOT.ForeColor = Color.White;
            buttonDOT.Location = new Point(177, 512);
            buttonDOT.Margin = new Padding(0);
            buttonDOT.Name = "buttonDOT";
            buttonDOT.Size = new Size(80, 50);
            buttonDOT.TabIndex = 34;
            buttonDOT.Text = ",";
            buttonDOT.UseVisualStyleBackColor = false;
            buttonDOT.Click += BtnNum_Click;
            // 
            // buttonTOTAL
            // 
            buttonTOTAL.BackColor = Color.Purple;
            buttonTOTAL.FlatAppearance.BorderSize = 0;
            buttonTOTAL.FlatStyle = FlatStyle.Flat;
            buttonTOTAL.Font = new Font("Montserrat", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTOTAL.ForeColor = Color.White;
            buttonTOTAL.Location = new Point(263, 512);
            buttonTOTAL.Margin = new Padding(0);
            buttonTOTAL.Name = "buttonTOTAL";
            buttonTOTAL.Size = new Size(80, 50);
            buttonTOTAL.TabIndex = 33;
            buttonTOTAL.Text = "=";
            buttonTOTAL.UseVisualStyleBackColor = false;
            buttonTOTAL.Click += buttonTOTAL_Click;
            // 
            // buttonMR
            // 
            buttonMR.BackColor = Color.FromArgb(25, 25, 25);
            buttonMR.FlatAppearance.BorderSize = 0;
            buttonMR.FlatStyle = FlatStyle.Flat;
            buttonMR.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMR.ForeColor = Color.White;
            buttonMR.Location = new Point(63, 2);
            buttonMR.Margin = new Padding(0);
            buttonMR.Name = "buttonMR";
            buttonMR.RightToLeft = RightToLeft.No;
            buttonMR.Size = new Size(50, 50);
            buttonMR.TabIndex = 11;
            buttonMR.Text = "MR";
            buttonMR.UseVisualStyleBackColor = false;
            buttonMR.Click += MemOper_Click;
            // 
            // buttonMC
            // 
            buttonMC.BackColor = Color.FromArgb(25, 25, 25);
            buttonMC.FlatAppearance.BorderSize = 0;
            buttonMC.FlatStyle = FlatStyle.Flat;
            buttonMC.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMC.ForeColor = Color.White;
            buttonMC.Location = new Point(5, 2);
            buttonMC.Margin = new Padding(0);
            buttonMC.Name = "buttonMC";
            buttonMC.RightToLeft = RightToLeft.No;
            buttonMC.Size = new Size(50, 50);
            buttonMC.TabIndex = 12;
            buttonMC.Text = "MC";
            buttonMC.UseVisualStyleBackColor = false;
            buttonMC.Click += MemOper_Click;
            // 
            // buttonMPlus
            // 
            buttonMPlus.BackColor = Color.FromArgb(25, 25, 25);
            buttonMPlus.FlatAppearance.BorderSize = 0;
            buttonMPlus.FlatStyle = FlatStyle.Flat;
            buttonMPlus.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMPlus.ForeColor = Color.White;
            buttonMPlus.Location = new Point(121, 2);
            buttonMPlus.Margin = new Padding(0);
            buttonMPlus.Name = "buttonMPlus";
            buttonMPlus.RightToLeft = RightToLeft.No;
            buttonMPlus.Size = new Size(50, 50);
            buttonMPlus.TabIndex = 10;
            buttonMPlus.Text = "M+";
            buttonMPlus.UseVisualStyleBackColor = false;
            buttonMPlus.Click += MemOper_Click;
            // 
            // buttonMMinuse
            // 
            buttonMMinuse.BackColor = Color.FromArgb(25, 25, 25);
            buttonMMinuse.FlatAppearance.BorderSize = 0;
            buttonMMinuse.FlatStyle = FlatStyle.Flat;
            buttonMMinuse.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMMinuse.ForeColor = Color.White;
            buttonMMinuse.Location = new Point(177, 2);
            buttonMMinuse.Margin = new Padding(0);
            buttonMMinuse.Name = "buttonMMinuse";
            buttonMMinuse.RightToLeft = RightToLeft.No;
            buttonMMinuse.Size = new Size(50, 50);
            buttonMMinuse.TabIndex = 9;
            buttonMMinuse.Text = "M-";
            buttonMMinuse.UseVisualStyleBackColor = false;
            buttonMMinuse.Click += MemOper_Click;
            // 
            // buttonMS
            // 
            buttonMS.BackColor = Color.FromArgb(25, 25, 25);
            buttonMS.FlatAppearance.BorderSize = 0;
            buttonMS.FlatStyle = FlatStyle.Flat;
            buttonMS.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMS.ForeColor = Color.White;
            buttonMS.Location = new Point(235, 2);
            buttonMS.Margin = new Padding(0);
            buttonMS.Name = "buttonMS";
            buttonMS.RightToLeft = RightToLeft.No;
            buttonMS.Size = new Size(50, 50);
            buttonMS.TabIndex = 8;
            buttonMS.Text = "MS";
            buttonMS.UseVisualStyleBackColor = false;
            buttonMS.Click += MemOper_Click;
            // 
            // buttonM
            // 
            buttonM.BackColor = Color.FromArgb(25, 25, 25);
            buttonM.FlatAppearance.BorderSize = 0;
            buttonM.FlatStyle = FlatStyle.Flat;
            buttonM.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonM.ForeColor = Color.White;
            buttonM.Location = new Point(293, 2);
            buttonM.Margin = new Padding(0);
            buttonM.Name = "buttonM";
            buttonM.RightToLeft = RightToLeft.No;
            buttonM.Size = new Size(50, 50);
            buttonM.TabIndex = 7;
            buttonM.Text = "M~";
            buttonM.UseVisualStyleBackColor = false;
            buttonM.Click += MemOper_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonM);
            panel2.Controls.Add(buttonMS);
            panel2.Controls.Add(buttonMMinuse);
            panel2.Controls.Add(buttonMPlus);
            panel2.Controls.Add(buttonMC);
            panel2.Controls.Add(buttonMR);
            panel2.Location = new Point(0, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 55);
            panel2.TabIndex = 16;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(25, 25, 25);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(91, 402);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(80, 50);
            button5.TabIndex = 39;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += BtnNum_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(25, 25, 25);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(5, 402);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(80, 50);
            button4.TabIndex = 38;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += BtnNum_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(25, 25, 25);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(177, 402);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(80, 50);
            button6.TabIndex = 37;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += BtnNum_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(25, 25, 25);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(91, 347);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Size = new Size(80, 50);
            button8.TabIndex = 42;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += BtnNum_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(25, 25, 25);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(5, 347);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(80, 50);
            button7.TabIndex = 41;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += BtnNum_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(25, 25, 25);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(177, 347);
            button9.Margin = new Padding(0);
            button9.Name = "button9";
            button9.Size = new Size(80, 50);
            button9.TabIndex = 40;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += BtnNum_Click;
            // 
            // buttonMinuse
            // 
            buttonMinuse.BackColor = Color.FromArgb(25, 25, 25);
            buttonMinuse.FlatAppearance.BorderSize = 0;
            buttonMinuse.FlatStyle = FlatStyle.Flat;
            buttonMinuse.Font = new Font("Montserrat", 19F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMinuse.ForeColor = Color.White;
            buttonMinuse.Location = new Point(263, 402);
            buttonMinuse.Margin = new Padding(0);
            buttonMinuse.Name = "buttonMinuse";
            buttonMinuse.Size = new Size(80, 50);
            buttonMinuse.TabIndex = 43;
            buttonMinuse.Text = "-";
            buttonMinuse.UseVisualStyleBackColor = false;
            buttonMinuse.Click += BtmMathOper_Click;
            // 
            // panelHistory
            // 
            panelHistory.Controls.Add(RTBoxDisplayHistory);
            panelHistory.Controls.Add(buttonClear);
            panelHistory.Dock = DockStyle.Bottom;
            panelHistory.Location = new Point(0, 565);
            panelHistory.Name = "panelHistory";
            panelHistory.Size = new Size(350, 5);
            panelHistory.TabIndex = 44;
            // 
            // RTBoxDisplayHistory
            // 
            RTBoxDisplayHistory.BackColor = Color.FromArgb(25, 25, 25);
            RTBoxDisplayHistory.BorderStyle = BorderStyle.None;
            RTBoxDisplayHistory.Dock = DockStyle.Fill;
            RTBoxDisplayHistory.ForeColor = Color.White;
            RTBoxDisplayHistory.Location = new Point(0, 0);
            RTBoxDisplayHistory.Margin = new Padding(0);
            RTBoxDisplayHistory.Name = "RTBoxDisplayHistory";
            RTBoxDisplayHistory.ScrollBars = RichTextBoxScrollBars.Horizontal;
            RTBoxDisplayHistory.Size = new Size(350, 0);
            RTBoxDisplayHistory.TabIndex = 2;
            RTBoxDisplayHistory.Text = "";
            // 
            // buttonClear
            // 
            buttonClear.Dock = DockStyle.Bottom;
            buttonClear.FlatAppearance.BorderSize = 0;
            buttonClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 0, 75);
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.ForeColor = Color.FromArgb(25, 25, 25);
            buttonClear.Image = (Image)resources.GetObject("buttonClear.Image");
            buttonClear.Location = new Point(0, -35);
            buttonClear.Margin = new Padding(0);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(350, 40);
            buttonClear.TabIndex = 1;
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(25, 25, 25);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(350, 570);
            Controls.Add(panelHistory);
            Controls.Add(buttonMinuse);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button9);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(button0);
            Controls.Add(buttonPlusMinuse);
            Controls.Add(buttonDOT);
            Controls.Add(buttonTOTAL);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(buttonPlus);
            Controls.Add(buttonMULT);
            Controls.Add(buttonSQR);
            Controls.Add(buttonDIV);
            Controls.Add(buttonROOT);
            Controls.Add(buttonDIVISION);
            Controls.Add(panel2);
            Controls.Add(buttonCE);
            Controls.Add(buttonPRO);
            Controls.Add(buttonC);
            Controls.Add(buttonBackspace);
            Controls.Add(textDisplat1);
            Controls.Add(textDisplay1);
            Controls.Add(textDisplay2);
            Controls.Add(panel1);
            Controls.Add(panelTitle);
            Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelTitle.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panelHistory.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTitle;
        private Button buttonExit;
        private Button buttonFold;
        private Button buttonWindow;
        private Panel panel1;
        private Button buttonHistory;
        private TextBox textDisplay2;
        private TextBox textDisplay1;
        private TextBox textDisplat1;
        private Button buttonBackspace;
        private Button buttonC;
        private Button buttonPRO;
        private Button buttonCE;
        private Button buttonSQR;
        private Button buttonDIV;
        private Button buttonROOT;
        private Button buttonDIVISION;
        private Button buttonMULT;
        private Button buttonMinuse;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button buttonPlus;
        private Button button0;
        private Button buttonPlusMinuse;
        private Button buttonDOT;
        private Button buttonTOTAL;
        private Button buttonMR;
        private Button buttonMC;
        private Button buttonMPlus;
        private Button buttonMMinuse;
        private Button buttonMS;
        private Button buttonM;
        private Panel panel2;
        private Button button5;
        private Button button4;
        private Button button6;
        private Button button8;
        private Button button7;
        private Button button9;
        private Button buttonMinusee;
        private Panel panelHistory;
        private Button buttonClear;
        private RichTextBox RTBoxDisplayHistory;
    }
}