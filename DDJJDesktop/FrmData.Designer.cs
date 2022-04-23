namespace DDJJDesktop
{
    partial class FrmData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbForm = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.sltDate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.txtMail = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtTelNumber = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCodArea = new MaterialSkin.Controls.MaterialTextBox2();
            this.sltCodArea = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEnterprise = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtSurname = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtDni = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnNext = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBack2 = new MaterialSkin.Controls.MaterialButton();
            this.btnNext2 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBack3 = new MaterialSkin.Controls.MaterialButton();
            this.btnConfirm = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.txtAge = new MaterialSkin.Controls.MaterialTextBox2();
            this.sltNationality = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.sltResidence = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.tbForm.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbForm
            // 
            this.tbForm.Controls.Add(this.tabPage1);
            this.tbForm.Controls.Add(this.tabPage2);
            this.tbForm.Controls.Add(this.tabPage3);
            this.tbForm.Depth = 0;
            this.tbForm.Location = new System.Drawing.Point(5, 83);
            this.tbForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbForm.Multiline = true;
            this.tbForm.Name = "tbForm";
            this.tbForm.SelectedIndex = 0;
            this.tbForm.Size = new System.Drawing.Size(795, 376);
            this.tbForm.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.sltResidence);
            this.tabPage1.Controls.Add(this.materialLabel6);
            this.tabPage1.Controls.Add(this.sltNationality);
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Controls.Add(this.txtAge);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.sltDate);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialComboBox1);
            this.tabPage1.Controls.Add(this.txtMail);
            this.tabPage1.Controls.Add(this.txtTelNumber);
            this.tabPage1.Controls.Add(this.txtCodArea);
            this.tabPage1.Controls.Add(this.sltCodArea);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.txtEnterprise);
            this.tabPage1.Controls.Add(this.txtSurname);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.txtDni);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage1.Size = new System.Drawing.Size(787, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(49, 227);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(148, 19);
            this.materialLabel4.TabIndex = 15;
            this.materialLabel4.Text = "Fecha de nacimiento";
            // 
            // sltDate
            // 
            this.sltDate.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.sltDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDark;
            this.sltDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sltDate.Location = new System.Drawing.Point(49, 251);
            this.sltDate.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.sltDate.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.sltDate.Name = "sltDate";
            this.sltDate.Size = new System.Drawing.Size(194, 23);
            this.sltDate.TabIndex = 14;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(516, 145);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(51, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Genero";
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 118;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "Genero";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 29;
            this.materialComboBox1.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Prefiero no decirlo",
            "Otro"});
            this.materialComboBox1.Location = new System.Drawing.Point(516, 169);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(194, 35);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 12;
            this.materialComboBox1.UseTallSize = false;
            // 
            // txtMail
            // 
            this.txtMail.AnimateReadOnly = false;
            this.txtMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMail.Depth = 0;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMail.HideSelection = true;
            this.txtMail.Hint = "E-Mail";
            this.txtMail.LeadingIcon = null;
            this.txtMail.Location = new System.Drawing.Point(272, 169);
            this.txtMail.MaxLength = 32767;
            this.txtMail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PrefixSuffixText = null;
            this.txtMail.ReadOnly = false;
            this.txtMail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.ShortcutsEnabled = true;
            this.txtMail.Size = new System.Drawing.Size(194, 36);
            this.txtMail.TabIndex = 11;
            this.txtMail.TabStop = false;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMail.TrailingIcon = null;
            this.txtMail.UseSystemPasswordChar = false;
            this.txtMail.UseTallSize = false;
            // 
            // txtTelNumber
            // 
            this.txtTelNumber.AnimateReadOnly = false;
            this.txtTelNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTelNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelNumber.Depth = 0;
            this.txtTelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelNumber.HideSelection = true;
            this.txtTelNumber.Hint = "Numero";
            this.txtTelNumber.LeadingIcon = null;
            this.txtTelNumber.Location = new System.Drawing.Point(516, 96);
            this.txtTelNumber.MaxLength = 32767;
            this.txtTelNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelNumber.Name = "txtTelNumber";
            this.txtTelNumber.PasswordChar = '\0';
            this.txtTelNumber.PrefixSuffixText = null;
            this.txtTelNumber.ReadOnly = false;
            this.txtTelNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelNumber.SelectedText = "";
            this.txtTelNumber.SelectionLength = 0;
            this.txtTelNumber.SelectionStart = 0;
            this.txtTelNumber.ShortcutsEnabled = true;
            this.txtTelNumber.Size = new System.Drawing.Size(194, 36);
            this.txtTelNumber.TabIndex = 10;
            this.txtTelNumber.TabStop = false;
            this.txtTelNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelNumber.TrailingIcon = null;
            this.txtTelNumber.UseSystemPasswordChar = false;
            this.txtTelNumber.UseTallSize = false;
            // 
            // txtCodArea
            // 
            this.txtCodArea.AnimateReadOnly = false;
            this.txtCodArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCodArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodArea.Depth = 0;
            this.txtCodArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodArea.HideSelection = true;
            this.txtCodArea.Hint = "Código de area";
            this.txtCodArea.LeadingIcon = null;
            this.txtCodArea.Location = new System.Drawing.Point(272, 96);
            this.txtCodArea.MaxLength = 32767;
            this.txtCodArea.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodArea.Name = "txtCodArea";
            this.txtCodArea.PasswordChar = '\0';
            this.txtCodArea.PrefixSuffixText = null;
            this.txtCodArea.ReadOnly = false;
            this.txtCodArea.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodArea.SelectedText = "";
            this.txtCodArea.SelectionLength = 0;
            this.txtCodArea.SelectionStart = 0;
            this.txtCodArea.ShortcutsEnabled = true;
            this.txtCodArea.Size = new System.Drawing.Size(194, 36);
            this.txtCodArea.TabIndex = 9;
            this.txtCodArea.TabStop = false;
            this.txtCodArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodArea.TrailingIcon = null;
            this.txtCodArea.UseSystemPasswordChar = false;
            this.txtCodArea.UseTallSize = false;
            // 
            // sltCodArea
            // 
            this.sltCodArea.AutoResize = false;
            this.sltCodArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sltCodArea.Depth = 0;
            this.sltCodArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sltCodArea.DropDownHeight = 118;
            this.sltCodArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sltCodArea.DropDownWidth = 121;
            this.sltCodArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.sltCodArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sltCodArea.FormattingEnabled = true;
            this.sltCodArea.IntegralHeight = false;
            this.sltCodArea.ItemHeight = 29;
            this.sltCodArea.Items.AddRange(new object[] {
            "Argentina: +54",
            "Brasil: +55"});
            this.sltCodArea.Location = new System.Drawing.Point(49, 97);
            this.sltCodArea.MaxDropDownItems = 4;
            this.sltCodArea.MouseState = MaterialSkin.MouseState.OUT;
            this.sltCodArea.Name = "sltCodArea";
            this.sltCodArea.Size = new System.Drawing.Size(194, 35);
            this.sltCodArea.StartIndex = 0;
            this.sltCodArea.TabIndex = 8;
            this.sltCodArea.UseTallSize = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(49, 73);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(85, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Código pais";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // txtEnterprise
            // 
            this.txtEnterprise.AnimateReadOnly = false;
            this.txtEnterprise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEnterprise.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEnterprise.Depth = 0;
            this.txtEnterprise.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEnterprise.HideSelection = true;
            this.txtEnterprise.Hint = "Empresa";
            this.txtEnterprise.LeadingIcon = null;
            this.txtEnterprise.Location = new System.Drawing.Point(49, 169);
            this.txtEnterprise.MaxLength = 32767;
            this.txtEnterprise.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEnterprise.Name = "txtEnterprise";
            this.txtEnterprise.PasswordChar = '\0';
            this.txtEnterprise.PrefixSuffixText = null;
            this.txtEnterprise.ReadOnly = false;
            this.txtEnterprise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEnterprise.SelectedText = "";
            this.txtEnterprise.SelectionLength = 0;
            this.txtEnterprise.SelectionStart = 0;
            this.txtEnterprise.ShortcutsEnabled = true;
            this.txtEnterprise.Size = new System.Drawing.Size(194, 36);
            this.txtEnterprise.TabIndex = 5;
            this.txtEnterprise.TabStop = false;
            this.txtEnterprise.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEnterprise.TrailingIcon = null;
            this.txtEnterprise.UseSystemPasswordChar = false;
            this.txtEnterprise.UseTallSize = false;
            this.txtEnterprise.Click += new System.EventHandler(this.txtEnterprise_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.AnimateReadOnly = false;
            this.txtSurname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSurname.Depth = 0;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSurname.HideSelection = true;
            this.txtSurname.Hint = "Apellido";
            this.txtSurname.LeadingIcon = null;
            this.txtSurname.Location = new System.Drawing.Point(516, 24);
            this.txtSurname.MaxLength = 32767;
            this.txtSurname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.PasswordChar = '\0';
            this.txtSurname.PrefixSuffixText = null;
            this.txtSurname.ReadOnly = false;
            this.txtSurname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSurname.SelectedText = "";
            this.txtSurname.SelectionLength = 0;
            this.txtSurname.SelectionStart = 0;
            this.txtSurname.ShortcutsEnabled = true;
            this.txtSurname.Size = new System.Drawing.Size(194, 36);
            this.txtSurname.TabIndex = 4;
            this.txtSurname.TabStop = false;
            this.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSurname.TrailingIcon = null;
            this.txtSurname.UseSystemPasswordChar = false;
            this.txtSurname.UseTallSize = false;
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.HideSelection = true;
            this.txtName.Hint = "Nombre";
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(272, 24);
            this.txtName.MaxLength = 32767;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PrefixSuffixText = null;
            this.txtName.ReadOnly = false;
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(194, 36);
            this.txtName.TabIndex = 3;
            this.txtName.TabStop = false;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TrailingIcon = null;
            this.txtName.UseSystemPasswordChar = false;
            this.txtName.UseTallSize = false;
            // 
            // txtDni
            // 
            this.txtDni.AnimateReadOnly = false;
            this.txtDni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDni.Depth = 0;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDni.HideSelection = true;
            this.txtDni.Hint = "Ingrese DNI";
            this.txtDni.LeadingIcon = null;
            this.txtDni.Location = new System.Drawing.Point(49, 24);
            this.txtDni.MaxLength = 32767;
            this.txtDni.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDni.Name = "txtDni";
            this.txtDni.PasswordChar = '\0';
            this.txtDni.PrefixSuffixText = null;
            this.txtDni.ReadOnly = false;
            this.txtDni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDni.SelectedText = "";
            this.txtDni.SelectionLength = 0;
            this.txtDni.SelectionStart = 0;
            this.txtDni.ShortcutsEnabled = true;
            this.txtDni.Size = new System.Drawing.Size(194, 36);
            this.txtDni.TabIndex = 2;
            this.txtDni.TabStop = false;
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDni.TrailingIcon = null;
            this.txtDni.UseSystemPasswordChar = false;
            this.txtDni.UseTallSize = false;
            // 
            // btnNext
            // 
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNext.Depth = 0;
            this.btnNext.HighEmphasis = true;
            this.btnNext.Icon = null;
            this.btnNext.Location = new System.Drawing.Point(678, 303);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext.Name = "btnNext";
            this.btnNext.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNext.Size = new System.Drawing.Size(95, 36);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Siguiente";
            this.btnNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNext.UseAccentColor = false;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBack2);
            this.tabPage2.Controls.Add(this.btnNext2);
            this.tabPage2.Controls.Add(this.materialTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage2.Size = new System.Drawing.Size(787, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBack2
            // 
            this.btnBack2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBack2.Depth = 0;
            this.btnBack2.HighEmphasis = true;
            this.btnBack2.Icon = null;
            this.btnBack2.Location = new System.Drawing.Point(7, 303);
            this.btnBack2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBack2.Size = new System.Drawing.Size(67, 36);
            this.btnBack2.TabIndex = 2;
            this.btnBack2.Text = "Atrás";
            this.btnBack2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnBack2.UseAccentColor = true;
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // btnNext2
            // 
            this.btnNext2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNext2.Depth = 0;
            this.btnNext2.HighEmphasis = true;
            this.btnNext2.Icon = null;
            this.btnNext2.Location = new System.Drawing.Point(678, 303);
            this.btnNext2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNext2.Size = new System.Drawing.Size(95, 36);
            this.btnNext2.TabIndex = 1;
            this.btnNext2.Text = "Siguiente";
            this.btnNext2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNext2.UseAccentColor = false;
            this.btnNext2.UseVisualStyleBackColor = true;
            this.btnNext2.Click += new System.EventHandler(this.btnNext2_Click);
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(51, 48);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(182, 36);
            this.materialTextBox1.TabIndex = 0;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            this.materialTextBox1.UseTallSize = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnBack3);
            this.tabPage3.Controls.Add(this.btnConfirm);
            this.tabPage3.Controls.Add(this.materialLabel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(787, 348);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBack3
            // 
            this.btnBack3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBack3.Depth = 0;
            this.btnBack3.HighEmphasis = true;
            this.btnBack3.Icon = null;
            this.btnBack3.Location = new System.Drawing.Point(7, 303);
            this.btnBack3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack3.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBack3.Size = new System.Drawing.Size(67, 36);
            this.btnBack3.TabIndex = 2;
            this.btnBack3.Text = "Atrás";
            this.btnBack3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnBack3.UseAccentColor = true;
            this.btnBack3.UseVisualStyleBackColor = true;
            this.btnBack3.Click += new System.EventHandler(this.btnBack3_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConfirm.Depth = 0;
            this.btnConfirm.HighEmphasis = true;
            this.btnConfirm.Icon = null;
            this.btnConfirm.Location = new System.Drawing.Point(678, 303);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConfirm.Size = new System.Drawing.Size(105, 36);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConfirm.UseAccentColor = false;
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(62, 31);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(70, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Probando";
            // 
            // TabSelector
            // 
            this.TabSelector.BaseTabControl = this.tbForm;
            this.TabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.TabSelector.Depth = 0;
            this.TabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TabSelector.Location = new System.Drawing.Point(294, 62);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Size = new System.Drawing.Size(507, 24);
            this.TabSelector.TabIndex = 2;
            this.TabSelector.TabIndicatorHeight = 4;
            this.TabSelector.Text = "none";
            // 
            // txtAge
            // 
            this.txtAge.AnimateReadOnly = false;
            this.txtAge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAge.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAge.Depth = 0;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAge.HideSelection = true;
            this.txtAge.Hint = "Edad";
            this.txtAge.LeadingIcon = null;
            this.txtAge.Location = new System.Drawing.Point(272, 238);
            this.txtAge.MaxLength = 32767;
            this.txtAge.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = '\0';
            this.txtAge.PrefixSuffixText = null;
            this.txtAge.ReadOnly = true;
            this.txtAge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAge.SelectedText = "";
            this.txtAge.SelectionLength = 0;
            this.txtAge.SelectionStart = 0;
            this.txtAge.ShortcutsEnabled = true;
            this.txtAge.Size = new System.Drawing.Size(194, 36);
            this.txtAge.TabIndex = 16;
            this.txtAge.TabStop = false;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAge.TrailingIcon = null;
            this.txtAge.UseSystemPasswordChar = false;
            this.txtAge.UseTallSize = false;
            // 
            // sltNationality
            // 
            this.sltNationality.AutoResize = false;
            this.sltNationality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sltNationality.Depth = 0;
            this.sltNationality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sltNationality.DropDownHeight = 118;
            this.sltNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sltNationality.DropDownWidth = 121;
            this.sltNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.sltNationality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sltNationality.FormattingEnabled = true;
            this.sltNationality.IntegralHeight = false;
            this.sltNationality.ItemHeight = 29;
            this.sltNationality.Items.AddRange(new object[] {
            "Argentina",
            "Brasil"});
            this.sltNationality.Location = new System.Drawing.Point(516, 241);
            this.sltNationality.MaxDropDownItems = 4;
            this.sltNationality.MouseState = MaterialSkin.MouseState.OUT;
            this.sltNationality.Name = "sltNationality";
            this.sltNationality.Size = new System.Drawing.Size(194, 35);
            this.sltNationality.StartIndex = 0;
            this.sltNationality.TabIndex = 18;
            this.sltNationality.UseTallSize = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(516, 217);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(95, 19);
            this.materialLabel5.TabIndex = 17;
            this.materialLabel5.Text = "Nacionalidad";
            // 
            // sltResidence
            // 
            this.sltResidence.AutoResize = false;
            this.sltResidence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sltResidence.Depth = 0;
            this.sltResidence.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sltResidence.DropDownHeight = 118;
            this.sltResidence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sltResidence.DropDownWidth = 121;
            this.sltResidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.sltResidence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sltResidence.FormattingEnabled = true;
            this.sltResidence.IntegralHeight = false;
            this.sltResidence.ItemHeight = 29;
            this.sltResidence.Items.AddRange(new object[] {
            "Argentina",
            "Brasil"});
            this.sltResidence.Location = new System.Drawing.Point(49, 301);
            this.sltResidence.MaxDropDownItems = 4;
            this.sltResidence.MouseState = MaterialSkin.MouseState.OUT;
            this.sltResidence.Name = "sltResidence";
            this.sltResidence.Size = new System.Drawing.Size(194, 35);
            this.sltResidence.StartIndex = 0;
            this.sltResidence.TabIndex = 20;
            this.sltResidence.UseTallSize = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(49, 277);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(129, 19);
            this.materialLabel6.TabIndex = 19;
            this.materialLabel6.Text = "Pais de residencia";
            // 
            // FrmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabSelector);
            this.Controls.Add(this.tbForm);
            this.Name = "FrmData";
            this.Text = "Declaración jurada personal";
            this.Load += new System.EventHandler(this.FrmData_Load);
            this.tbForm.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector tbSelector;
        private MaterialSkin.Controls.MaterialTabControl tbForm;
        private MaterialSkin.Controls.MaterialButton btnNext;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialTextBox2 txtSurname;
        private MaterialSkin.Controls.MaterialTextBox2 txtName;
        private MaterialSkin.Controls.MaterialTextBox2 txtDni;
        private TabPage tabPage3;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialButton btnBack2;
        private MaterialSkin.Controls.MaterialButton btnNext2;
        private MaterialSkin.Controls.MaterialButton btnBack3;
        private MaterialSkin.Controls.MaterialButton btnConfirm;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtEnterprise;
        private MaterialSkin.Controls.MaterialComboBox sltCodArea;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelNumber;
        private MaterialSkin.Controls.MaterialTextBox2 txtCodArea;
        private DateTimePicker sltDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialTextBox2 txtMail;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox sltResidence;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialComboBox sltNationality;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 txtAge;
    }
}