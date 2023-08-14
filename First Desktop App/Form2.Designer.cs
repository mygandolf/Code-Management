namespace First_Desktop_App
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
            this.InsertCode_Code_Keywords = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InsertCode_Code_Topics = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InsertCode_Code_Language = new System.Windows.Forms.ListBox();
            this.InsertCode_Code_Text = new System.Windows.Forms.RichTextBox();
            this.InsertCode_Submit_Code = new System.Windows.Forms.Button();
            this.InsertCode_Code_Title = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InsertCode_Code_Keywords
            // 
            this.InsertCode_Code_Keywords.Location = new System.Drawing.Point(12, 166);
            this.InsertCode_Code_Keywords.Name = "InsertCode_Code_Keywords";
            this.InsertCode_Code_Keywords.Size = new System.Drawing.Size(776, 20);
            this.InsertCode_Code_Keywords.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(733, 61);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "عنوان کد :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(744, 189);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "متن کد :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(736, 106);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "گروه کد :";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // InsertCode_Code_Topics
            // 
            this.InsertCode_Code_Topics.FormattingEnabled = true;
            this.InsertCode_Code_Topics.Location = new System.Drawing.Point(12, 122);
            this.InsertCode_Code_Topics.Name = "InsertCode_Code_Topics";
            this.InsertCode_Code_Topics.Size = new System.Drawing.Size(776, 17);
            this.InsertCode_Code_Topics.TabIndex = 4;
            this.InsertCode_Code_Topics.SelectedIndexChanged += new System.EventHandler(this.InsertCode_Code_Group_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(716, 22);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "زبان انتخابی :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 146);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(299, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "کلمات کلیدی : (کلمات را با کاما یا سمیکالون از یکدیگر جدا کنید)";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // InsertCode_Code_Language
            // 
            this.InsertCode_Code_Language.FormattingEnabled = true;
            this.InsertCode_Code_Language.Location = new System.Drawing.Point(12, 38);
            this.InsertCode_Code_Language.Name = "InsertCode_Code_Language";
            this.InsertCode_Code_Language.Size = new System.Drawing.Size(776, 17);
            this.InsertCode_Code_Language.TabIndex = 4;
            this.InsertCode_Code_Language.SelectedIndexChanged += new System.EventHandler(this.InsertCode_Code_Language_SelectedIndexChanged);
            // 
            // InsertCode_Code_Text
            // 
            this.InsertCode_Code_Text.Location = new System.Drawing.Point(12, 205);
            this.InsertCode_Code_Text.Name = "InsertCode_Code_Text";
            this.InsertCode_Code_Text.Size = new System.Drawing.Size(776, 196);
            this.InsertCode_Code_Text.TabIndex = 5;
            this.InsertCode_Code_Text.Text = "";
            // 
            // InsertCode_Submit_Code
            // 
            this.InsertCode_Submit_Code.Location = new System.Drawing.Point(364, 415);
            this.InsertCode_Submit_Code.Name = "InsertCode_Submit_Code";
            this.InsertCode_Submit_Code.Size = new System.Drawing.Size(75, 23);
            this.InsertCode_Submit_Code.TabIndex = 6;
            this.InsertCode_Submit_Code.Text = "ثبت کد";
            this.InsertCode_Submit_Code.UseVisualStyleBackColor = true;
            this.InsertCode_Submit_Code.Click += new System.EventHandler(this.InsertCode_Submit_Code_Click);
            // 
            // InsertCode_Code_Title
            // 
            this.InsertCode_Code_Title.Location = new System.Drawing.Point(12, 83);
            this.InsertCode_Code_Title.Name = "InsertCode_Code_Title";
            this.InsertCode_Code_Title.Size = new System.Drawing.Size(776, 20);
            this.InsertCode_Code_Title.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InsertCode_Submit_Code);
            this.Controls.Add(this.InsertCode_Code_Text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InsertCode_Code_Language);
            this.Controls.Add(this.InsertCode_Code_Topics);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InsertCode_Code_Title);
            this.Controls.Add(this.InsertCode_Code_Keywords);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InsertCode_Code_Keywords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox InsertCode_Code_Topics;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox InsertCode_Code_Language;
        private System.Windows.Forms.RichTextBox InsertCode_Code_Text;
        private System.Windows.Forms.Button InsertCode_Submit_Code;
        private System.Windows.Forms.TextBox InsertCode_Code_Title;
    }
}