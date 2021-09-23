namespace Serial_Arduino
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.AGaugeRange aGaugeRange1 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange2 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange3 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange4 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange5 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange6 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange7 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange8 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange9 = new System.Windows.Forms.AGaugeRange();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblCOM1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lblVermelho = new System.Windows.Forms.Label();
            this.lblVerde = new System.Windows.Forms.Label();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.lblAzul = new System.Windows.Forms.Label();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.aGauge2 = new System.Windows.Forms.AGauge();
            this.aGauge3 = new System.Windows.Forms.AGauge();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "On Red";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "End Red";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCOM1
            // 
            this.lblCOM1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCOM1.AutoSize = true;
            this.lblCOM1.Location = new System.Drawing.Point(494, 595);
            this.lblCOM1.Name = "lblCOM1";
            this.lblCOM1.Size = new System.Drawing.Size(66, 13);
            this.lblCOM1.TabIndex = 3;
            this.lblCOM1.Text = "Serial COM5";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "End Green";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.Location = new System.Drawing.Point(6, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "On Green";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "End Blue";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button6.Location = new System.Drawing.Point(6, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "On Blue";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblVermelho
            // 
            this.lblVermelho.AutoSize = true;
            this.lblVermelho.BackColor = System.Drawing.Color.Black;
            this.lblVermelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVermelho.ForeColor = System.Drawing.Color.Red;
            this.lblVermelho.Location = new System.Drawing.Point(207, 95);
            this.lblVermelho.Name = "lblVermelho";
            this.lblVermelho.Size = new System.Drawing.Size(55, 39);
            this.lblVermelho.TabIndex = 15;
            this.lblVermelho.Text = "00";
            // 
            // lblVerde
            // 
            this.lblVerde.AutoSize = true;
            this.lblVerde.BackColor = System.Drawing.Color.Black;
            this.lblVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerde.ForeColor = System.Drawing.Color.Lime;
            this.lblVerde.Location = new System.Drawing.Point(207, 93);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(55, 39);
            this.lblVerde.TabIndex = 17;
            this.lblVerde.Text = "00";
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hScrollBar2.Location = new System.Drawing.Point(119, 19);
            this.hScrollBar2.Maximum = 99;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(212, 16);
            this.hScrollBar2.TabIndex = 16;
            this.hScrollBar2.ValueChanged += new System.EventHandler(this.hScrollBar2_ValueChanged);
            // 
            // lblAzul
            // 
            this.lblAzul.AutoSize = true;
            this.lblAzul.BackColor = System.Drawing.Color.Black;
            this.lblAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAzul.ForeColor = System.Drawing.Color.Blue;
            this.lblAzul.Location = new System.Drawing.Point(207, 102);
            this.lblAzul.Name = "lblAzul";
            this.lblAzul.Size = new System.Drawing.Size(55, 39);
            this.lblAzul.TabIndex = 19;
            this.lblAzul.Text = "00";
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hScrollBar3.Location = new System.Drawing.Point(98, 26);
            this.hScrollBar3.Maximum = 99;
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(212, 16);
            this.hScrollBar3.TabIndex = 18;
            this.hScrollBar3.ValueChanged += new System.EventHandler(this.hScrollBar3_ValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(439, 459);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(32, 82);
            this.listBox1.TabIndex = 20;
            this.listBox1.Visible = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(571, 547);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 23);
            this.button7.TabIndex = 21;
            this.button7.Text = "ENVIAR";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(571, 436);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.Visible = false;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.hScrollBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hScrollBar1.Location = new System.Drawing.Point(119, 26);
            this.hScrollBar1.Maximum = 99;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(212, 16);
            this.hScrollBar1.TabIndex = 23;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // aGauge1
            // 
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 135;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Center = new System.Drawing.Point(100, 100);
            aGaugeRange1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            aGaugeRange1.EndValue = 30F;
            aGaugeRange1.InnerRadius = 20;
            aGaugeRange1.InRange = true;
            aGaugeRange1.Name = "GaugeRange1";
            aGaugeRange1.OuterRadius = 80;
            aGaugeRange1.StartValue = 0F;
            aGaugeRange2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            aGaugeRange2.EndValue = 60F;
            aGaugeRange2.InnerRadius = 20;
            aGaugeRange2.InRange = false;
            aGaugeRange2.Name = "GaugeRange2";
            aGaugeRange2.OuterRadius = 80;
            aGaugeRange2.StartValue = 30F;
            aGaugeRange3.Color = System.Drawing.Color.Red;
            aGaugeRange3.EndValue = 90F;
            aGaugeRange3.InnerRadius = 20;
            aGaugeRange3.InRange = false;
            aGaugeRange3.Name = "GaugeRange3";
            aGaugeRange3.OuterRadius = 80;
            aGaugeRange3.StartValue = 60F;
            this.aGauge1.GaugeRanges.Add(aGaugeRange1);
            this.aGauge1.GaugeRanges.Add(aGaugeRange2);
            this.aGauge1.GaugeRanges.Add(aGaugeRange3);
            this.aGauge1.Location = new System.Drawing.Point(382, 10);
            this.aGauge1.MaxValue = 90F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 1;
            this.aGauge1.ScaleLinesMajorOuterRadius = 1;
            this.aGauge1.ScaleLinesMajorStepValue = 10F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorTicks = 9;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = "";
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 1;
            this.aGauge1.ScaleNumbersStartScaleLine = 1;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(165, 179);
            this.aGauge1.TabIndex = 24;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.aGauge1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.hScrollBar1);
            this.groupBox1.Controls.Add(this.lblVermelho);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 193);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.aGauge2);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.hScrollBar2);
            this.groupBox2.Controls.Add(this.lblVerde);
            this.groupBox2.Location = new System.Drawing.Point(12, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 197);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // aGauge2
            // 
            this.aGauge2.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge2.BaseArcRadius = 80;
            this.aGauge2.BaseArcStart = 135;
            this.aGauge2.BaseArcSweep = 135;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.Center = new System.Drawing.Point(100, 100);
            aGaugeRange4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            aGaugeRange4.EndValue = 30F;
            aGaugeRange4.InnerRadius = 20;
            aGaugeRange4.InRange = true;
            aGaugeRange4.Name = "GaugeRange1";
            aGaugeRange4.OuterRadius = 80;
            aGaugeRange4.StartValue = 0F;
            aGaugeRange5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            aGaugeRange5.EndValue = 60F;
            aGaugeRange5.InnerRadius = 20;
            aGaugeRange5.InRange = false;
            aGaugeRange5.Name = "GaugeRange2";
            aGaugeRange5.OuterRadius = 80;
            aGaugeRange5.StartValue = 30F;
            aGaugeRange6.Color = System.Drawing.Color.Lime;
            aGaugeRange6.EndValue = 90F;
            aGaugeRange6.InnerRadius = 20;
            aGaugeRange6.InRange = false;
            aGaugeRange6.Name = "GaugeRange3";
            aGaugeRange6.OuterRadius = 80;
            aGaugeRange6.StartValue = 60F;
            this.aGauge2.GaugeRanges.Add(aGaugeRange4);
            this.aGauge2.GaugeRanges.Add(aGaugeRange5);
            this.aGauge2.GaugeRanges.Add(aGaugeRange6);
            this.aGauge2.Location = new System.Drawing.Point(381, 16);
            this.aGauge2.MaxValue = 90F;
            this.aGauge2.MinValue = 0F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge2.NeedleRadius = 80;
            this.aGauge2.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge2.NeedleWidth = 2;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesInterInnerRadius = 73;
            this.aGauge2.ScaleLinesInterOuterRadius = 80;
            this.aGauge2.ScaleLinesInterWidth = 1;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesMajorInnerRadius = 1;
            this.aGauge2.ScaleLinesMajorOuterRadius = 1;
            this.aGauge2.ScaleLinesMajorStepValue = 10F;
            this.aGauge2.ScaleLinesMajorWidth = 2;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesMinorInnerRadius = 75;
            this.aGauge2.ScaleLinesMinorOuterRadius = 80;
            this.aGauge2.ScaleLinesMinorTicks = 9;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleNumbersFormat = "";
            this.aGauge2.ScaleNumbersRadius = 95;
            this.aGauge2.ScaleNumbersRotation = 1;
            this.aGauge2.ScaleNumbersStartScaleLine = 1;
            this.aGauge2.ScaleNumbersStepScaleLines = 1;
            this.aGauge2.Size = new System.Drawing.Size(165, 179);
            this.aGauge2.TabIndex = 25;
            this.aGauge2.Text = "aGauge2";
            this.aGauge2.Value = 0F;
            // 
            // aGauge3
            // 
            this.aGauge3.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge3.BaseArcRadius = 80;
            this.aGauge3.BaseArcStart = 135;
            this.aGauge3.BaseArcSweep = 135;
            this.aGauge3.BaseArcWidth = 2;
            this.aGauge3.Center = new System.Drawing.Point(100, 100);
            aGaugeRange7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            aGaugeRange7.EndValue = 30F;
            aGaugeRange7.InnerRadius = 20;
            aGaugeRange7.InRange = true;
            aGaugeRange7.Name = "GaugeRange1";
            aGaugeRange7.OuterRadius = 80;
            aGaugeRange7.StartValue = 0F;
            aGaugeRange8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            aGaugeRange8.EndValue = 60F;
            aGaugeRange8.InnerRadius = 20;
            aGaugeRange8.InRange = false;
            aGaugeRange8.Name = "GaugeRange2";
            aGaugeRange8.OuterRadius = 80;
            aGaugeRange8.StartValue = 30F;
            aGaugeRange9.Color = System.Drawing.Color.Blue;
            aGaugeRange9.EndValue = 90F;
            aGaugeRange9.InnerRadius = 20;
            aGaugeRange9.InRange = false;
            aGaugeRange9.Name = "GaugeRange3";
            aGaugeRange9.OuterRadius = 80;
            aGaugeRange9.StartValue = 60F;
            this.aGauge3.GaugeRanges.Add(aGaugeRange7);
            this.aGauge3.GaugeRanges.Add(aGaugeRange8);
            this.aGauge3.GaugeRanges.Add(aGaugeRange9);
            this.aGauge3.Location = new System.Drawing.Point(380, 13);
            this.aGauge3.MaxValue = 90F;
            this.aGauge3.MinValue = 0F;
            this.aGauge3.Name = "aGauge3";
            this.aGauge3.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge3.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge3.NeedleRadius = 80;
            this.aGauge3.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge3.NeedleWidth = 2;
            this.aGauge3.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesInterInnerRadius = 73;
            this.aGauge3.ScaleLinesInterOuterRadius = 80;
            this.aGauge3.ScaleLinesInterWidth = 1;
            this.aGauge3.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesMajorInnerRadius = 1;
            this.aGauge3.ScaleLinesMajorOuterRadius = 1;
            this.aGauge3.ScaleLinesMajorStepValue = 10F;
            this.aGauge3.ScaleLinesMajorWidth = 2;
            this.aGauge3.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleLinesMinorInnerRadius = 75;
            this.aGauge3.ScaleLinesMinorOuterRadius = 80;
            this.aGauge3.ScaleLinesMinorTicks = 9;
            this.aGauge3.ScaleLinesMinorWidth = 1;
            this.aGauge3.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge3.ScaleNumbersFormat = "";
            this.aGauge3.ScaleNumbersRadius = 95;
            this.aGauge3.ScaleNumbersRotation = 1;
            this.aGauge3.ScaleNumbersStartScaleLine = 1;
            this.aGauge3.ScaleNumbersStepScaleLines = 1;
            this.aGauge3.Size = new System.Drawing.Size(165, 179);
            this.aGauge3.TabIndex = 26;
            this.aGauge3.Text = "aGauge3";
            this.aGauge3.Value = 0F;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.aGauge3);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.hScrollBar3);
            this.groupBox3.Controls.Add(this.lblAzul);
            this.groupBox3.Location = new System.Drawing.Point(12, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 197);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 617);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblCOM1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Controle RGB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblCOM1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblVermelho;
        private System.Windows.Forms.Label lblVerde;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.Label lblAzul;
        private System.Windows.Forms.HScrollBar hScrollBar3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.AGauge aGauge1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.AGauge aGauge2;
        private System.Windows.Forms.AGauge aGauge3;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

