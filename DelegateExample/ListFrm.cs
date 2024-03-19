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
    public partial class ListFrm : Form
    {
        UserFrm userFrm;
        public ListFrm()
        {
            InitializeComponent();
        }

        private void ListFrm_Load(object sender, EventArgs e)
        {
            userFrm = new UserFrm();
            userFrm.Show();
            userFrm.WritingUser += UserFrm_WritingUser;
            userFrm.ValidatingUser += UserFrm_ValidatingUser;
        }

        private void UserFrm_ValidatingUser(string user)
        {
            lstUsers.Items.Add(user);
        }

        private void UserFrm_WritingUser(string user)
        {
            currentUser.Text = user;
        }
    }
}
