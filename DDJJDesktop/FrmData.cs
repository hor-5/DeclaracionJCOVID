using EntitiesModel;
using Services;
using MaterialSkin.Controls;
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

        public ValidationServices validationFinal = new ValidationServices();
        private SecurityServices securityServices = new SecurityServices();
        private User currentUser;
        public FrmData()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);

            fillResidenceCountries();
            fillNationality();
            fillGenders();
            fillDepartaments();
        }

        public FrmData(User currentUser)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);

            this.currentUser = currentUser;
            fillResidenceCountries();
            fillNationality();
            fillGenders();
            fillDepartaments();
            fillTextBox(securityServices.getUserData(currentUser.idUser));
        }

        private void FrmData_Load(object sender, EventArgs e)
        {

        }

        private void fillTextBox(Person currentUser)
        {

            txtDni.Text = currentUser.dni;
            txtDni.Enabled = false;
            txtName.Text = currentUser.firstName;
            txtName.Enabled = false;
            txtSurname.Text = currentUser.surName;
            txtSurname.Enabled = false;            
            sltCodArea.SelectedValue = currentUser.fk_residenceCountry;
            sltCodArea.Enabled = false;
            txtCodArea.Text = currentUser.codArea;
            txtCodArea.Enabled = false;
            txtTelNumber.Text = currentUser.telephone;
            txtTelNumber.Enabled = false;
            txtEnterprise.Text = currentUser.enterprise;
            txtEnterprise.Enabled = false;
            txtMail.Text = currentUser.email;
            txtMail.Enabled = false;
            sltGender.SelectedValue = currentUser.fk_idGender;
            sltGender.Enabled = false;
            sltDate.Value = currentUser.birthday;
            sltDate.Enabled = false;
            CalulateAge(currentUser.birthday);
            txtAge.Enabled = false;           
            sltNationality.SelectedValue = currentUser.fk_nationalityCountry;
            sltNationality.Enabled = false;            
            sltResidence.SelectedValue= currentUser.fk_residenceCountry;
            sltResidence.Enabled = false;

        }

        public void fillGenders()
        {
            List<Gender> lstGenders = securityServices.getGenero();

            sltGender.DisplayMember = "nameGender";
            sltGender.ValueMember = "idGender";
            sltGender.DataSource = lstGenders;

        }

        public void fillDepartaments()
        {
            List<Departament> lstDepartaments = securityServices.getDepartaments();

            sltDepartment.DisplayMember = "nameDepartament";
            sltDepartment.ValueMember = "idDepartament";            
            sltDepartment.DataSource = lstDepartaments;
            

        }
        public void fillRiskGroups()
        {
            List<RiskGroup> lstRiskGroups = securityServices.getRiskGroups();
            int cont = 0;
            foreach (RiskGroup riskGroup in lstRiskGroups) {
                try
                {
                    if (cont == 0)
                    {
                        lblGroupR.Text += "-" + riskGroup.nameRiskGroup + (lstRiskGroups.Count >= 2 ? "                            -" + lstRiskGroups[cont + 1].nameRiskGroup : "");
                    }
                    else if (cont == 2)
                    {
                        lblGroupR1.Text += "-" + riskGroup.nameRiskGroup + (lstRiskGroups.Count >= 4 ? "        -" + lstRiskGroups[cont + 1].nameRiskGroup : ""); ;
                    }
                    else if (cont == 4)
                    {
                        lblGroupR2.Text += "-" + riskGroup.nameRiskGroup + (lstRiskGroups.Count >= 6 ? "        -" + lstRiskGroups[cont + 1].nameRiskGroup : "");
                    }
                    else if (cont == 6)
                    {
                        lblGroupR3.Text += "-" + riskGroup.nameRiskGroup + (lstRiskGroups.Count >= 8 ? "       -" + lstRiskGroups[cont + 1].nameRiskGroup : ""); ;
                    }
                    //solamente puede mostrar hasta 8 grupos de riesgo.
                    cont++;
                }
                catch (Exception err) {
                    lblGroupR.Text = err.Message;
                }
            }


        }
        public void fillSymptoms() 
        {
            List<CovidSymptom> lstSintomas = securityServices.getSintomas();
            int cont = 0;
            foreach (CovidSymptom sintoma in lstSintomas)
            {
                try
                {
                    if (cont == 0)
                    {
                        lblSintoma.Text += "-" + sintoma.nameSymptom + (lstSintomas.Count >= 2 ? "         -" + lstSintomas[cont + 1].nameSymptom : "");
                    }
                    else if (cont == 2)
                    {
                        lblSintoma1.Text += "-" + sintoma.nameSymptom + (lstSintomas.Count >= 4 ? "                           -" + lstSintomas[cont + 1].nameSymptom : ""); ;
                    }
                    else if (cont == 4)
                    {
                        lblSintoma2.Text += "-" + sintoma.nameSymptom + (lstSintomas.Count >= 6 ? "      -" + lstSintomas[cont + 1].nameSymptom : "");
                    }
                    else if (cont == 6)
                    {
                        lblSintoma3.Text += "-" + sintoma.nameSymptom + (lstSintomas.Count >= 8 ? "       -" + lstSintomas[cont + 1].nameSymptom : ""); ;
                    }
                    else if (cont == 8)
                    {
                        lblSintoma4.Text += "-" + sintoma.nameSymptom + (lstSintomas.Count >= 10 ? "       -" + lstSintomas[cont + 1].nameSymptom : ""); ;
                    }
                    else if (cont == 10)
                    {
                        lblSintoma5.Text += "-" + sintoma.nameSymptom + (lstSintomas.Count >= 12 ? "       -" + lstSintomas[cont + 1].nameSymptom : ""); ;
                    }
                    //solamente puede mostrar hasta 12 sintomas.
                    cont++;
                }
                catch (Exception err)
                {
                    lblGroupR.Text = err.Message;
                }
            }
        }

        public void fillResidenceCountries() {
            List<Country> lstCountries = securityServices.getCountries();

            sltCodArea.DisplayMember = "codCountry";
            sltCodArea.ValueMember = "codCountry";
            sltCodArea.DataSource = lstCountries;

            sltResidence.DisplayMember = "nameCountry";
            sltResidence.ValueMember = "idCountry";
            sltResidence.DataSource = lstCountries;
        }

        public void fillNationality() {
            List<Country> lstCountriesNat = securityServices.getCountries();
            sltNationality.DisplayMember = "nameCountry";
            sltNationality.ValueMember = "idCountry";
            sltNationality.DataSource = lstCountriesNat;
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

        bool filledRiskG = false;
        private void btnRiskGroup_Click(object sender, EventArgs e)
        {
            cardVaccine.Visible = false;
            cardModalGR.Visible = true;
            if (!filledRiskG) {
               fillRiskGroups();
               filledRiskG = true;
            }
            
        }

        bool filledSymptoms = false;
        private void btnSy_Click(object sender, EventArgs e)
        {
            cardSy.Visible = false;
            ModalSy.Visible = true;
            if (!filledSymptoms)
            {
                fillSymptoms();
                filledSymptoms = true;
            }
        }

        private void btnCloseSy_Click(object sender, EventArgs e)
        {
            ModalSy.Visible = false;
            cardSy.Visible = true;
        }
        private void executeValidationService() {
            try
            {

                Person newPerson = new Person()
                {                    
                    dni = txtDni.Text,
                    firstName = txtName.Text,
                    surName = txtSurname.Text,
                    codArea = txtCodArea.Text,
                    telephone = txtTelNumber.Text,
                    enterprise = txtEnterprise.Text,
                    email = txtMail.Text,                    
                    fk_idGender = int.Parse(sltGender.SelectedValue.ToString()),
                    birthday = sltDate.Value != null ? sltDate.Value : new DateTime(2022, 28, 05),
                    fk_nationalityCountry = int.Parse(sltNationality.SelectedValue.ToString()),
                    fk_residenceCountry = int.Parse(sltResidence.SelectedValue.ToString())
                };

                DeclarationFields declarationFields = new DeclarationFields()
                {
                    isRiskGroup = optRGroupYes.Checked,
                    isVaccinated = optVacYes.Checked,
                    fk_idDepartament = int.Parse(sltDepartment.SelectedValue.ToString()),
                    visitDate = sltDateTime.Value,
                    isTraveler = optTravelerY.Checked,
                    closeContact = (optYTravelOth.Checked) &&
                                   (optYCContact.Checked) &&
                                   (optCloseContactY.Checked),
                    hasSymptom = optSymY.Checked
                };

                if (currentUser != null)
                {
                    int idDeclarationFields = securityServices.insertDeclarationFields(declarationFields);
                    Person userData = securityServices.getUserData(currentUser.idUser);
                    int idPerson = userData.idPerson;
                    int insertResult = securityServices.insertDeclaration(idPerson,idDeclarationFields);
                    
                    //MaterialMessageBox.Show("Está logueado con el usuario:  " + currentUser.username);
                }
                else
                {
                    //MaterialMessageBox.Show("No hay usuario");
                    int idPerson= securityServices.insertPerson(newPerson);
                    int idDeclarationFields = securityServices.insertDeclarationFields(declarationFields);
                    int insertResult = securityServices.insertDeclaration(idPerson, idDeclarationFields);

                }

                Declarations declaracionJuradaTmp = new Declarations(newPerson, declarationFields);
                    
                
                    string resultado = validationFinal.validationDeclaracionFields(declaracionJuradaTmp);

                    if (resultado == string.Empty)
                    {
                        MaterialMessageBox.Show("Envio exitoso " + declaracionJuradaTmp.created_at.ToShortDateString());
                        
                        //guarda la declaración jurada en la entidad de datos.
                        //securityServices.createDeclaration(declaracionJuradaTmp);                        
                    }
                    else { MaterialMessageBox.Show("Ocurrió un error : "+ resultado +" "+ declaracionJuradaTmp.created_at.ToShortDateString()); }
            }
            catch (Exception error)
            {
                MaterialMessageBox.Show("Algo salió mal : " + error);
                
               
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (requiredFieldsTab1())
            {
                if (requiredFieldsTab2())
                {
                    if (requiredFieldsTab3()) {

                        //validaciones backend
                        executeValidationService();

                        //resultado
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

        }

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

        private void cardModalGR_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
