namespace Medicine
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.usernameTxt = new MetroFramework.Controls.MetroTextBox();
            this.passwordTxt = new MetroFramework.Controls.MetroTextBox();
            this.girisBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 110);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Kullanıcı Adı :";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(72, 142);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Şifre:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Lines = new string[0];
            this.usernameTxt.Location = new System.Drawing.Point(116, 113);
            this.usernameTxt.MaxLength = 32767;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.PasswordChar = '\0';
            this.usernameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameTxt.SelectedText = "";
            this.usernameTxt.Size = new System.Drawing.Size(183, 23);
            this.usernameTxt.TabIndex = 0;
            this.usernameTxt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.usernameTxt.UseSelectable = true;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Lines = new string[0];
            this.passwordTxt.Location = new System.Drawing.Point(116, 142);
            this.passwordTxt.MaxLength = 32767;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '\0';
            this.passwordTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTxt.SelectedText = "";
            this.passwordTxt.Size = new System.Drawing.Size(183, 23);
            this.passwordTxt.TabIndex = 1;
            this.passwordTxt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.passwordTxt.UseSelectable = true;
            // 
            // girisBtn
            // 
            this.girisBtn.Location = new System.Drawing.Point(24, 193);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(275, 35);
            this.girisBtn.TabIndex = 2;
            this.girisBtn.Text = "Giriş Yap";
            this.girisBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.girisBtn.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(23, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(276, 50);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Sisteme erişim sağlamak için, lütfen kullanıcı \r\nadınızı ve şifrenizi giriniz";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroStyleExtender1
            // 
            this.metroStyleExtender1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 271);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Hoşgeldiniz";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox usernameTxt;
        private MetroFramework.Controls.MetroTextBox passwordTxt;
        private MetroFramework.Controls.MetroButton girisBtn;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}

