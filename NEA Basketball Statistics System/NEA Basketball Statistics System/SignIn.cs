using System;
using System.IO;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_Basketball_Statistics_System
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "INSERT INTO Users VALUES('"+ txUsername.Text+"', '"+ txPassword.Text+"')";
            Cmd.ExecuteNonQuery();
            Conn.Close();
            MessageBox.Show("Account Created Successfully");
            Close();
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
