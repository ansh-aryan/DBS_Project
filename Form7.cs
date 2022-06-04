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
	public partial class Form7 : Form
	{
        int id;
        public Form7(int id_no)
        {
            id = id_no;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "server=localhost;user id=root;database=dbmsproject;port=3306";
                MySqlConnection ob = new MySqlConnection(myConnection);
                MySqlDataAdapter obj = new MySqlDataAdapter();

                obj.SelectCommand = new MySqlCommand("insert into Health_Details values('" + id + "', '" + this.textBox5.Text + "','" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text +"','"+(float.Parse(this.textBox2.Text)/(float.Parse(this.textBox1.Text)* float.Parse(this.textBox1.Text))) + "')", ob);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(obj);
                ob.Open();
                DataSet ds = new DataSet();
                obj.Fill(ds);

                MessageBox.Show("Details entered! ", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ob.Close();
                Form4 home = new Form4(id);
                home.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your BMI is:" + (float.Parse(this.textBox2.Text) / (float.Parse(this.textBox1.Text) * float.Parse(this.textBox1.Text))));
        }
    }
}
