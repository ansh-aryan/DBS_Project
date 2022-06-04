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

	public partial class Form9 : Form
	{
        MySqlConnection conn;
        MySqlCommand comm;
        MySqlDataAdapter da;
        DataSet ds, ds1, ds2, ds3, ds4;
        DataTable dt;
        DataRow dr;
        int id;
        public Form9(int id_no)
        {
            id = id_no;
            InitializeComponent();
            func1();
        }

        public void func1()
        { 
        try
            {
                string myConnection = "server=localhost;user id=root;database=dbmsproject;port=3306";
                MySqlConnection ob = new MySqlConnection(myConnection);
        MySqlDataAdapter obj = new MySqlDataAdapter();
        obj.SelectCommand = new MySqlCommand("select * from trainer_details where trainer_id in (select trainer_id from assigned where id ='" + id + "')", ob);
        MySqlCommandBuilder cb1 = new MySqlCommandBuilder(obj);
        ob.Open();
                DataSet ds1 = new DataSet();
        obj.Fill(ds1);

                dr = ds1.Tables[0].Rows[0];
                label9.Text = dr["name"].ToString();
        label12.Text = dr["trainer_id"].ToString();
        ob.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
try
{
    string myConnection = "server=localhost;user id=root;database=dbmsproject;port=3306"; 
    MySqlConnection ob = new MySqlConnection(myConnection);
    MySqlDataAdapter obj = new MySqlDataAdapter();
    obj.SelectCommand = new MySqlCommand("select * from health_details where id ='" + id + "'", ob);
    MySqlCommandBuilder cb2 = new MySqlCommandBuilder(obj);
    ob.Open();
    DataSet ds2 = new DataSet();
    obj.Fill(ds2);

    dr = ds2.Tables[0].Rows[0];
    label11.Text = dr["Fitness_score"].ToString();

    ob.Close();
}

catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
}

private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
