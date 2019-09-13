namespace HexBinDecCalculator
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
            this.txtHex1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTopEquals = new System.Windows.Forms.Button();
            this.cOperator = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDec2 = new System.Windows.Forms.TextBox();
            this.txtDecAns = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDec1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBinAns = new System.Windows.Forms.TextBox();
            this.txtBin2 = new System.Windows.Forms.TextBox();
            this.txtBin1 = new System.Windows.Forms.TextBox();
            this.txtHex2 = new System.Windows.Forms.TextBox();
            this.txtHexAns = new System.Windows.Forms.TextBox();
            this.radBinary = new System.Windows.Forms.RadioButton();
            this.radHex = new System.Windows.Forms.RadioButton();
            this.radDecimal = new System.Windows.Forms.RadioButton();
            this.grpLInputFormat = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnModules = new System.Windows.Forms.Button();
            this.butDiv = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnBottomEquals = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCE = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.grpLInputFormat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHex1
            // 
            this.txtHex1.AcceptsReturn = true;
            this.txtHex1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHex1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtHex1.Location = new System.Drawing.Point(8, 46);
            this.txtHex1.Margin = new System.Windows.Forms.Padding(2);
            this.txtHex1.Name = "txtHex1";
            this.txtHex1.Size = new System.Drawing.Size(161, 29);
            this.txtHex1.TabIndex = 4;
            this.txtHex1.Text = "0";
            this.txtHex1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHex1.TextChanged += new System.EventHandler(this.TxtFirstInput_TextChanged);
            this.txtHex1.Enter += new System.EventHandler(this.set_txtHex1_to_active);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTopEquals);
            this.groupBox2.Controls.Add(this.cOperator);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDec2);
            this.groupBox2.Controls.Add(this.txtDecAns);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDec1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBinAns);
            this.groupBox2.Controls.Add(this.txtBin2);
            this.groupBox2.Controls.Add(this.txtBin1);
            this.groupBox2.Controls.Add(this.txtHex2);
            this.groupBox2.Controls.Add(this.txtHex1);
            this.groupBox2.Controls.Add(this.txtHexAns);
            this.groupBox2.Location = new System.Drawing.Point(16, 79);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(642, 151);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnTopEquals
            // 
            this.btnTopEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopEquals.Location = new System.Drawing.Point(181, 115);
            this.btnTopEquals.Margin = new System.Windows.Forms.Padding(2);
            this.btnTopEquals.Name = "btnTopEquals";
            this.btnTopEquals.Size = new System.Drawing.Size(40, 30);
            this.btnTopEquals.TabIndex = 7;
            this.btnTopEquals.Text = "=";
            this.btnTopEquals.UseVisualStyleBackColor = true;
            this.btnTopEquals.Click += new System.EventHandler(this.BtnTopEquals_Click);
            // 
            // cOperator
            // 
            this.cOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOperator.FormattingEnabled = true;
            this.cOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%"});
            this.cOperator.Location = new System.Drawing.Point(181, 75);
            this.cOperator.Margin = new System.Windows.Forms.Padding(2);
            this.cOperator.Name = "cOperator";
            this.cOperator.Size = new System.Drawing.Size(42, 32);
            this.cOperator.TabIndex = 6;
            this.cOperator.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(526, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dec";
            // 
            // txtDec2
            // 
            this.txtDec2.AcceptsReturn = true;
            this.txtDec2.Enabled = false;
            this.txtDec2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDec2.Location = new System.Drawing.Point(478, 77);
            this.txtDec2.Margin = new System.Windows.Forms.Padding(2);
            this.txtDec2.Name = "txtDec2";
            this.txtDec2.ReadOnly = true;
            this.txtDec2.Size = new System.Drawing.Size(161, 29);
            this.txtDec2.TabIndex = 5;
            this.txtDec2.Text = "0";
            this.txtDec2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDec2.TextChanged += new System.EventHandler(this.TxtSecondDecimal_TextChanged);
            // 
            // txtDecAns
            // 
            this.txtDecAns.AcceptsReturn = true;
            this.txtDecAns.Enabled = false;
            this.txtDecAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecAns.Location = new System.Drawing.Point(478, 118);
            this.txtDecAns.Margin = new System.Windows.Forms.Padding(2);
            this.txtDecAns.Name = "txtDecAns";
            this.txtDecAns.ReadOnly = true;
            this.txtDecAns.Size = new System.Drawing.Size(161, 29);
            this.txtDecAns.TabIndex = 13;
            this.txtDecAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hex";
            // 
            // txtDec1
            // 
            this.txtDec1.AcceptsReturn = true;
            this.txtDec1.Enabled = false;
            this.txtDec1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDec1.Location = new System.Drawing.Point(478, 45);
            this.txtDec1.Margin = new System.Windows.Forms.Padding(2);
            this.txtDec1.Name = "txtDec1";
            this.txtDec1.ReadOnly = true;
            this.txtDec1.Size = new System.Drawing.Size(161, 29);
            this.txtDec1.TabIndex = 4;
            this.txtDec1.Text = "0";
            this.txtDec1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDec1.TextChanged += new System.EventHandler(this.TxtFirstDecimal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Binary";
            // 
            // txtBinAns
            // 
            this.txtBinAns.AcceptsReturn = true;
            this.txtBinAns.Enabled = false;
            this.txtBinAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinAns.Location = new System.Drawing.Point(306, 118);
            this.txtBinAns.Margin = new System.Windows.Forms.Padding(2);
            this.txtBinAns.Name = "txtBinAns";
            this.txtBinAns.ReadOnly = true;
            this.txtBinAns.Size = new System.Drawing.Size(161, 29);
            this.txtBinAns.TabIndex = 10;
            this.txtBinAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBin2
            // 
            this.txtBin2.AcceptsReturn = true;
            this.txtBin2.Enabled = false;
            this.txtBin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBin2.Location = new System.Drawing.Point(306, 77);
            this.txtBin2.Margin = new System.Windows.Forms.Padding(2);
            this.txtBin2.Name = "txtBin2";
            this.txtBin2.ReadOnly = true;
            this.txtBin2.Size = new System.Drawing.Size(161, 29);
            this.txtBin2.TabIndex = 5;
            this.txtBin2.Text = "0";
            this.txtBin2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBin2.TextChanged += new System.EventHandler(this.TxtSecondBinary_TextChanged);
            // 
            // txtBin1
            // 
            this.txtBin1.AcceptsReturn = true;
            this.txtBin1.Enabled = false;
            this.txtBin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBin1.Location = new System.Drawing.Point(306, 45);
            this.txtBin1.Margin = new System.Windows.Forms.Padding(2);
            this.txtBin1.Name = "txtBin1";
            this.txtBin1.ReadOnly = true;
            this.txtBin1.Size = new System.Drawing.Size(161, 29);
            this.txtBin1.TabIndex = 4;
            this.txtBin1.Text = "0";
            this.txtBin1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBin1.TextChanged += new System.EventHandler(this.TxtFirstBinary_TextChanged);
            // 
            // txtHex2
            // 
            this.txtHex2.AcceptsReturn = true;
            this.txtHex2.AcceptsTab = true;
            this.txtHex2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHex2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtHex2.Location = new System.Drawing.Point(8, 77);
            this.txtHex2.Margin = new System.Windows.Forms.Padding(2);
            this.txtHex2.Name = "txtHex2";
            this.txtHex2.Size = new System.Drawing.Size(161, 29);
            this.txtHex2.TabIndex = 5;
            this.txtHex2.Text = "0";
            this.txtHex2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHex2.TextChanged += new System.EventHandler(this.TxtSecondInput_TextChanged_1);
            this.txtHex2.Enter += new System.EventHandler(this.set_txtHex2_to_active);
            // 
            // txtHexAns
            // 
            this.txtHexAns.AcceptsReturn = true;
            this.txtHexAns.Enabled = false;
            this.txtHexAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHexAns.Location = new System.Drawing.Point(8, 115);
            this.txtHexAns.Margin = new System.Windows.Forms.Padding(2);
            this.txtHexAns.Name = "txtHexAns";
            this.txtHexAns.ReadOnly = true;
            this.txtHexAns.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHexAns.Size = new System.Drawing.Size(161, 29);
            this.txtHexAns.TabIndex = 6;
            this.txtHexAns.TabStop = false;
            this.txtHexAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radBinary
            // 
            this.radBinary.AutoSize = true;
            this.radBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBinary.Location = new System.Drawing.Point(60, 21);
            this.radBinary.Margin = new System.Windows.Forms.Padding(2);
            this.radBinary.Name = "radBinary";
            this.radBinary.Size = new System.Drawing.Size(71, 24);
            this.radBinary.TabIndex = 2;
            this.radBinary.Text = "Binary";
            this.radBinary.UseVisualStyleBackColor = true;
            this.radBinary.CheckedChanged += new System.EventHandler(this.RadBinary_CheckedChanged);
            // 
            // radHex
            // 
            this.radHex.AutoSize = true;
            this.radHex.Checked = true;
            this.radHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHex.Location = new System.Drawing.Point(4, 21);
            this.radHex.Margin = new System.Windows.Forms.Padding(2);
            this.radHex.Name = "radHex";
            this.radHex.Size = new System.Drawing.Size(55, 24);
            this.radHex.TabIndex = 1;
            this.radHex.TabStop = true;
            this.radHex.Text = "Hex";
            this.radHex.UseVisualStyleBackColor = true;
            this.radHex.CheckedChanged += new System.EventHandler(this.RadHex_CheckedChanged);
            // 
            // radDecimal
            // 
            this.radDecimal.AutoSize = true;
            this.radDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDecimal.Location = new System.Drawing.Point(130, 21);
            this.radDecimal.Margin = new System.Windows.Forms.Padding(2);
            this.radDecimal.Name = "radDecimal";
            this.radDecimal.Size = new System.Drawing.Size(84, 24);
            this.radDecimal.TabIndex = 3;
            this.radDecimal.Text = "Decimal";
            this.radDecimal.UseVisualStyleBackColor = true;
            this.radDecimal.CheckedChanged += new System.EventHandler(this.RadDecimal_CheckedChanged);
            // 
            // grpLInputFormat
            // 
            this.grpLInputFormat.Controls.Add(this.radDecimal);
            this.grpLInputFormat.Controls.Add(this.radHex);
            this.grpLInputFormat.Controls.Add(this.radBinary);
            this.grpLInputFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpLInputFormat.Location = new System.Drawing.Point(16, 15);
            this.grpLInputFormat.Margin = new System.Windows.Forms.Padding(2);
            this.grpLInputFormat.Name = "grpLInputFormat";
            this.grpLInputFormat.Padding = new System.Windows.Forms.Padding(2);
            this.grpLInputFormat.Size = new System.Drawing.Size(227, 50);
            this.grpLInputFormat.TabIndex = 5;
            this.grpLInputFormat.TabStop = false;
            this.grpLInputFormat.Text = "Choose input format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 552);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Note: Calculator performs integer math.";
            // 
            // btnA
            // 
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(10, 55);
            this.btnA.Margin = new System.Windows.Forms.Padding(2);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(56, 41);
            this.btnA.TabIndex = 0;
            this.btnA.TabStop = false;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // btn7
            // 
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(10, 102);
            this.btn7.Margin = new System.Windows.Forms.Padding(2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(56, 41);
            this.btn7.TabIndex = 0;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // btnD
            // 
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(10, 9);
            this.btnD.Margin = new System.Windows.Forms.Padding(2);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(56, 41);
            this.btnD.TabIndex = 0;
            this.btnD.TabStop = false;
            this.btnD.Tag = "D";
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(10, 148);
            this.btn4.Margin = new System.Windows.Forms.Padding(2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(56, 41);
            this.btn4.TabIndex = 0;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btn1
            // 
            this.btn1.CausesValidation = false;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(10, 194);
            this.btn1.Margin = new System.Windows.Forms.Padding(2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(56, 41);
            this.btn1.TabIndex = 0;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btnB
            // 
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(78, 55);
            this.btnB.Margin = new System.Windows.Forms.Padding(2);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(56, 41);
            this.btnB.TabIndex = 0;
            this.btnB.TabStop = false;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // btnE
            // 
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(78, 9);
            this.btnE.Margin = new System.Windows.Forms.Padding(2);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(56, 41);
            this.btnE.TabIndex = 0;
            this.btnE.TabStop = false;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.BtnE_Click);
            // 
            // btn8
            // 
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(78, 102);
            this.btn8.Margin = new System.Windows.Forms.Padding(2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(56, 41);
            this.btn8.TabIndex = 0;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // btn5
            // 
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(78, 148);
            this.btn5.Margin = new System.Windows.Forms.Padding(2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(56, 41);
            this.btn5.TabIndex = 0;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(78, 194);
            this.btn2.Margin = new System.Windows.Forms.Padding(2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(56, 41);
            this.btn2.TabIndex = 0;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btnC
            // 
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(146, 55);
            this.btnC.Margin = new System.Windows.Forms.Padding(2);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(56, 41);
            this.btnC.TabIndex = 0;
            this.btnC.TabStop = false;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // btn0
            // 
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(78, 240);
            this.btn0.Margin = new System.Windows.Forms.Padding(2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(56, 41);
            this.btn0.TabIndex = 0;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btnF
            // 
            this.btnF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.Location = new System.Drawing.Point(146, 9);
            this.btnF.Margin = new System.Windows.Forms.Padding(2);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(56, 41);
            this.btnF.TabIndex = 0;
            this.btnF.TabStop = false;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.BtnF_Click);
            // 
            // btnModules
            // 
            this.btnModules.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModules.Location = new System.Drawing.Point(220, 9);
            this.btnModules.Margin = new System.Windows.Forms.Padding(2);
            this.btnModules.Name = "btnModules";
            this.btnModules.Size = new System.Drawing.Size(56, 41);
            this.btnModules.TabIndex = 0;
            this.btnModules.TabStop = false;
            this.btnModules.Text = "%";
            this.btnModules.UseVisualStyleBackColor = true;
            this.btnModules.Click += new System.EventHandler(this.BtnModules_Click);
            // 
            // butDiv
            // 
            this.butDiv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDiv.Location = new System.Drawing.Point(220, 55);
            this.butDiv.Margin = new System.Windows.Forms.Padding(2);
            this.butDiv.Name = "butDiv";
            this.butDiv.Size = new System.Drawing.Size(56, 41);
            this.butDiv.TabIndex = 0;
            this.butDiv.TabStop = false;
            this.butDiv.Text = "/";
            this.butDiv.UseVisualStyleBackColor = true;
            this.butDiv.Click += new System.EventHandler(this.ButDiv_Click);
            // 
            // btnMult
            // 
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(220, 102);
            this.btnMult.Margin = new System.Windows.Forms.Padding(2);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(56, 41);
            this.btnMult.TabIndex = 0;
            this.btnMult.TabStop = false;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // btnSub
            // 
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(220, 148);
            this.btnSub.Margin = new System.Windows.Forms.Padding(2);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(56, 41);
            this.btnSub.TabIndex = 0;
            this.btnSub.TabStop = false;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(220, 194);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 41);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btn9
            // 
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(146, 102);
            this.btn9.Margin = new System.Windows.Forms.Padding(2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(56, 41);
            this.btn9.TabIndex = 0;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(146, 148);
            this.btn6.Margin = new System.Windows.Forms.Padding(2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(56, 41);
            this.btn6.TabIndex = 0;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(146, 194);
            this.btn3.Margin = new System.Windows.Forms.Padding(2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(56, 41);
            this.btn3.TabIndex = 0;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btnBottomEquals
            // 
            this.btnBottomEquals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBottomEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBottomEquals.Location = new System.Drawing.Point(146, 240);
            this.btnBottomEquals.Margin = new System.Windows.Forms.Padding(2);
            this.btnBottomEquals.Name = "btnBottomEquals";
            this.btnBottomEquals.Size = new System.Drawing.Size(130, 41);
            this.btnBottomEquals.TabIndex = 0;
            this.btnBottomEquals.TabStop = false;
            this.btnBottomEquals.Text = "=";
            this.btnBottomEquals.UseVisualStyleBackColor = true;
            this.btnBottomEquals.Click += new System.EventHandler(this.BtnBottomEquals_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCE);
            this.groupBox1.Controls.Add(this.btnBottomEquals);
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.btn6);
            this.groupBox1.Controls.Add(this.btn9);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnSub);
            this.groupBox1.Controls.Add(this.btnMult);
            this.groupBox1.Controls.Add(this.butDiv);
            this.groupBox1.Controls.Add(this.btnModules);
            this.groupBox1.Controls.Add(this.btnF);
            this.groupBox1.Controls.Add(this.btn0);
            this.groupBox1.Controls.Add(this.btnC);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.btn5);
            this.groupBox1.Controls.Add(this.btn8);
            this.groupBox1.Controls.Add(this.btnE);
            this.groupBox1.Controls.Add(this.btnB);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.btn4);
            this.groupBox1.Controls.Add(this.btnD);
            this.groupBox1.Controls.Add(this.btn7);
            this.groupBox1.Controls.Add(this.btnA);
            this.groupBox1.Location = new System.Drawing.Point(16, 252);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(284, 290);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnCE
            // 
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(8, 240);
            this.btnCE.Margin = new System.Windows.Forms.Padding(2);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(56, 41);
            this.btnCE.TabIndex = 1;
            this.btnCE.TabStop = false;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 587);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpLInputFormat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.test2);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpLInputFormat.ResumeLayout(false);
            this.grpLInputFormat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtHex1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radBinary;
        private System.Windows.Forms.RadioButton radHex;
        private System.Windows.Forms.RadioButton radDecimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDecAns;
        private System.Windows.Forms.TextBox txtDec2;
        private System.Windows.Forms.TextBox txtDec1;
        private System.Windows.Forms.TextBox txtBinAns;
        private System.Windows.Forms.TextBox txtBin2;
        private System.Windows.Forms.TextBox txtBin1;
        private System.Windows.Forms.TextBox txtHexAns;
        private System.Windows.Forms.TextBox txtHex2;
        private System.Windows.Forms.GroupBox grpLInputFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnModules;
        private System.Windows.Forms.Button butDiv;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnBottomEquals;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTopEquals;
        private System.Windows.Forms.ComboBox cOperator;
        private System.Windows.Forms.Button btnCE;
    }
}

