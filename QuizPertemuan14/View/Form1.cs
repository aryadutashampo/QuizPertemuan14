using QuizPertemuan14.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizPertemuan14
{
    public partial class FormUtama : Form
    {
        LoginController LCtrl;
        public FormUtama()
        {
            LCtrl = new LoginController();
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Keluar Program", "Keluar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }


        private void FormUtama_Load(object sender, EventArgs e)
        {
            txtEmail.MaxLength = 25;
            txtKS.MaxLength = 10;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string sandi = txtKS.Text;
            DataTable table = LCtrl.getList(new MySqlConnector.MySqlCommand
                ("SELECT * FROM admin WHERE email = '" + email + "' AND kata_sandi ='" + sandi + "'"));

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Login Berhasil!!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormUtama fu = new FormUtama();
                this.Hide();
                fu.Show();
            }
            else
            {
                MessageBox.Show("Email dan Kata Sandi Tidak Ada!", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
