using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataServices.Repository.ReadRepository;
using DataServices;

namespace PasswordGenerator
{
    public partial class FormLogin : Form
    {
        private UserReadRepository _userReadRepository;
        private FormMain _formMain;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool exists = false;
            using (var userCtx = new UserContext())
            {
                _userReadRepository = new UserReadRepository(userCtx);

               exists = _userReadRepository.CheckLogin(textBoxLogin.Text, textBoxPassword.Text);
            }

            if(exists)
            {
                //MessageBox.Show("Istnieje.");
                _formMain = new FormMain();
                _formMain.Show();
            }
            else
            {
                MessageBox.Show("Nie istnieje.");
            }
        }
    }
}
