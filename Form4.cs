using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_project
{
	public partial class Form4 : Form
	{
		int id;
		public Form4(int id_no)
		{
			id = id_no;
			InitializeComponent();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Form6 trainer = new Form6(id);
			trainer.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form8 profile = new Form8(id);
			profile.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form7 health = new Form7(id);
			health.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form9 session = new Form9(id);
			session.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Form5 diet = new Form5();
			diet.Show();
		}

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
