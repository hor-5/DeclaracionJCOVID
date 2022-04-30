using EntitiesModel;
using Services;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDJJDesktop
{
    
    public partial class FrmData : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;        
        private User user;
        private HTTPRequests httpRequests;
        public FrmData()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);

            fillSelects();
        }

        public FrmData(User currentUser)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);

            fillTextBox(currentUser);

        }

        private void FrmData_Load(object sender, EventArgs e)
        {                  

        }

        private void fillTextBox(User currentUser)
        {
            txtDni.Text = currentUser.dni;
            txtDni.Enabled = false;
            txtName.Text = currentUser.firstName;
            txtName.Enabled = false;
            txtSurname.Text = currentUser.surName;
            txtSurname.Enabled = false;
            sltCodArea.Items.Add(currentUser.codCountry);
            sltCodArea.SelectedIndex = 0;
            sltCodArea.Enabled = false;
            txtCodArea.Text = currentUser.codArea;
            txtCodArea.Enabled = false;
            txtTelNumber.Text = currentUser.telephone;
            txtTelNumber.Enabled = false;            
            txtEnterprise.Text = currentUser.enterprise;
            txtEnterprise.Enabled = false;
            txtMail.Text = currentUser.email.Address;
            txtMail.Enabled = false;
            sltGender.Items.Add(currentUser.gender);
            sltGender.SelectedIndex = 0;
            sltGender.Enabled = false;            
            sltDate.Value = currentUser.birthday;
            sltDate.Enabled = false;            
            txtAge.Text = currentUser.age.ToString();
            txtAge.Enabled = false;
            sltNationality.Items.Add(currentUser.nationality);
            sltNationality.SelectedIndex = 0;
            sltNationality.Enabled = false;
            sltResidence.Items.Add(currentUser.residenceCountry);
            sltResidence.SelectedIndex = 0;
            sltResidence.Enabled = false;

        }
        private async void fillSelects() {
            httpRequests = new HTTPRequests();
            string countrys = await httpRequests.getCountrys();
            List<Country> lstCountries = JsonConvert.DeserializeObject<List<Country>>(countrys);
            foreach (Country country in lstCountries)
            {
                sltNationality.Items.Add(country.name.common);
                sltResidence.Items.Add(country.name.common);
                sltCodArea.Items.Add(country.name.common + ": " + (country.idd.root != null ? country.idd.root : "-") + (country.idd.suffixes != null ? country.idd.suffixes[0] : "-"));
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbForm.SelectedIndex++;
            
                       
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            tbForm.SelectedIndex++;
           
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            tbForm.SelectedIndex--;
            
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            tbForm.SelectedIndex--;            
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtEnterprise_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel9_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseModal_Click(object sender, EventArgs e)
        {
            cardModalGR.Visible = false;
            cardVaccine.Visible = true;
        }

        private void btnRiskGroup_Click(object sender, EventArgs e)
        {
            cardVaccine.Visible = false;
            cardModalGR.Visible = true;            
        }

        private void btnSy_Click(object sender, EventArgs e)
        {
            cardSy.Visible = false;
            ModalSy.Visible = true;
        }

        private void btnCloseSy_Click(object sender, EventArgs e)
        {            
            ModalSy.Visible = false;
            cardSy.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(Application.StartupPath, "../../../img/successNotification.png");
            imgResult.Image = Image.FromFile(imagePath);
            imgResult.Location = new System.Drawing.Point(160, 60);
            materialCard4.Visible = false;
            materialCard5.Visible = false;
            materialCard6.Visible = false;
            cardSy.Visible = false;
            btnConfirm.Visible = false;
            btnBack3.Visible = false;
            TabSelector.Visible = false;
        }

        private void CalulateAge(DateTime birthday) {

            int age;
            DateTime localDate = DateTime.Now;

            if (localDate.Month <= birthday.Month)
            {
                if (localDate.Day <= birthday.Day)
                {
                    age = (localDate.Year - birthday.Year);                    
                }
                else
                {
                    age = (localDate.Year - birthday.Year) - 1;                    
                }
            }
            else
            {
                age = (localDate.Year - birthday.Year);                
            }

            txtAge.Text = age.ToString();
        }
        private void txtMail_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtMail.Text.Contains("@"))
            {
                if (txtMail.Text.Contains(".com"))
                {
                    
                    txtMail.HelperText = "Email válido";                    
                }
            }
            else
            {
                txtMail.HelperText = "Debe ingresar un email válido";
            }
        }

        private void sltDate_MouseEnter(object sender, EventArgs e)
        {
            CalulateAge(sltDate.Value);
        }

        private void sltDate_KeyDown(object sender, KeyEventArgs e)
        {
            CalulateAge(sltDate.Value);
        }
    }
}
