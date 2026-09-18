namespace Calculator_app
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
            this.texttemp = new System.Windows.Forms.TextBox();
            this.textutama = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnkd = new System.Windows.Forms.Button();
            this.btnkali = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnbagi = new System.Windows.Forms.Button();
            this.btnkoma = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnsama = new System.Windows.Forms.Button();
            this.btntambah = new System.Windows.Forms.Button();
            this.btnkurang = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texttemp
            // 
            this.texttemp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.texttemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texttemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.texttemp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.texttemp.Location = new System.Drawing.Point(42, 25);
            this.texttemp.Name = "texttemp";
            this.texttemp.ReadOnly = true;
            this.texttemp.Size = new System.Drawing.Size(274, 16);
            this.texttemp.TabIndex = 0;
            this.texttemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textutama
            // 
            this.textutama.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textutama.Location = new System.Drawing.Point(42, 47);
            this.textutama.Name = "textutama";
            this.textutama.ReadOnly = true;
            this.textutama.Size = new System.Drawing.Size(274, 38);
            this.textutama.TabIndex = 1;
            this.textutama.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textutama.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(42, 106);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(64, 46);
            this.btnC.TabIndex = 27;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(112, 106);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(64, 46);
            this.btnCE.TabIndex = 28;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(42, 158);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(64, 46);
            this.btn7.TabIndex = 29;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnkd
            // 
            this.btnkd.Location = new System.Drawing.Point(182, 106);
            this.btnkd.Name = "btnkd";
            this.btnkd.Size = new System.Drawing.Size(64, 46);
            this.btnkd.TabIndex = 29;
            this.btnkd.Text = "<";
            this.btnkd.UseVisualStyleBackColor = true;
            this.btnkd.Click += new System.EventHandler(this.btnkd_Click);
            // 
            // btnkali
            // 
            this.btnkali.Location = new System.Drawing.Point(252, 106);
            this.btnkali.Name = "btnkali";
            this.btnkali.Size = new System.Drawing.Size(64, 46);
            this.btnkali.TabIndex = 30;
            this.btnkali.Text = "X";
            this.btnkali.UseVisualStyleBackColor = true;
            this.btnkali.Click += new System.EventHandler(this.btnoperator_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(112, 158);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(64, 46);
            this.btn8.TabIndex = 31;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(182, 158);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(64, 46);
            this.btn9.TabIndex = 32;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnbagi
            // 
            this.btnbagi.Location = new System.Drawing.Point(252, 158);
            this.btnbagi.Name = "btnbagi";
            this.btnbagi.Size = new System.Drawing.Size(64, 46);
            this.btnbagi.TabIndex = 33;
            this.btnbagi.Text = ":";
            this.btnbagi.UseVisualStyleBackColor = true;
            this.btnbagi.Click += new System.EventHandler(this.btnoperator_Click);
            // 
            // btnkoma
            // 
            this.btnkoma.Location = new System.Drawing.Point(42, 314);
            this.btnkoma.Name = "btnkoma";
            this.btnkoma.Size = new System.Drawing.Size(64, 46);
            this.btnkoma.TabIndex = 34;
            this.btnkoma.Text = ",";
            this.btnkoma.UseVisualStyleBackColor = true;
            this.btnkoma.Click += new System.EventHandler(this.btnkoma_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(42, 210);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(64, 46);
            this.btn4.TabIndex = 34;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(42, 262);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(64, 46);
            this.btn1.TabIndex = 35;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(182, 314);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(64, 46);
            this.button12.TabIndex = 36;
            this.button12.Text = "+/-";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(112, 314);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(64, 46);
            this.btn0.TabIndex = 37;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnsama
            // 
            this.btnsama.Location = new System.Drawing.Point(252, 314);
            this.btnsama.Name = "btnsama";
            this.btnsama.Size = new System.Drawing.Size(64, 46);
            this.btnsama.TabIndex = 38;
            this.btnsama.Text = "=";
            this.btnsama.UseVisualStyleBackColor = true;
            this.btnsama.Click += new System.EventHandler(this.btnoperator_Click);
            // 
            // btntambah
            // 
            this.btntambah.Location = new System.Drawing.Point(252, 262);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(64, 46);
            this.btntambah.TabIndex = 39;
            this.btntambah.Text = "+";
            this.btntambah.UseVisualStyleBackColor = true;
            this.btntambah.Click += new System.EventHandler(this.btnoperator_Click);
            // 
            // btnkurang
            // 
            this.btnkurang.Location = new System.Drawing.Point(252, 210);
            this.btnkurang.Name = "btnkurang";
            this.btnkurang.Size = new System.Drawing.Size(64, 46);
            this.btnkurang.TabIndex = 40;
            this.btnkurang.Text = "-";
            this.btnkurang.UseVisualStyleBackColor = true;
            this.btnkurang.Click += new System.EventHandler(this.btnoperator_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(112, 210);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(64, 46);
            this.btn5.TabIndex = 41;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(182, 210);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(64, 46);
            this.btn6.TabIndex = 42;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(182, 262);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(64, 46);
            this.btn3.TabIndex = 43;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(112, 262);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(64, 46);
            this.btn2.TabIndex = 44;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(358, 399);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnkurang);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.btnsama);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnkoma);
            this.Controls.Add(this.btnbagi);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnkali);
            this.Controls.Add(this.btnkd);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.textutama);
            this.Controls.Add(this.texttemp);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texttemp;
        private System.Windows.Forms.TextBox textutama;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnkd;
        private System.Windows.Forms.Button btnkali;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnbagi;
        private System.Windows.Forms.Button btnkoma;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnsama;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Button btnkurang;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
    }
}

