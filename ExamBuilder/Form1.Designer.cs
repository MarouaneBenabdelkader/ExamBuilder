namespace ExamBuilder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Timepicker1 = new System.Windows.Forms.DateTimePicker();
            this.Timepicker2 = new System.Windows.Forms.DateTimePicker();
            this.Btn1 = new System.Windows.Forms.Button();
            this.TxtBox1 = new System.Windows.Forms.TextBox();
            this.TxtBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(97, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 130);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(241, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "Examen generateur";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(123, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titre ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(121, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Heure Debut";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(123, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "Heure Fin";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(123, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 36);
            this.label6.TabIndex = 6;
            this.label6.Text = "Specialite";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Timepicker1
            // 
            this.Timepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Timepicker1.Location = new System.Drawing.Point(349, 325);
            this.Timepicker1.Name = "Timepicker1";
            this.Timepicker1.ShowUpDown = true;
            this.Timepicker1.Size = new System.Drawing.Size(268, 27);
            this.Timepicker1.TabIndex = 8;
            this.Timepicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.Timepicker1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePicker1_MouseDown);
            // 
            // Timepicker2
            // 
            this.Timepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Timepicker2.Location = new System.Drawing.Point(349, 415);
            this.Timepicker2.Name = "Timepicker2";
            this.Timepicker2.ShowUpDown = true;
            this.Timepicker2.Size = new System.Drawing.Size(268, 27);
            this.Timepicker2.TabIndex = 9;
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(655, 738);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(188, 33);
            this.Btn1.TabIndex = 11;
            this.Btn1.Text = "Next";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // TxtBox1
            // 
            this.TxtBox1.Location = new System.Drawing.Point(347, 227);
            this.TxtBox1.Name = "TxtBox1";
            this.TxtBox1.Size = new System.Drawing.Size(268, 27);
            this.TxtBox1.TabIndex = 12;
            this.TxtBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtBox2
            // 
            this.TxtBox2.Location = new System.Drawing.Point(347, 499);
            this.TxtBox2.Name = "TxtBox2";
            this.TxtBox2.Size = new System.Drawing.Size(268, 27);
            this.TxtBox2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(927, 844);
            this.Controls.Add(this.TxtBox2);
            this.Controls.Add(this.TxtBox1);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Timepicker2);
            this.Controls.Add(this.Timepicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker Timepicker1;
        private DateTimePicker Timepicker2;
        private Button Btn1;
        private TextBox TxtBox1;
        private TextBox TxtBox2;
    }
}