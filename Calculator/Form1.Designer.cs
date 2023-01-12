
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTitel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.TxtDisplay2 = new System.Windows.Forms.TextBox();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.BtnBackSpace = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.BtnPercent = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnDivison = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.BtnSquare = new System.Windows.Forms.Button();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.RtBoxDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.BtnClearHistory = new System.Windows.Forms.Button();
            this.BtnMultiplication = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.BtnSubtraction = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnEquals = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.BtnPM = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.BtnDecimal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlTitel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlTitel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 45);
            this.panel1.TabIndex = 0;
            // 
            // pnlTitel
            // 
            this.pnlTitel.Controls.Add(this.button3);
            this.pnlTitel.Controls.Add(this.button2);
            this.pnlTitel.Controls.Add(this.BtnExit);
            this.pnlTitel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitel.Location = new System.Drawing.Point(0, 0);
            this.pnlTitel.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitel.Name = "pnlTitel";
            this.pnlTitel.Size = new System.Drawing.Size(310, 40);
            this.pnlTitel.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(196, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(241, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 15);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(267, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(27, 33);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "x";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.BtnHistory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 40);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 35);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnHistory
            // 
            this.BtnHistory.FlatAppearance.BorderSize = 0;
            this.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnHistory.Image")));
            this.BtnHistory.Location = new System.Drawing.Point(261, 0);
            this.BtnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(40, 35);
            this.BtnHistory.TabIndex = 3;
            this.BtnHistory.UseVisualStyleBackColor = true;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // TxtDisplay2
            // 
            this.TxtDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay2.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay2.Font = new System.Drawing.Font("Gadugi", 14F);
            this.TxtDisplay2.ForeColor = System.Drawing.Color.Silver;
            this.TxtDisplay2.Location = new System.Drawing.Point(0, 85);
            this.TxtDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay2.Multiline = true;
            this.TxtDisplay2.Name = "TxtDisplay2";
            this.TxtDisplay2.Size = new System.Drawing.Size(310, 30);
            this.TxtDisplay2.TabIndex = 4;
            this.TxtDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Bold);
            this.TxtDisplay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDisplay.Location = new System.Drawing.Point(0, 115);
            this.TxtDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.Size = new System.Drawing.Size(310, 50);
            this.TxtDisplay.TabIndex = 5;
            this.TxtDisplay.Text = "0";
            this.TxtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtDisplay.Click += new System.EventHandler(this.Btn);
            this.TxtDisplay.TextChanged += new System.EventHandler(this.Form1_Load);
            // 
            // BtnBackSpace
            // 
            this.BtnBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnBackSpace.FlatAppearance.BorderSize = 0;
            this.BtnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackSpace.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBackSpace.Image = ((System.Drawing.Image)(resources.GetObject("BtnBackSpace.Image")));
            this.BtnBackSpace.Location = new System.Drawing.Point(224, 220);
            this.BtnBackSpace.Margin = new System.Windows.Forms.Padding(1);
            this.BtnBackSpace.Name = "BtnBackSpace";
            this.BtnBackSpace.Size = new System.Drawing.Size(70, 35);
            this.BtnBackSpace.TabIndex = 6;
            this.BtnBackSpace.UseVisualStyleBackColor = false;
            this.BtnBackSpace.Click += new System.EventHandler(this.BtnBackSpace_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.DarkGray;
            this.button5.Location = new System.Drawing.Point(241, 186);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 30);
            this.button5.TabIndex = 5;
            this.button5.Text = "M∨";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.DarkGray;
            this.button7.Location = new System.Drawing.Point(196, 186);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 30);
            this.button7.TabIndex = 5;
            this.button7.Text = "MS";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.DarkGray;
            this.button8.Location = new System.Drawing.Point(151, 186);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 30);
            this.button8.TabIndex = 5;
            this.button8.Text = "M-";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button5_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.DarkGray;
            this.button9.Location = new System.Drawing.Point(102, 186);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 30);
            this.button9.TabIndex = 5;
            this.button9.Text = "M+";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button5_Click);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.DarkGray;
            this.button10.Location = new System.Drawing.Point(46, 186);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 30);
            this.button10.TabIndex = 5;
            this.button10.Text = "MR";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button5_Click);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.DarkGray;
            this.button11.Location = new System.Drawing.Point(7, 186);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(50, 30);
            this.button11.TabIndex = 5;
            this.button11.Text = "MC";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button5_Click);
            // 
            // BtnPercent
            // 
            this.BtnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnPercent.FlatAppearance.BorderSize = 0;
            this.BtnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPercent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPercent.Location = new System.Drawing.Point(7, 220);
            this.BtnPercent.Margin = new System.Windows.Forms.Padding(1);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(70, 35);
            this.BtnPercent.TabIndex = 6;
            this.BtnPercent.Text = "%";
            this.BtnPercent.UseVisualStyleBackColor = false;
            this.BtnPercent.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnCE.FlatAppearance.BorderSize = 0;
            this.BtnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCE.Location = new System.Drawing.Point(79, 220);
            this.BtnCE.Margin = new System.Windows.Forms.Padding(1);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(70, 35);
            this.BtnCE.TabIndex = 6;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = false;
            this.BtnCE.Click += new System.EventHandler(this.button5_Click);
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnC.FlatAppearance.BorderSize = 0;
            this.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnC.Location = new System.Drawing.Point(151, 220);
            this.BtnC.Margin = new System.Windows.Forms.Padding(1);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(70, 35);
            this.BtnC.TabIndex = 6;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.button5_Click);
            // 
            // BtnDivison
            // 
            this.BtnDivison.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnDivison.FlatAppearance.BorderSize = 0;
            this.BtnDivison.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDivison.Font = new System.Drawing.Font("Gadugi", 16F);
            this.BtnDivison.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDivison.Location = new System.Drawing.Point(224, 257);
            this.BtnDivison.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDivison.Name = "BtnDivison";
            this.BtnDivison.Size = new System.Drawing.Size(70, 35);
            this.BtnDivison.TabIndex = 6;
            this.BtnDivison.Text = "÷";
            this.BtnDivison.UseVisualStyleBackColor = false;
            this.BtnDivison.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button16.Location = new System.Drawing.Point(7, 257);
            this.button16.Margin = new System.Windows.Forms.Padding(1);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(70, 35);
            this.button16.TabIndex = 6;
            this.button16.Text = "1∕x ";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button17.Location = new System.Drawing.Point(79, 257);
            this.button17.Margin = new System.Windows.Forms.Padding(1);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(70, 35);
            this.button17.TabIndex = 6;
            this.button17.Text = "x²";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnSquare
            // 
            this.BtnSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnSquare.FlatAppearance.BorderSize = 0;
            this.BtnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSquare.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSquare.Location = new System.Drawing.Point(151, 257);
            this.BtnSquare.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSquare.Name = "BtnSquare";
            this.BtnSquare.Size = new System.Drawing.Size(70, 35);
            this.BtnSquare.TabIndex = 6;
            this.BtnSquare.Text = "√x ";
            this.BtnSquare.UseVisualStyleBackColor = false;
            this.BtnSquare.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // pnlHistory
            // 
            this.pnlHistory.Controls.Add(this.RtBoxDisplayHistory);
            this.pnlHistory.Controls.Add(this.BtnClearHistory);
            this.pnlHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHistory.Location = new System.Drawing.Point(0, 445);
            this.pnlHistory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(310, 5);
            this.pnlHistory.TabIndex = 2;
            this.pnlHistory.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHistory_Paint);
            // 
            // RtBoxDisplayHistory
            // 
            this.RtBoxDisplayHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.RtBoxDisplayHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtBoxDisplayHistory.ForeColor = System.Drawing.Color.White;
            this.RtBoxDisplayHistory.Location = new System.Drawing.Point(0, 0);
            this.RtBoxDisplayHistory.Margin = new System.Windows.Forms.Padding(0);
            this.RtBoxDisplayHistory.Name = "RtBoxDisplayHistory";
            this.RtBoxDisplayHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.RtBoxDisplayHistory.Size = new System.Drawing.Size(360, 0);
            this.RtBoxDisplayHistory.TabIndex = 7;
            this.RtBoxDisplayHistory.Text = "";
            // 
            // BtnClearHistory
            // 
            this.BtnClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnClearHistory.FlatAppearance.BorderSize = 0;
            this.BtnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnClearHistory.Image")));
            this.BtnClearHistory.Location = new System.Drawing.Point(0, -30);
            this.BtnClearHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClearHistory.Name = "BtnClearHistory";
            this.BtnClearHistory.Size = new System.Drawing.Size(310, 35);
            this.BtnClearHistory.TabIndex = 6;
            this.BtnClearHistory.UseVisualStyleBackColor = true;
            this.BtnClearHistory.Click += new System.EventHandler(this.BtnClearHistory_Click);
            // 
            // BtnMultiplication
            // 
            this.BtnMultiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnMultiplication.FlatAppearance.BorderSize = 0;
            this.BtnMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiplication.Font = new System.Drawing.Font("Gadugi", 16F);
            this.BtnMultiplication.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMultiplication.Location = new System.Drawing.Point(224, 294);
            this.BtnMultiplication.Margin = new System.Windows.Forms.Padding(1);
            this.BtnMultiplication.Name = "BtnMultiplication";
            this.BtnMultiplication.Size = new System.Drawing.Size(70, 35);
            this.BtnMultiplication.TabIndex = 6;
            this.BtnMultiplication.Text = "x";
            this.BtnMultiplication.UseVisualStyleBackColor = false;
            this.BtnMultiplication.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn7.FlatAppearance.BorderSize = 0;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn7.Location = new System.Drawing.Point(7, 294);
            this.Btn7.Margin = new System.Windows.Forms.Padding(1);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(70, 35);
            this.Btn7.TabIndex = 6;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnSubtraction
            // 
            this.BtnSubtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnSubtraction.FlatAppearance.BorderSize = 0;
            this.BtnSubtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubtraction.Font = new System.Drawing.Font("Gadugi", 16F);
            this.BtnSubtraction.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSubtraction.Location = new System.Drawing.Point(224, 331);
            this.BtnSubtraction.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSubtraction.Name = "BtnSubtraction";
            this.BtnSubtraction.Size = new System.Drawing.Size(70, 35);
            this.BtnSubtraction.TabIndex = 6;
            this.BtnSubtraction.Text = "-";
            this.BtnSubtraction.UseVisualStyleBackColor = false;
            this.BtnSubtraction.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn8.FlatAppearance.BorderSize = 0;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn8.Location = new System.Drawing.Point(79, 294);
            this.Btn8.Margin = new System.Windows.Forms.Padding(1);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(70, 35);
            this.Btn8.TabIndex = 6;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn4.FlatAppearance.BorderSize = 0;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn4.Location = new System.Drawing.Point(7, 331);
            this.Btn4.Margin = new System.Windows.Forms.Padding(1);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(70, 35);
            this.Btn4.TabIndex = 6;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn5.FlatAppearance.BorderSize = 0;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn5.Location = new System.Drawing.Point(79, 331);
            this.Btn5.Margin = new System.Windows.Forms.Padding(1);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(70, 35);
            this.Btn5.TabIndex = 6;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn9.FlatAppearance.BorderSize = 0;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn9.Location = new System.Drawing.Point(151, 294);
            this.Btn9.Margin = new System.Windows.Forms.Padding(1);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(70, 35);
            this.Btn9.TabIndex = 6;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn6.FlatAppearance.BorderSize = 0;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn6.Location = new System.Drawing.Point(151, 331);
            this.Btn6.Margin = new System.Windows.Forms.Padding(1);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(70, 35);
            this.Btn6.TabIndex = 6;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Gadugi", 16F);
            this.BtnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAdd.Location = new System.Drawing.Point(224, 368);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(1);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(70, 35);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn1.FlatAppearance.BorderSize = 0;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn1.Location = new System.Drawing.Point(7, 368);
            this.Btn1.Margin = new System.Windows.Forms.Padding(1);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(70, 35);
            this.Btn1.TabIndex = 6;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnEquals.FlatAppearance.BorderSize = 0;
            this.BtnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquals.Font = new System.Drawing.Font("Gadugi", 16F);
            this.BtnEquals.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEquals.Location = new System.Drawing.Point(224, 405);
            this.BtnEquals.Margin = new System.Windows.Forms.Padding(1);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(70, 35);
            this.BtnEquals.TabIndex = 6;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = false;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn2.FlatAppearance.BorderSize = 0;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn2.Location = new System.Drawing.Point(79, 368);
            this.Btn2.Margin = new System.Windows.Forms.Padding(1);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(70, 35);
            this.Btn2.TabIndex = 6;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnPM
            // 
            this.BtnPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnPM.FlatAppearance.BorderSize = 0;
            this.BtnPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPM.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.BtnPM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPM.Location = new System.Drawing.Point(7, 405);
            this.BtnPM.Margin = new System.Windows.Forms.Padding(1);
            this.BtnPM.Name = "BtnPM";
            this.BtnPM.Size = new System.Drawing.Size(70, 35);
            this.BtnPM.TabIndex = 6;
            this.BtnPM.Text = "+/-";
            this.BtnPM.UseVisualStyleBackColor = false;
            this.BtnPM.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn0.FlatAppearance.BorderSize = 0;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn0.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn0.Location = new System.Drawing.Point(79, 405);
            this.Btn0.Margin = new System.Windows.Forms.Padding(1);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(70, 35);
            this.Btn0.TabIndex = 6;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn3.FlatAppearance.BorderSize = 0;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn3.Location = new System.Drawing.Point(151, 368);
            this.Btn3.Margin = new System.Windows.Forms.Padding(1);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(70, 35);
            this.Btn3.TabIndex = 6;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnDecimal
            // 
            this.BtnDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnDecimal.FlatAppearance.BorderSize = 0;
            this.BtnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDecimal.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.BtnDecimal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDecimal.Location = new System.Drawing.Point(151, 405);
            this.BtnDecimal.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDecimal.Name = "BtnDecimal";
            this.BtnDecimal.Size = new System.Drawing.Size(70, 35);
            this.BtnDecimal.TabIndex = 6;
            this.BtnDecimal.Text = ".";
            this.BtnDecimal.UseVisualStyleBackColor = false;
            this.BtnDecimal.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(310, 450);
            this.Controls.Add(this.BtnDecimal);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.BtnSquare);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.BtnPM);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.BtnSubtraction);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnDivison);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnMultiplication);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.BtnBackSpace);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.TxtDisplay2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHistory);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.BtnMathOperation_Click);
            this.panel1.ResumeLayout(false);
            this.pnlTitel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTitel;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.TextBox TxtDisplay2;
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button BtnBackSpace;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button BtnPercent;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnDivison;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button BtnSquare;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.Button BtnMultiplication;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnSubtraction;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.RichTextBox RtBoxDisplayHistory;
        private System.Windows.Forms.Button BtnClearHistory;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnEquals;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button BtnPM;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button BtnDecimal;
    }
}

