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
	public partial class Form6 : Form
	{
        MySqlConnection conn;
        MySqlCommand comm;
        MySqlDataAdapter da;
        DataSet ds, ds1, ds2, ds3, ds4;
        DataTable dt;
        DataRow dr;
        int id;
        public Form6(int id_no)
        {
            id = id_no;
            InitializeComponent();
            loadDetails();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "server=localhost;user id=root;database=dbmsproject;port=3306";
                MySqlConnection ob = new MySqlConnection(myConnection);
                MySqlDataAdapter obj = new MySqlDataAdapter();

                obj.SelectCommand = new MySqlCommand("insert into assigned values('" + id + "', '" + 12 + "')", ob);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(obj);
                ob.Open();
                DataSet ds = new DataSet();
                obj.Fill(ds);

                MessageBox.Show("Trainer added successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ob.Close();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "server=localhost;user id=root;database=dbmsproject;port=3306";
                MySqlConnection ob = new MySqlConnection(myConnection);
                MySqlDataAdapter obj = new MySqlDataAdapter();

                obj.SelectCommand = new MySqlCommand("insert into assigned values('" + id + "', '" + 14 + "')", ob);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(obj);
                ob.Open();
                DataSet ds = new DataSet();
                obj.Fill(ds);

                MessageBox.Show("Trainer added successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ob.Close();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "server=localhost;user id=root;database=dbmsproject;port=3306"; 
                MySqlConnection ob = new MySqlConnection(myConnection);
                MySqlDataAdapter obj = new MySqlDataAdapter();

                obj.SelectCommand = new MySqlCommand("insert into assigned values('" + id + "', '" + 17 + "')", ob);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(obj);
                ob.Open();
                DataSet ds = new DataSet();
                obj.Fill(ds);

                MessageBox.Show("Trainer added successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ob.Close();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "server=localhost;user id=root;database=dbmsproject;port=3306";
                MySqlConnection ob = new MySqlConnection(myConnection);
                MySqlDataAdapter obj = new MySqlDataAdapter();

                obj.SelectCommand = new MySqlCommand("insert into assigned values('" + id + "', '" + 19 + "')", ob);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(obj);
                ob.Open();
                DataSet ds = new DataSet();
                obj.Fill(ds);

                MessageBox.Show("Trainer added successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ob.Close();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "server=localhost;user id=root;database=dbmsproject;port=3306";
                MySqlConnection ob = new MySqlConnection(myConnection);
                MySqlDataAdapter obj = new MySqlDataAdapter();

                obj.SelectCommand = new MySqlCommand("insert into assigned values('" + id + "', '" + 11 + "')", ob);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(obj);
                ob.Open();
                DataSet ds = new DataSet();
                obj.Fill(ds);
                MessageBox.Show("Trainer added successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ob.Close();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
        

        public void loadDetails()
        {

            try
            {
                string myConnection = "server=localhost;user id=root;database=dbmsproject;port=3306";
                MySqlConnection ob = new MySqlConnection(myConnection);
                MySqlDataAdapter obj = new MySqlDataAdapter();
                
                obj.SelectCommand = new MySqlCommand("select * from trainer_details where trainer_ID ='11'", ob);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(obj);
                ob.Open();
                DataSet ds = new DataSet();
                obj.Fill(ds);
                dr = ds.Tables[0].Rows[0];
                label2.Text = dr["Name"].ToString();
                label3.Text = dr["Level_of_ex"].ToString();
                label5.Text = dr["Phone"].ToString();
                label4.Text = dr["Email"].ToString();
                label7.Text = dr["No_of_clients"].ToString();
                label6.Text = dr["Note"].ToString();
                ob.Close();
                
                obj.SelectCommand = new MySqlCommand("select * from trainer_details where trainer_ID ='12'", ob);
                MySqlCommandBuilder cb1 = new MySqlCommandBuilder(obj);
                ob.Open();
                DataSet ds1 = new DataSet();
                obj.Fill(ds1);
                dr = ds1.Tables[0].Rows[0];
                label13.Text = dr["Name"].ToString();
                label12.Text = dr["Level_of_ex"].ToString();
                label11.Text = dr["Phone"].ToString();
                label10.Text = dr["Email"].ToString();
                label9.Text = dr["No_of_clients"].ToString();
                label8.Text = dr["Note"].ToString();
                ob.Close();
                
                obj.SelectCommand = new MySqlCommand("select * from trainer_details where trainer_ID ='14'", ob);
                MySqlCommandBuilder cb2 = new MySqlCommandBuilder(obj);
                ob.Open();
                DataSet ds2 = new DataSet();
                obj.Fill(ds2);
                dr = ds2.Tables[0].Rows[0];
                label19.Text = dr["Name"].ToString();
                label18.Text = dr["Level_of_ex"].ToString();
                label17.Text = dr["Phone"].ToString();
                label16.Text = dr["Email"].ToString();
                label15.Text = dr["No_of_clients"].ToString();
                label14.Text = dr["Note"].ToString();
                ob.Close();

                obj.SelectCommand = new MySqlCommand("select * from trainer_details where trainer_ID ='17'", ob);
                MySqlCommandBuilder cb3 = new MySqlCommandBuilder(obj);
                ob.Open();
                DataSet ds3 = new DataSet();
                obj.Fill(ds3);
                dr = ds3.Tables[0].Rows[0];
                label25.Text = dr["Name"].ToString();
                label24.Text = dr["Level_of_ex"].ToString();
                label23.Text = dr["Phone"].ToString();
                label22.Text = dr["Email"].ToString();
                label21.Text = dr["No_of_clients"].ToString();
                label20.Text = dr["Note"].ToString();
                ob.Close();

                obj.SelectCommand = new MySqlCommand("select * from trainer_details where trainer_ID ='19'", ob);
                MySqlCommandBuilder cb4 = new MySqlCommandBuilder(obj);
                ob.Open();
                DataSet ds4 = new DataSet();
                obj.Fill(ds4);
                dr = ds4.Tables[0].Rows[0];
                label31.Text = dr["Name"].ToString();
                label30.Text = dr["Level_of_ex"].ToString();
                label29.Text = dr["Phone"].ToString();
                label28.Text = dr["Email"].ToString();
                label27.Text = dr["No_of_clients"].ToString();
                label26.Text = dr["Note"].ToString();
                ob.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
