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
	public partial class Form8 : Form
	{

        MySqlConnection conn;
        MySqlCommand comm;
        MySqlDataAdapter da;
        DataSet ds, ds1, ds2;
        DataTable dt;
        DataRow dr;
        int id;
        public Form8(int id_no)
		{
            id = id_no;
            InitializeComponent();
            loadDetails();
		}

        public void loadDetails()
        {


            try
            {
                string myConnection = "server=localhost;user id=root;database=dbmsproject;port=3306";
                MySqlConnection ob = new MySqlConnection(myConnection);
                MySqlDataAdapter obj = new MySqlDataAdapter();
                obj.SelectCommand = new MySqlCommand("select * from client_details where id ='" + id + "'", ob);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(obj);
                ob.Open();
                DataSet ds = new DataSet();
                obj.Fill(ds);

                dr = ds.Tables[0].Rows[0];
                label6.Text = dr["name"].ToString();
                label8.Text = dr["email"].ToString();
                label7.Text = dr["phone"].ToString();

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

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
         

        }
    }
}
