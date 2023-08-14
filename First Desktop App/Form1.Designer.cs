namespace First_Desktop_App
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
            this.ReadCodes_Language_Topics = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ReadCodes_Codes = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReadCodes_select_language = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReadCodes_CodeText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ReadCodes_Language_Topics
            // 
            this.ReadCodes_Language_Topics.FormattingEnabled = true;
            this.ReadCodes_Language_Topics.Location = new System.Drawing.Point(709, 142);
            this.ReadCodes_Language_Topics.Name = "ReadCodes_Language_Topics";
            this.ReadCodes_Language_Topics.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReadCodes_Language_Topics.Size = new System.Drawing.Size(144, 108);
            this.ReadCodes_Language_Topics.TabIndex = 0;
            this.ReadCodes_Language_Topics.SelectedIndexChanged += new System.EventHandler(this.ReadCodes_Language_Topics_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 17);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "توضیحات کد :";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(709, 12);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(144, 23);
            this.add.TabIndex = 3;
            this.add.Text = "افزودن کد جدید";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(762, 126);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "دسته بندی کد ها :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ReadCodes_Codes
            // 
            this.ReadCodes_Codes.FormattingEnabled = true;
            this.ReadCodes_Codes.Location = new System.Drawing.Point(709, 269);
            this.ReadCodes_Codes.Name = "ReadCodes_Codes";
            this.ReadCodes_Codes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReadCodes_Codes.Size = new System.Drawing.Size(144, 251);
            this.ReadCodes_Codes.TabIndex = 0;
            this.ReadCodes_Codes.SelectedIndexChanged += new System.EventHandler(this.ReadCodes_CodeText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(795, 253);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "انتخاب کد :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(780, 48);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "زبان مورد نظر :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ReadCodes_select_language
            // 
            this.ReadCodes_select_language.FormattingEnabled = true;
            this.ReadCodes_select_language.Location = new System.Drawing.Point(709, 66);
            this.ReadCodes_select_language.Name = "ReadCodes_select_language";
            this.ReadCodes_select_language.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReadCodes_select_language.Size = new System.Drawing.Size(144, 56);
            this.ReadCodes_select_language.TabIndex = 0;
            this.ReadCodes_select_language.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            this.ReadCodes_select_language.SelectedValueChanged += new System.EventHandler(this.ReadCodes_select_language_SelectedValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 500);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(691, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(631, 481);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "کلمات کلیدی :";
            // 
            // ReadCodes_CodeText
            // 
            this.ReadCodes_CodeText.Location = new System.Drawing.Point(15, 66);
            this.ReadCodes_CodeText.Name = "ReadCodes_CodeText";
            this.ReadCodes_CodeText.Size = new System.Drawing.Size(688, 408);
            this.ReadCodes_CodeText.TabIndex = 6;
            this.ReadCodes_CodeText.Text = "";
            this.ReadCodes_CodeText.TextChanged += new System.EventHandler(this.ReadCodes_CodeText_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(865, 528);
            this.Controls.Add(this.ReadCodes_CodeText);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReadCodes_Codes);
            this.Controls.Add(this.ReadCodes_select_language);
            this.Controls.Add(this.ReadCodes_Language_Topics);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox ReadCodes_Language_Topics;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ReadCodes_Codes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox ReadCodes_select_language;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox ReadCodes_CodeText;
    }
}

