namespace Projekt_2
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
            this.button1 = new System.Windows.Forms.Button();
            this.wczytajLED = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWczytano = new System.Windows.Forms.TextBox();
            this.textBoxDlugoscNaturalna = new System.Windows.Forms.TextBox();
            this.textBoxHarmonogram = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.optymalizuj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton_ins = new System.Windows.Forms.RadioButton();
            this.radioButton_aswap = new System.Windows.Forms.RadioButton();
            this.radioButton_swap = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.t0 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sigma = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.liczbaProb = new System.Windows.Forms.TextBox();
            this.textBoxWynik = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.wczytaj_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wyborZestawu_MouseDown);
            // 
            // wczytajLED
            // 
            this.wczytajLED.BackColor = System.Drawing.Color.Red;
            this.wczytajLED.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wczytajLED.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.wczytajLED.Enabled = false;
            this.wczytajLED.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wczytajLED.Location = new System.Drawing.Point(118, 13);
            this.wczytajLED.Multiline = true;
            this.wczytajLED.Name = "wczytajLED";
            this.wczytajLED.Size = new System.Drawing.Size(21, 23);
            this.wczytajLED.TabIndex = 1;
            this.wczytajLED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.wczytaj_Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wyborZestawu_MouseDown);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(89, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.wczytaj_Click);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wyborZestawu_MouseDown);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 33);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.wczytaj_Click);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wyborZestawu_MouseDown);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(46, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 33);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.wczytaj_Click);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wyborZestawu_MouseDown);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(89, 42);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 33);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.wczytaj_Click);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wyborZestawu_MouseDown);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(37, 33);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.wczytaj_Click);
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wyborZestawu_MouseDown);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(46, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(37, 33);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.wczytaj_Click);
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wyborZestawu_MouseDown);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(89, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(37, 33);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.wczytaj_Click);
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.wyborZestawu_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 120);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Wczytano zestaw";
            this.label1.Visible = false;
            // 
            // textBoxWczytano
            // 
            this.textBoxWczytano.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxWczytano.Location = new System.Drawing.Point(151, 12);
            this.textBoxWczytano.Multiline = true;
            this.textBoxWczytano.Name = "textBoxWczytano";
            this.textBoxWczytano.ReadOnly = true;
            this.textBoxWczytano.Size = new System.Drawing.Size(121, 36);
            this.textBoxWczytano.TabIndex = 12;
            // 
            // textBoxDlugoscNaturalna
            // 
            this.textBoxDlugoscNaturalna.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDlugoscNaturalna.Location = new System.Drawing.Point(148, 72);
            this.textBoxDlugoscNaturalna.Name = "textBoxDlugoscNaturalna";
            this.textBoxDlugoscNaturalna.ReadOnly = true;
            this.textBoxDlugoscNaturalna.Size = new System.Drawing.Size(121, 20);
            this.textBoxDlugoscNaturalna.TabIndex = 14;
            // 
            // textBoxHarmonogram
            // 
            this.textBoxHarmonogram.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxHarmonogram.Location = new System.Drawing.Point(15, 234);
            this.textBoxHarmonogram.Multiline = true;
            this.textBoxHarmonogram.Name = "textBoxHarmonogram";
            this.textBoxHarmonogram.ReadOnly = true;
            this.textBoxHarmonogram.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHarmonogram.Size = new System.Drawing.Size(257, 34);
            this.textBoxHarmonogram.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Harmonogram:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Długość naturalna:";
            // 
            // optymalizuj
            // 
            this.optymalizuj.Enabled = false;
            this.optymalizuj.Location = new System.Drawing.Point(145, 174);
            this.optymalizuj.Name = "optymalizuj";
            this.optymalizuj.Size = new System.Drawing.Size(124, 24);
            this.optymalizuj.TabIndex = 18;
            this.optymalizuj.Text = "Optymalizuj";
            this.optymalizuj.UseVisualStyleBackColor = true;
            this.optymalizuj.Click += new System.EventHandler(this.optymalizuj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Parametry optymalizacji:";
            // 
            // reset
            // 
            this.reset.Enabled = false;
            this.reset.Location = new System.Drawing.Point(15, 174);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(124, 24);
            this.reset.TabIndex = 22;
            this.reset.Text = "Reset harmonogramu";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Metoda:";
            // 
            // radioButton_ins
            // 
            this.radioButton_ins.AutoSize = true;
            this.radioButton_ins.Checked = true;
            this.radioButton_ins.Location = new System.Drawing.Point(281, 101);
            this.radioButton_ins.Name = "radioButton_ins";
            this.radioButton_ins.Size = new System.Drawing.Size(43, 17);
            this.radioButton_ins.TabIndex = 25;
            this.radioButton_ins.TabStop = true;
            this.radioButton_ins.Text = "INS";
            this.radioButton_ins.UseVisualStyleBackColor = true;
            this.radioButton_ins.CheckedChanged += new System.EventHandler(this.radioButton_ins_CheckedChanged);
            // 
            // radioButton_aswap
            // 
            this.radioButton_aswap.AutoSize = true;
            this.radioButton_aswap.Location = new System.Drawing.Point(281, 78);
            this.radioButton_aswap.Name = "radioButton_aswap";
            this.radioButton_aswap.Size = new System.Drawing.Size(64, 17);
            this.radioButton_aswap.TabIndex = 24;
            this.radioButton_aswap.Text = "ASWAP";
            this.radioButton_aswap.UseVisualStyleBackColor = true;
            this.radioButton_aswap.CheckedChanged += new System.EventHandler(this.radioButton_aswap_CheckedChanged);
            // 
            // radioButton_swap
            // 
            this.radioButton_swap.AutoSize = true;
            this.radioButton_swap.Location = new System.Drawing.Point(281, 55);
            this.radioButton_swap.Name = "radioButton_swap";
            this.radioButton_swap.Size = new System.Drawing.Size(57, 17);
            this.radioButton_swap.TabIndex = 23;
            this.radioButton_swap.Text = "SWAP";
            this.radioButton_swap.UseVisualStyleBackColor = true;
            this.radioButton_swap.CheckedChanged += new System.EventHandler(this.radioButton_swap_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "T0:";
            // 
            // t0
            // 
            this.t0.BackColor = System.Drawing.SystemColors.Window;
            this.t0.Location = new System.Drawing.Point(278, 138);
            this.t0.Name = "t0";
            this.t0.Size = new System.Drawing.Size(119, 20);
            this.t0.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tk:";
            // 
            // tK
            // 
            this.tK.BackColor = System.Drawing.SystemColors.Window;
            this.tK.Location = new System.Drawing.Point(278, 177);
            this.tK.Name = "tK";
            this.tK.Size = new System.Drawing.Size(119, 20);
            this.tK.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Sigma:";
            // 
            // sigma
            // 
            this.sigma.BackColor = System.Drawing.SystemColors.Window;
            this.sigma.Location = new System.Drawing.Point(278, 214);
            this.sigma.Name = "sigma";
            this.sigma.Size = new System.Drawing.Size(119, 20);
            this.sigma.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Liczba prób:";
            // 
            // liczbaProb
            // 
            this.liczbaProb.BackColor = System.Drawing.SystemColors.Window;
            this.liczbaProb.Location = new System.Drawing.Point(278, 253);
            this.liczbaProb.Name = "liczbaProb";
            this.liczbaProb.Size = new System.Drawing.Size(119, 20);
            this.liczbaProb.TabIndex = 33;
            // 
            // textBoxWynik
            // 
            this.textBoxWynik.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxWynik.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWynik.Location = new System.Drawing.Point(151, 116);
            this.textBoxWynik.Name = "textBoxWynik";
            this.textBoxWynik.ReadOnly = true;
            this.textBoxWynik.Size = new System.Drawing.Size(118, 38);
            this.textBoxWynik.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(148, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "WYNIK:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 285);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxWynik);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.liczbaProb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sigma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tK);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.t0);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton_ins);
            this.Controls.Add(this.radioButton_aswap);
            this.Controls.Add(this.radioButton_swap);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.optymalizuj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxHarmonogram);
            this.Controls.Add(this.textBoxDlugoscNaturalna);
            this.Controls.Add(this.textBoxWczytano);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.wczytajLED);
            this.Name = "Form1";
            this.Text = "Projekt nr 2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox wczytajLED;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWczytano;
        private System.Windows.Forms.TextBox textBoxDlugoscNaturalna;
        private System.Windows.Forms.TextBox textBoxHarmonogram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button optymalizuj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton_ins;
        private System.Windows.Forms.RadioButton radioButton_aswap;
        private System.Windows.Forms.RadioButton radioButton_swap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox t0;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sigma;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox liczbaProb;
        private System.Windows.Forms.TextBox textBoxWynik;
        private System.Windows.Forms.Label label11;
    }
}

