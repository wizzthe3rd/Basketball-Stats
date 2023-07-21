using System;
using System.Data.OleDb;
using System.IO;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
              
        }

        public const String connString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = BSS Databse.accdb";

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(Program.connString);
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "SELECT * FROM Users WHERE Username ='" + txUsername.Text + "'";
            OleDbDataReader reader = Cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                if (txPassword.Text == reader["Pword"].ToString())
                {
                    MessageBox.Show("Log-in successful!");
                    gbSignIn.Hide();
                    btSignIn.Hide();
                    btExit.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }
            else
            {
                MessageBox.Show("User name not found.");
            }
            Conn.Close();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("BSS Databse.accdb") == false)
            {
                ADOX.Catalog cat = new ADOX.Catalog();
                cat.Create(Program.connString);
                OleDbConnection Conn = new OleDbConnection(Program.connString);
                Conn.Open();
                OleDbCommand Cmd = new OleDbCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = "CREATE TABLE Users (Username CHAR(20), Pword VARCHAR(20), PRIMARY KEY (Pword))";
                Cmd.ExecuteNonQuery();
                Conn.Close();
            }
        }

        private void btSignIn_Click(object sender, EventArgs e)
        {
            SignIn fmSignIn = new SignIn();
            fmSignIn.ShowDialog();
        }
    }
}
