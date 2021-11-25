using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class Form1 : Form
    {
        Config db = new Config();
        public Form1()
        {
            InitializeComponent();
            db.Connect("userdata");
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            db.ExecutedSelect("SELECT * FROM `user_info` where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'");
            if (db.Count() == 1)
            {
                MessageBox.Show("Sukses! Anda masuk sebagai " + db.Results(0, "names"));
            }
            else
            {
                MessageBox.Show("Kombinasi user dan password salah!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
