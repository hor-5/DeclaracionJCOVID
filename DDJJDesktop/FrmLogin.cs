using EntitiesModel;
using MaterialSkin.Controls;
using Services;
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
    public partial class FrmLogin : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private SecurityServices securityServices = new SecurityServices();

        public FrmLogin()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400,MaterialSkin.TextShade.WHITE);
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
            lblNotification.Visible = false;
        }

        private void txtIngresar_Click(object sender, EventArgs e)
        {            
            User currentUser = securityServices.login(txtUser.Text,txtPass.Text);
            FrmData frmData = new FrmData(currentUser);
            if (currentUser != null)
            {
                frmData.Show();
                this.Hide();
                lblNotification.Visible = true;
                lblNotification.BackColor = Color.Green;
            }
            else {

                lblNotification.Visible = true;
                lblNotification.Text = "Los datos ingresados son incorrectos!";
                lblNotification.BackColor = Color.Red;
                lblNotification.ForeColor = Color.AntiqueWhite;
            }

        }

        private void btnNoUser_Click(object sender, EventArgs e)
        {
            FrmData frmData = new FrmData();
            frmData.Show();
            this.Hide();
        }
    }
}
