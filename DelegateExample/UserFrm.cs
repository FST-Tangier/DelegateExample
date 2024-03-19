using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateExample
{

    public partial class UserFrm : Form
    {
        public delegate void UserRequestHandler(string user);
        public event UserRequestHandler WritingUser;
        public event UserRequestHandler ValidatingUser;
        public UserFrm()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            ValidatingUser(txtUser.Text);
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            WritingUser(txtUser.Text);
        }
    }
}
