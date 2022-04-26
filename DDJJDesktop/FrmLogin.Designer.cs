namespace DDJJDesktop
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.btnVolver = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.txtPass = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUser = new MaterialSkin.Controls.MaterialTextBox();
            this.txtIngresar = new MaterialSkin.Controls.MaterialButton();
            this.grpWelcome = new System.Windows.Forms.GroupBox();
            this.lblWelcome = new MaterialSkin.Controls.MaterialLabel();
            this.btnNoUser = new MaterialSkin.Controls.MaterialButton();
            this.btnWUser = new MaterialSkin.Controls.MaterialButton();
            this.imgNotification = new System.Windows.Forms.PictureBox();
            this.grpLogin.SuspendLayout();
            this.grpWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNotification)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpLogin.Controls.Add(this.btnVolver);
            this.grpLogin.Controls.Add(this.txtPass);
            this.grpLogin.Controls.Add(this.txtUser);
            this.grpLogin.Controls.Add(this.txtIngresar);
            this.grpLogin.Location = new System.Drawing.Point(233, 127);
            this.grpLogin.Margin = new System.Windows.Forms.Padding(4);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Padding = new System.Windows.Forms.Padding(4);
            this.grpLogin.Size = new System.Drawing.Size(300, 234);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.AnimateShowHideButton = true;
            this.btnVolver.Depth = 0;
            this.btnVolver.Icon = ((System.Drawing.Image)(resources.GetObject("btnVolver.Icon")));
            this.btnVolver.Location = new System.Drawing.Point(6, 22);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Mini = true;
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(40, 41);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.UseWaitCursor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtPass
            // 
            this.txtPass.AnimateReadOnly = false;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Depth = 0;
            this.txtPass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPass.Hint = "Contraseña";
            this.txtPass.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtPass.LeadingIcon")));
            this.txtPass.Location = new System.Drawing.Point(62, 129);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.MaxLength = 50;
            this.txtPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.Password = true;
            this.txtPass.Size = new System.Drawing.Size(180, 36);
            this.txtPass.TabIndex = 6;
            this.txtPass.Text = "";
            this.txtPass.TrailingIcon = null;
            this.txtPass.UseTallSize = false;
            this.txtPass.UseWaitCursor = true;
            // 
            // txtUser
            // 
            this.txtUser.AnimateReadOnly = false;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Depth = 0;
            this.txtUser.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUser.Hint = "Usuario";
            this.txtUser.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtUser.LeadingIcon")));
            this.txtUser.Location = new System.Drawing.Point(62, 72);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.MaxLength = 50;
            this.txtUser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUser.Multiline = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtUser.Size = new System.Drawing.Size(180, 36);
            this.txtUser.TabIndex = 5;
            this.txtUser.Text = "";
            this.txtUser.TrailingIcon = null;
            this.txtUser.UseTallSize = false;
            this.txtUser.UseWaitCursor = true;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            // 
            // txtIngresar
            // 
            this.txtIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtIngresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.txtIngresar.Depth = 0;
            this.txtIngresar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtIngresar.HighEmphasis = true;
            this.txtIngresar.Icon = null;
            this.txtIngresar.Location = new System.Drawing.Point(4, 194);
            this.txtIngresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIngresar.Name = "txtIngresar";
            this.txtIngresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.txtIngresar.Size = new System.Drawing.Size(292, 36);
            this.txtIngresar.TabIndex = 4;
            this.txtIngresar.Text = "Ingresar";
            this.txtIngresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.txtIngresar.UseAccentColor = false;
            this.txtIngresar.UseVisualStyleBackColor = true;
            this.txtIngresar.Click += new System.EventHandler(this.txtIngresar_Click);
            // 
            // grpWelcome
            // 
            this.grpWelcome.BackColor = System.Drawing.SystemColors.Menu;
            this.grpWelcome.Controls.Add(this.lblWelcome);
            this.grpWelcome.Controls.Add(this.btnNoUser);
            this.grpWelcome.Controls.Add(this.btnWUser);
            this.grpWelcome.Location = new System.Drawing.Point(148, 82);
            this.grpWelcome.Margin = new System.Windows.Forms.Padding(4);
            this.grpWelcome.Name = "grpWelcome";
            this.grpWelcome.Padding = new System.Windows.Forms.Padding(4);
            this.grpWelcome.Size = new System.Drawing.Size(476, 295);
            this.grpWelcome.TabIndex = 3;
            this.grpWelcome.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Depth = 0;
            this.lblWelcome.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblWelcome.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblWelcome.Location = new System.Drawing.Point(150, 20);
            this.lblWelcome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(175, 41);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Bienvenido!";
            // 
            // btnNoUser
            // 
            this.btnNoUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNoUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNoUser.Depth = 0;
            this.btnNoUser.HighEmphasis = true;
            this.btnNoUser.Icon = null;
            this.btnNoUser.Location = new System.Drawing.Point(141, 187);
            this.btnNoUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNoUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNoUser.Name = "btnNoUser";
            this.btnNoUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNoUser.Size = new System.Drawing.Size(184, 36);
            this.btnNoUser.TabIndex = 4;
            this.btnNoUser.Text = "Ingresar sin usuario";
            this.btnNoUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnNoUser.UseAccentColor = false;
            this.btnNoUser.UseVisualStyleBackColor = true;
            this.btnNoUser.Click += new System.EventHandler(this.btnNoUser_Click);
            // 
            // btnWUser
            // 
            this.btnWUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnWUser.Depth = 0;
            this.btnWUser.HighEmphasis = true;
            this.btnWUser.Icon = null;
            this.btnWUser.Location = new System.Drawing.Point(141, 124);
            this.btnWUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWUser.Name = "btnWUser";
            this.btnWUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnWUser.Size = new System.Drawing.Size(190, 36);
            this.btnWUser.TabIndex = 3;
            this.btnWUser.Text = "Ingresar con usuario";
            this.btnWUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnWUser.UseAccentColor = false;
            this.btnWUser.UseVisualStyleBackColor = true;
            this.btnWUser.Click += new System.EventHandler(this.btnWUser_Click);
            // 
            // imgNotification
            // 
            this.imgNotification.Image = ((System.Drawing.Image)(resources.GetObject("imgNotification.Image")));
            this.imgNotification.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgNotification.InitialImage")));
            this.imgNotification.Location = new System.Drawing.Point(260, 384);
            this.imgNotification.Name = "imgNotification";
            this.imgNotification.Size = new System.Drawing.Size(236, 59);
            this.imgNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNotification.TabIndex = 4;
            this.imgNotification.TabStop = false;
            this.imgNotification.Visible = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgNotification);
            this.Controls.Add(this.grpWelcome);
            this.Controls.Add(this.grpLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Padding = new System.Windows.Forms.Padding(4, 64, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido a la declaración jurada COVID-19";
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.grpWelcome.ResumeLayout(false);
            this.grpWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNotification)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpLogin;
        private GroupBox grpWelcome;
        private MaterialSkin.Controls.MaterialButton btnWUser;
        private MaterialSkin.Controls.MaterialButton btnNoUser;
        private MaterialSkin.Controls.MaterialButton txtIngresar;
        private MaterialSkin.Controls.MaterialTextBox txtPass;
        private MaterialSkin.Controls.MaterialTextBox txtUser;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnVolver;
        private MaterialSkin.Controls.MaterialLabel lblWelcome;
        private PictureBox imgNotification;
    }
}