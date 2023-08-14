using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Desktop_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InsertCode_Code_Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InsertCode_Code_Language.Text == null || InsertCode_Code_Language.Text == "")
                return;
            InsertCode_Code_Topics.Items.Clear();
            List<string> Topics = initial.get_programming_language_topics(InsertCode_Code_Language.Text);

            foreach (string Topic in Topics)
            {
                InsertCode_Code_Topics.Items.Add(Topic);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (string Language in initial.Programming_Languages)
            {
                InsertCode_Code_Language.Items.Add(Language);
            }
        }

        private void InsertCode_Code_Group_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InsertCode_Submit_Code_Click(object sender, EventArgs e)
        {
            if (InsertCode_Code_Language.Text == null || InsertCode_Code_Language.Text == "" ||
                InsertCode_Code_Title.Text == null || InsertCode_Code_Title.Text == "" ||
                InsertCode_Code_Topics.Text == null || InsertCode_Code_Topics.Text == "" ||
                InsertCode_Code_Text.Text == null || InsertCode_Code_Text.Text == ""
                )//Not Selected Inputs
            {
                MessageBox.Show("لطفا پیش از ثبت کد، فیلد های مورد نظر را تکمیل کنید.");
                return;
            }
            initial.Programming_Datas[InsertCode_Code_Language.Text][InsertCode_Code_Topics.Text].Add(InsertCode_Code_Title.Text, InsertCode_Code_Text.Text);
            MessageBox.Show("کد با موفقیت افزوده شد");

            this.Close();
        }
    }
}
