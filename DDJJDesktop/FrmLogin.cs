using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDJJDesktop
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnNoUser_Click(object sender, EventArgs e)
        {
    
            
        }

        private void btnWUser_Click(object sender, EventArgs e)
        {
            grpLogin.Visible = true;
            grpWelcome.Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            grpLogin.Visible = false;
            grpWelcome.Visible = true;
        }
    }
}
