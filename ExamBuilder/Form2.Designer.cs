namespace ExamBuilder
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtBox0 = new System.Windows.Forms.TextBox();
            this.TxtBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtBox2 = new System.Windows.Forms.TextBox();
            this.TxtBox3 = new System.Windows.Forms.TextBox();
            this.TxtBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Txt1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choix de Question";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type de Question";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "QCM",
            "DICOTHOMIQUE",
            "OUVERTE"});
            this.comboBox1.Location = new System.Drawing.Point(293, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(287, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(63, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Question";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(293, 197);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(287, 28);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(63, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(348, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Inserer une nouvelle question";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(63, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type de Question";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(63, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "Question";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(63, 503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 37);
            this.label7.TabIndex = 11;
            this.label7.Text = "Reponse";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TxtBox0
            // 
            this.TxtBox0.Location = new System.Drawing.Point(293, 449);
            this.TxtBox0.Name = "TxtBox0";
            this.TxtBox0.Size = new System.Drawing.Size(287, 27);
            this.TxtBox0.TabIndex = 13;
            // 
            // TxtBox1
            // 
            this.TxtBox1.Location = new System.Drawing.Point(293, 513);
            this.TxtBox1.Name = "TxtBox1";
            this.TxtBox1.Size = new System.Drawing.Size(287, 27);
            this.TxtBox1.TabIndex = 14;
            this.TxtBox1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(63, 560);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 36);
            this.label8.TabIndex = 16;
            this.label8.Text = "Proposition 2";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(63, 620);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 36);
            this.label9.TabIndex = 17;
            this.label9.Text = "Proposition 3";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(63, 674);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 36);
            this.label11.TabIndex = 19;
            this.label11.Text = "Proposition 4";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // TxtBox2
            // 
            this.TxtBox2.Location = new System.Drawing.Point(293, 569);
            this.TxtBox2.Name = "TxtBox2";
            this.TxtBox2.Size = new System.Drawing.Size(287, 27);
            this.TxtBox2.TabIndex = 20;
            // 
            // TxtBox3
            // 
            this.TxtBox3.Location = new System.Drawing.Point(293, 629);
            this.TxtBox3.Name = "TxtBox3";
            this.TxtBox3.Size = new System.Drawing.Size(287, 27);
            this.TxtBox3.TabIndex = 21;
            this.TxtBox3.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // TxtBox4
            // 
            this.TxtBox4.Location = new System.Drawing.Point(293, 683);
            this.TxtBox4.Name = "TxtBox4";
            this.TxtBox4.Size = new System.Drawing.Size(287, 27);
            this.TxtBox4.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 730);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 28);
            this.button2.TabIndex = 23;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(643, 814);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 28);
            this.button3.TabIndex = 24;
            this.button3.Text = "Generate";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "QCM",
            "DICOTHOMIQUE",
            "OUVERTE"});
            this.comboBox3.Location = new System.Drawing.Point(293, 379);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(287, 28);
            this.comboBox3.TabIndex = 25;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.comboBox3.DropDownClosed += new System.EventHandler(this.comboBox3_DropDownClosed);
            this.comboBox3.TextChanged += new System.EventHandler(this.comboBox3_TextChanged);
            this.comboBox3.Leave += new System.EventHandler(this.comboBox3_Leave);
            this.comboBox3.MouseLeave += new System.EventHandler(this.comboBox3_MouseLeave);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(472, 814);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 28);
            this.button4.TabIndex = 26;
            this.button4.Text = "Precedent";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Txt1
            // 
            this.Txt1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt1.Location = new System.Drawing.Point(380, 240);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(72, 30);
            this.Txt1.TabIndex = 27;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 854);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtBox4);
            this.Controls.Add(this.TxtBox3);
            this.Controls.Add(this.TxtBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtBox1);
            this.Controls.Add(this.TxtBox0);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TxtBox0;
        private TextBox TxtBox1;
        private Button button1;
        private Label label8;
        private Label label9;
        private Label label11;
        private TextBox TxtBox2;
        private TextBox TxtBox3;
        private TextBox TxtBox4;
        private Button button2;
        private Button button3;
        private ComboBox comboBox3;
        private Button button4;
        private Label Txt1;
    }
}