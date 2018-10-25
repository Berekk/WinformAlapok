namespace WinformAlapokOOPGyakorlas
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
            this.btnKuldes = new System.Windows.Forms.Button();
            this.btnSzinvaltas = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnHarmadikFeladat = new System.Windows.Forms.Button();
            this.lblAtlagosTestSuly = new System.Windows.Forms.Label();
            this.lblLegkisebbTTI = new System.Windows.Forms.Label();
            this.lblElsoNormal = new System.Windows.Forms.Label();
            this.lblLegnagyobbTTI = new System.Windows.Forms.Label();
            this.lblAtlagosMagassag = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKuldes
            // 
            this.btnKuldes.BackColor = System.Drawing.Color.Transparent;
            this.btnKuldes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKuldes.Location = new System.Drawing.Point(6, 45);
            this.btnKuldes.Name = "btnKuldes";
            this.btnKuldes.Size = new System.Drawing.Size(75, 23);
            this.btnKuldes.TabIndex = 0;
            this.btnKuldes.Text = "Küldés";
            this.btnKuldes.UseVisualStyleBackColor = false;
            this.btnKuldes.Click += new System.EventHandler(this.btnKuldes_Click);
            this.btnKuldes.MouseEnter += new System.EventHandler(this.btnKuldes_MouseHover);
            this.btnKuldes.MouseLeave += new System.EventHandler(this.btnKuldes_MouseLeave);
            // 
            // btnSzinvaltas
            // 
            this.btnSzinvaltas.BackColor = System.Drawing.Color.Transparent;
            this.btnSzinvaltas.Location = new System.Drawing.Point(159, 45);
            this.btnSzinvaltas.Name = "btnSzinvaltas";
            this.btnSzinvaltas.Size = new System.Drawing.Size(75, 23);
            this.btnSzinvaltas.TabIndex = 1;
            this.btnSzinvaltas.Text = "Színváltás";
            this.btnSzinvaltas.UseVisualStyleBackColor = false;
            this.btnSzinvaltas.Click += new System.EventHandler(this.btnSzinvaltas_Click);
            this.btnSzinvaltas.MouseEnter += new System.EventHandler(this.btnSzinvaltas_MouseHover);
            this.btnSzinvaltas.MouseLeave += new System.EventHandler(this.btnSzinvaltas_MouseLeave);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Location = new System.Drawing.Point(17, 81);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(27, 13);
            this.label.TabIndex = 2;
            this.label.Text = "üres";
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(6, 19);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(228, 20);
            this.textBox.TabIndex = 3;
            // 
            // lblCounter
            // 
            this.lblCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCounter.BackColor = System.Drawing.Color.Silver;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCounter.Location = new System.Drawing.Point(6, 16);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(513, 308);
            this.lblCounter.TabIndex = 0;
            this.lblCounter.Text = "0";
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCounter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblCounter_MouseClick);
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.BackColor = System.Drawing.Color.White;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(6, 45);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(267, 108);
            this.listBox.TabIndex = 6;
            // 
            // numericUpDown
            // 
            this.numericUpDown.BackColor = System.Drawing.Color.White;
            this.numericUpDown.Location = new System.Drawing.Point(6, 19);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown.TabIndex = 7;
            this.numericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btnHarmadikFeladat
            // 
            this.btnHarmadikFeladat.BackColor = System.Drawing.Color.Transparent;
            this.btnHarmadikFeladat.Location = new System.Drawing.Point(85, 19);
            this.btnHarmadikFeladat.Name = "btnHarmadikFeladat";
            this.btnHarmadikFeladat.Size = new System.Drawing.Size(75, 20);
            this.btnHarmadikFeladat.TabIndex = 8;
            this.btnHarmadikFeladat.Text = "Random";
            this.btnHarmadikFeladat.UseVisualStyleBackColor = false;
            this.btnHarmadikFeladat.Click += new System.EventHandler(this.btnHarmadikFeladat_Click);
            // 
            // lblAtlagosTestSuly
            // 
            this.lblAtlagosTestSuly.AutoSize = true;
            this.lblAtlagosTestSuly.BackColor = System.Drawing.Color.Transparent;
            this.lblAtlagosTestSuly.Location = new System.Drawing.Point(6, 156);
            this.lblAtlagosTestSuly.Name = "lblAtlagosTestSuly";
            this.lblAtlagosTestSuly.Size = new System.Drawing.Size(92, 13);
            this.lblAtlagosTestSuly.TabIndex = 9;
            this.lblAtlagosTestSuly.Text = "Átlagos testsúly: 0";
            // 
            // lblLegkisebbTTI
            // 
            this.lblLegkisebbTTI.AutoSize = true;
            this.lblLegkisebbTTI.BackColor = System.Drawing.Color.Transparent;
            this.lblLegkisebbTTI.Location = new System.Drawing.Point(6, 195);
            this.lblLegkisebbTTI.Name = "lblLegkisebbTTI";
            this.lblLegkisebbTTI.Size = new System.Drawing.Size(88, 13);
            this.lblLegkisebbTTI.TabIndex = 10;
            this.lblLegkisebbTTI.Text = "Legkisebb TTI: 0";
            // 
            // lblElsoNormal
            // 
            this.lblElsoNormal.AutoSize = true;
            this.lblElsoNormal.BackColor = System.Drawing.Color.Transparent;
            this.lblElsoNormal.Location = new System.Drawing.Point(6, 208);
            this.lblElsoNormal.Name = "lblElsoNormal";
            this.lblElsoNormal.Size = new System.Drawing.Size(122, 13);
            this.lblElsoNormal.TabIndex = 11;
            this.lblElsoNormal.Text = "Első normál testalkatú: 0";
            // 
            // lblLegnagyobbTTI
            // 
            this.lblLegnagyobbTTI.AutoSize = true;
            this.lblLegnagyobbTTI.BackColor = System.Drawing.Color.Transparent;
            this.lblLegnagyobbTTI.Location = new System.Drawing.Point(6, 182);
            this.lblLegnagyobbTTI.Name = "lblLegnagyobbTTI";
            this.lblLegnagyobbTTI.Size = new System.Drawing.Size(98, 13);
            this.lblLegnagyobbTTI.TabIndex = 10;
            this.lblLegnagyobbTTI.Text = "Legnagyobb TTI: 0";
            // 
            // lblAtlagosMagassag
            // 
            this.lblAtlagosMagassag.AutoSize = true;
            this.lblAtlagosMagassag.BackColor = System.Drawing.Color.Transparent;
            this.lblAtlagosMagassag.Location = new System.Drawing.Point(6, 169);
            this.lblAtlagosMagassag.Name = "lblAtlagosMagassag";
            this.lblAtlagosMagassag.Size = new System.Drawing.Size(105, 13);
            this.lblAtlagosMagassag.TabIndex = 9;
            this.lblAtlagosMagassag.Text = "Átlagos magasság: 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.numericUpDown);
            this.groupBox1.Controls.Add(this.lblElsoNormal);
            this.groupBox1.Controls.Add(this.listBox);
            this.groupBox1.Controls.Add(this.lblLegnagyobbTTI);
            this.groupBox1.Controls.Add(this.btnHarmadikFeladat);
            this.groupBox1.Controls.Add(this.lblLegkisebbTTI);
            this.groupBox1.Controls.Add(this.lblAtlagosTestSuly);
            this.groupBox1.Controls.Add(this.lblAtlagosMagassag);
            this.groupBox1.Location = new System.Drawing.Point(258, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 232);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "3. Feladat";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox);
            this.groupBox2.Controls.Add(this.btnKuldes);
            this.groupBox2.Controls.Add(this.btnSzinvaltas);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 107);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1. Feladat";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblCounter);
            this.groupBox3.Location = new System.Drawing.Point(12, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(525, 327);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "4. Feladat - ClickCounter";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(12, 125);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 119);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 59);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kurzorvezérlő billentyűk/nyilak: balra, jobbra, fel, le, Home, End, Page Up, Page" +
    " Down és Esc: kilépés";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "cursor reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 589);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKuldes;
        private System.Windows.Forms.Button btnSzinvaltas;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button btnHarmadikFeladat;
        private System.Windows.Forms.Label lblAtlagosTestSuly;
        private System.Windows.Forms.Label lblLegkisebbTTI;
        private System.Windows.Forms.Label lblElsoNormal;
        private System.Windows.Forms.Label lblLegnagyobbTTI;
        private System.Windows.Forms.Label lblAtlagosMagassag;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

