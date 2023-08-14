using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace First_Desktop_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (ReadCodes_Codes.Text == null || ReadCodes_Codes.Text == "")
                return;

            ReadCodes_Codes.Items.Clear();
            List<string> Codes = initial.get_programming_codes(ReadCodes_select_language.Text, ReadCodes_Language_Topics.Text);

            foreach (string Code in Codes)
            {
                ReadCodes_Codes.Items.Add(Code);
            }
        }

        private void ReadCodes_Language_Topics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReadCodes_Language_Topics.Text == null || ReadCodes_Language_Topics.Text == "")
                return;
            ReadCodes_Codes.Items.Clear();
            List<string> Codes = initial.get_programming_codes(ReadCodes_select_language.Text, ReadCodes_Language_Topics.Text);

            foreach (string Code in Codes)
            {
                ReadCodes_Codes.Items.Add(Code);
            }
        }
        


        private void add_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void ReadCodes_select_language_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ReadCodes_select_language.Text == null || ReadCodes_select_language.Text == "")
                return;
            ReadCodes_Language_Topics.Items.Clear();
            List<string> Topics = initial.get_programming_language_topics(ReadCodes_select_language.Text);

            foreach(string Topic in Topics)
            {
                ReadCodes_Language_Topics.Items.Add(Topic);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Server=DESKTOP-6Q5JL6D;Database=code_managements;Trusted_Connection=True";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            SqlCommand cmd = new SqlCommand("select * from languages", Connection);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                MessageBox.Show((string)rdr["language"]);
            }
            foreach (string Language in initial.Programming_Languages)
            {
                ReadCodes_select_language.Items.Add(Language);
            }
        }

        private void ReadCodes_CodeText_TextChanged(object sender, EventArgs e)
        {
            if (ReadCodes_Codes.Text == null || ReadCodes_Codes.Text == "")
                return;
            ReadCodes_CodeText.Clear();
            string Code = initial.get_programming_code(ReadCodes_select_language.Text, ReadCodes_Language_Topics.Text, ReadCodes_Codes.Text);
            ReadCodes_CodeText.Text = Code;
        }
    }
}
