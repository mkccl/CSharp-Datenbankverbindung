using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatenbankVerbindung
{
    public partial class Form1 : Form
    {
        private string vb = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dercc\Documents\Kunden.mdf;Integrated Security=True;Connect Timeout=30";
        

        public Form1()
        {
            InitializeComponent();
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
            SqlConnection conn = new SqlConnection(vb);
            
        }
    }
}