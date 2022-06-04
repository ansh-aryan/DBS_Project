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
   
    
    public partial class Form3 : Form
	{
        MySqlConnection conn;
        MySqlCommand comm;
        MySqlDataAdapter da;
        DataSet ds, ds4;
        DataTable dt;
        DataRow dr;
        int ss;
        public Form3()
		{
			InitializeComponent();
		}
       
        private void button1_Click(object sender, EventArgs e)
		{
            try
            {
                string myConnection = "server=localhost;user id=root;database=dbmsproject;port=3306";
                MySqlConnection ob = new MySqlConnection(myConnection);
                MySqlDataAdapter obj = new MySqlDataAdapter();

                obj.SelectCommand = new MySqlCommand("insert into Client_Details(Name, Email, Password, Phone) values('" + this.textBox1.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox2.Text + "')", ob);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(obj);
                ob.Open();
                DataSet ds = new DataSet();
                obj.Fill(ds);

                obj.SelectCommand = new MySqlCommand("select * from client_details where name ='" + this.textBox1.Text + "'", ob);
                MySqlCommandBuilder cb4 = new MySqlCommandBuilder(obj);
                DataSet ds4 = new DataSet();
                obj.Fill(ds4);

                dr = ds4.Tables[0].Rows[0];
                ss = int.Parse(dr["ID"].ToString());
                MessageBox.Show("Account successfully Created and your ID is: "+ss, "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                ob.Close();
                Form2 login = new Form2();
                login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
