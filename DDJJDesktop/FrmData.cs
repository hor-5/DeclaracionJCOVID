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
using System.Net.Mail;

namespace DDJJDesktop
{

    public partial class FrmData : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        private HTTPRequests httpRequests;
        public ValidationServices validationFinal = new ValidationServices();
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
            sltCodArea.SelectedItem = currentUser.codCountry;
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
            sltGender.SelectedItem = currentUser.gender;
            sltGender.Enabled = false;
            sltDate.Value = currentUser.birthday;
            sltDate.Enabled = false;
            txtAge.Text = currentUser.age.ToString();
            txtAge.Enabled = false;
            sltNationality.Items.Add(currentUser.nationality);
            sltNationality.SelectedItem = currentUser.nationality;
            sltNationality.Enabled = false;
            sltResidence.Items.Add(currentUser.residenceCountry);
            sltResidence.SelectedItem = currentUser.residenceCountry;
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
            //chequear bien los null.
            User newUser = new User(){
                firstName = txtName.Text,
                dni = txtDni.Text,
                surName = txtSurname.Text,
                codArea=sltCodArea.SelectedItem!=null? sltCodArea.SelectedItem.ToString() : "",
                telephone = txtTelNumber.Text,
                enterprise = txtEnterprise.Text,
                email =txtMail.Text.Contains('@')? new MailAddress(txtMail.Text): new MailAddress("vacio@vacio.com"),
                gender = sltGender.SelectedItem!=null? sltGender.SelectedItem.ToString() : "",
                birthday = sltDate.Value!=null? sltDate.Value :new DateTime(2022, 28, 05),
                nationality = sltNationality.SelectedItem!=null? sltNationality.SelectedItem.ToString() : "",
                residenceCountry = sltResidence.SelectedItem!=null? sltResidence.SelectedItem.ToString() : "",
                age = txtAge.Text.Length>0?Convert.ToInt32(txtAge.Text):0
            };

            DeclarationFields declarationFields = new DeclarationFields() {
                isRiskGroup = optRGroupYes.Checked || optRGroupNo.Checked,
                isVaccinated = optVacYes.Checked || optVacNo.Checked,
                departamentName = sltDepartment.SelectedItem.ToString(),
                visitDate = sltDateTime.Value,
                isTraveler = optTravelerY.Checked || optTravelerN.Checked,
                closeContact = (optYTravelOth.Checked || optNTravelOth.Checked) &&
                               (optYCContact.Checked || optNCContact.Checked)   &&
                               (optCloseContactY.Checked || optCloseContactN.Checked),
                hasSymptom = optSymY.Checked || optSymN.Checked
            };

            DeclaracionJurada declaracionJuradaTmp = new DeclaracionJurada() { 
                        newUser = newUser, 
                        declarationFields = declarationFields,
                        createdAt = DateTime.Now,
            };
            bool resultado = validationFinal.validationDeclaracionFields(declaracionJuradaTmp);

            if (resultado == true) {
                MessageBox.Show("Aceptado " + declaracionJuradaTmp.createdAt.ToShortDateString());
            }
            else { MessageBox.Show("Rechazado " + declaracionJuradaTmp.createdAt.ToShortDateString()); }

        }









        /*{
            if (requiredFieldsTab1())
            {
                if (requiredFieldsTab2())
                {
                    if (requiredFieldsTab3()) {

                        if (declarationResult())
                        {
                            //Ingreso aprobado
                            processDeclarationResult("../../../img/successNotification.png");

                        }
                        else {
                            if (sltDepartment.SelectedItem.ToString() == "Ventas" && optRGroupYes.Checked)
                            {
                                //Ingreso denegado
                                //Si pertenece al grupo de riesgo debe estar vacunado para ingresar al departamento de ventas.
                                processDeclarationResult("../../../img/GroupRiskNotification.png");
                            }
                            else {
                                //Ingreso rechazado
                                processDeclarationResult("../../../img/errorNotification.png");
                            }

                        }
                    }
                    else {
                        imgAlertTab3.Visible = true;
                    }
                }
                else {
                    tbForm.SelectedIndex = 1;
                    imgAlertTab2.Visible = true;
                }

            }
            else {
                tbForm.SelectedIndex = 0;
                imgAlert.Visible = true;
            }

        }*/

        private void CalulateAge(DateTime birthday) {

            int age;
            DateTime currentDate = DateTime.Now;

            if (currentDate.Month <= birthday.Month)
            {
                if (currentDate.Day <= birthday.Day)
                {
                    age = (currentDate.Year - birthday.Year);                    
                }
                else
                {
                    age = (currentDate.Year - birthday.Year) - 1;                    
                }
            }
            else
            {
                age = (currentDate.Year - birthday.Year);                
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

        private bool requiredFieldsTab1() {
            bool result = false;
            if (txtDni.Text.Trim().Length>=1 && txtName.Text.Trim().Length>=1 &&
                txtSurname.Text.Trim().Length>=1 && sltCodArea.SelectedItem!=null &&
                txtCodArea.Text.Trim().Length>=1 && txtTelNumber.Text.Trim().Length>=1 &&
                txtEnterprise.Text.Trim().Length>=1 && txtMail.Text.Trim().Length>=1 &&
                sltGender.SelectedItem!=null && sltNationality.SelectedItem!=null &&
                sltResidence.SelectedItem!=null) {

                result = true;
            }

            return result;
        }

        private bool requiredFieldsTab2() {
            bool result = false;
            if ((optRGroupYes.Checked || optRGroupNo.Checked) && 
                (optVacYes.Checked || optVacNo.Checked) &&
                (optTravelerY.Checked || optTravelerN.Checked) ) {
                result = true;
            }
            return result;
        }

        private bool requiredFieldsTab3() {
            bool result = false;
            if ((optYTravelOth.Checked || optNTravelOth.Checked)&&
                (optYCContact.Checked||optNCContact.Checked)&&
                (optCloseContactY.Checked||optCloseContactN.Checked)&&
                (optSymY.Checked||optSymN.Checked)) {
                result = true;
            }
            return result;
        }

        private bool declarationResult() {
            bool result = true;
            if ( optVacNo.Checked || optSymY.Checked || 
                optYCContact.Checked || optCloseContactY.Checked ) {               
                result = false;
            }
            if ((sltDepartment.SelectedItem.ToString() == "Ventas" && optVacNo.Checked) && optRGroupYes.Checked) {
                result = false;
            }
            return result;
        }

        private void processDeclarationResult(string imgPathString) {
            string imagePath = Path.Combine(Application.StartupPath, imgPathString);
            imgResult.Image = Image.FromFile(imagePath);
            imgResult.Location = new System.Drawing.Point(160, 60);
            materialCard4.Visible = false;
            materialCard5.Visible = false;
            materialCard6.Visible = false;
            cardSy.Visible = false;
            btnConfirm.Visible = false;
            btnBack3.Visible = false;
            TabSelector.Visible = false;
            btnBackToMain.Visible = true;
        }

        private void imgAlert_Click(object sender, EventArgs e)
        {
            imgAlert.Visible = false;
        }

        private void imgAlertTab2_Click(object sender, EventArgs e)
        {
            imgAlertTab2.Visible = false;
        }

        private void imgAlertTab3_Click(object sender, EventArgs e)
        {
            imgAlertTab3.Visible = false;
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmLogin().Show();
        }
    }
}
