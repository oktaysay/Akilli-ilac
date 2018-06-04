namespace Medicine.AdminForms
{
    partial class DiseasesEdit
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
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.txtDiseaseName = new MetroFramework.Controls.MetroTextBox();
            this.lblDiseaseName = new MetroFramework.Controls.MetroLabel();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(23, 120);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(254, 37);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "D Ü Z E N L E";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtDiseaseName
            // 
            this.txtDiseaseName.Lines = new string[0];
            this.txtDiseaseName.Location = new System.Drawing.Point(149, 85);
            this.txtDiseaseName.MaxLength = 32767;
            this.txtDiseaseName.Name = "txtDiseaseName";
            this.txtDiseaseName.PasswordChar = '\0';
            this.txtDiseaseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiseaseName.SelectedText = "";
            this.txtDiseaseName.Size = new System.Drawing.Size(128, 23);
            this.txtDiseaseName.TabIndex = 4;
            this.txtDiseaseName.UseSelectable = true;
            // 
            // lblDiseaseName
            // 
            this.lblDiseaseName.AutoSize = true;
            this.lblDiseaseName.Location = new System.Drawing.Point(23, 85);
            this.lblDiseaseName.Name = "lblDiseaseName";
            this.lblDiseaseName.Size = new System.Drawing.Size(77, 19);
            this.lblDiseaseName.TabIndex = 3;
            this.lblDiseaseName.Text = "Hastalık Adı";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(207, 60);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Visible = false;
            // 
            // DiseasesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 180);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtDiseaseName);
            this.Controls.Add(this.lblDiseaseName);
            this.Name = "DiseasesEdit";
            this.Text = "Hastalık Düzenle";
            this.Load += new System.EventHandler(this.DiseasesEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroTextBox txtDiseaseName;
        private MetroFramework.Controls.MetroLabel lblDiseaseName;
        public System.Windows.Forms.Label lblId;
    }
}