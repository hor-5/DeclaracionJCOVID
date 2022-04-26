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
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
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
            imgNotification.Visible = false;
        }

        private void txtIngresar_Click(object sender, EventArgs e)
        {            
            User currentUser = securityServices.login(txtUser.Text,txtPass.Text);
            
            if (currentUser != null)
            {
                showNotification("success");
                FrmData frmData = new FrmData(currentUser);
                frmData.Show();
                this.Hide();
                
                
            }
            else {                
                showNotification("danger");
            }

        }

 
        public void showNotification(string type) {
            imgNotification.Visible = true;
            string imagePath;
            if (type == "success")
            {
                imagePath = Path.Combine(Application.StartupPath, "../../../img/notificacionIngreso.png");
                imgNotification.Image = Image.FromFile(imagePath);                 
            }
            else if (type == "danger") {
                imagePath = Path.Combine(Application.StartupPath, "../../../img/errorIngreso.png");
                imgNotification.Image = Image.FromFile(imagePath);
            }          
            
        }

        private void btnNoUser_Click(object sender, EventArgs e)
        {
            FrmData frmData = new FrmData();
            frmData.Show();
            this.Hide();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            imgNotification.Visible = false;
        }
    }
}
