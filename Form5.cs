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
	public partial class Form5 : Form
	{
        MySqlConnection conn;
        MySqlCommand comm;
        MySqlDataAdapter da;
        DataSet ds, ds1, ds2, ds3, ds4;
        DataTable dt;
        DataRow dr;
        public Form5()
        {
            InitializeComponent();
            loadDetails();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        public void loadDetails()
        {


            try
            {
                string myConnection = "server=localhost;user id=root;database=dbmsproject;port=3306";
                MySqlConnection ob = new MySqlConnection(myConnection);
                MySqlDataAdapter obj = new MySqlDataAdapter();
                obj.SelectCommand = new MySqlCommand("select * from diet_plan where diet_name ='Keto'", ob);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(obj);
                ob.Open();
                DataSet ds = new DataSet();
                obj.Fill(ds);

                dr = ds.Tables[0].Rows[0];
                label16.Text = dr["diet_name"].ToString();
                label17.Text = dr["info"].ToString();
                label19.Text = dr["calories_intake"].ToString();

                ob.Close();

                 obj.SelectCommand = new MySqlCommand("select * from diet_plan where diet_name = 'Low-carbs'", ob);
                MySqlCommandBuilder cb1 = new MySqlCommandBuilder(obj);
                ob.Open();
                DataSet ds1 = new DataSet();
                obj.Fill(ds1);

                dr = ds1.Tables[0].Rows[0];
                label26.Text = dr["diet_name"].ToString();
                label25.Text = dr["info"].ToString();
                label24.Text = dr["calories_intake"].ToString();

                ob.Close();


                obj.SelectCommand = new MySqlCommand("select * from diet_plan where diet_name = 'Protein'", ob);
                MySqlCommandBuilder cb4 = new MySqlCommandBuilder(obj);
                ob.Open();
                DataSet ds4 = new DataSet();
                obj.Fill(ds4);

                dr = ds4.Tables[0].Rows[0];
                label23.Text = dr["diet_name"].ToString();
                label22.Text = dr["info"].ToString();
                label21.Text = dr["calories_intake"].ToString();

                ob.Close();

                obj.SelectCommand = new MySqlCommand("select * from diet_plan where diet_name = 'Vegan'", ob);
                MySqlCommandBuilder cb2 = new MySqlCommandBuilder(obj);
                ob.Open();
                DataSet ds2 = new DataSet();
                obj.Fill(ds2);

                dr = ds2.Tables[0].Rows[0];
                label29.Text = dr["diet_name"].ToString();
                label28.Text = dr["info"].ToString();
                label27.Text = dr["calories_intake"].ToString();

                ob.Close();

                obj.SelectCommand = new MySqlCommand("select * from diet_plan where diet_name = 'Gluten-Free'", ob);
                MySqlCommandBuilder cb3 = new MySqlCommandBuilder(obj);
                ob.Open();
                DataSet ds3 = new DataSet();
                obj.Fill(ds3);

                dr = ds3.Tables[0].Rows[0];
                label32.Text = dr["diet_name"].ToString();
                label31.Text = dr["info"].ToString();
                label30.Text = dr["calories_intake"].ToString();

                ob.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form5_Load(object sender, EventArgs e)
		{

		}

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
