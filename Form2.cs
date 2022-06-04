using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;


namespace DBS_project
{
	public partial class Form2 : Form
	{
        String x;
		public Form2()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
            try
            {
                string myConnection = "server=localhost;user id=root;database=dbmsproject;port=3306"; 
                MySqlConnection ob = new MySqlConnection(myConnection);
                MySqlDataAdapter obj = new MySqlDataAdapter();
                obj.SelectCommand = new MySqlCommand("select * from client_details where ID ='" + textBox1.Text + "' and Password='" + textBox2.Text + "';", ob);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(obj);
                x = textBox1.Text;
                ob.Open();
                DataSet ds = new DataSet();
                obj.Fill(ds);
                // MessageBox.Show("connected");
                if (ds.Tables[0].Rows.Count != 0)
                {
                    this.Hide();
                    Form4 home = new Form4(int.Parse(textBox1.Text));
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                }
                ob.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
