namespace Medicine.AdminForms
{
    partial class MedicineOfDiseasesCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineOfDiseasesCreate));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmbbxMedicines = new MetroFramework.Controls.MetroComboBox();
            this.cmbbxDiseases = new MetroFramework.Controls.MetroComboBox();
            this.txtMinAge = new MetroFramework.Controls.MetroTextBox();
            this.txtMaxAge = new MetroFramework.Controls.MetroTextBox();
            this.btnCreate = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(28, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "İlaç";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 131);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Hastalık";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 178);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(87, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Minimum Yaş";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 219);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(95, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Maksimum Yaş";
            // 
            // cmbbxMedicines
            // 
            this.cmbbxMedicines.FormattingEnabled = true;
            this.cmbbxMedicines.ItemHeight = 23;
            this.cmbbxMedicines.Location = new System.Drawing.Point(132, 86);
            this.cmbbxMedicines.Name = "cmbbxMedicines";
            this.cmbbxMedicines.Size = new System.Drawing.Size(145, 29);
            this.cmbbxMedicines.TabIndex = 4;
            this.cmbbxMedicines.UseSelectable = true;
            this.cmbbxMedicines.SelectedIndexChanged += new System.EventHandler(this.cmbbxMedicines_SelectedIndexChanged);
            // 
            // cmbbxDiseases
            // 
            this.cmbbxDiseases.FormattingEnabled = true;
            this.cmbbxDiseases.ItemHeight = 23;
            this.cmbbxDiseases.Location = new System.Drawing.Point(132, 131);
            this.cmbbxDiseases.Name = "cmbbxDiseases";
            this.cmbbxDiseases.Size = new System.Drawing.Size(145, 29);
            this.cmbbxDiseases.TabIndex = 5;
            this.cmbbxDiseases.UseSelectable = true;
            // 
            // txtMinAge
            // 
            this.txtMinAge.Lines = new string[0];
            this.txtMinAge.Location = new System.Drawing.Point(132, 178);
            this.txtMinAge.MaxLength = 32767;
            this.txtMinAge.Name = "txtMinAge";
            this.txtMinAge.PasswordChar = '\0';
            this.txtMinAge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMinAge.SelectedText = "";
            this.txtMinAge.Size = new System.Drawing.Size(145, 23);
            this.txtMinAge.TabIndex = 6;
            this.txtMinAge.UseSelectable = true;
            // 
            // txtMaxAge
            // 
            this.txtMaxAge.Lines = new string[0];
            this.txtMaxAge.Location = new System.Drawing.Point(132, 219);
            this.txtMaxAge.MaxLength = 32767;
            this.txtMaxAge.Name = "txtMaxAge";
            this.txtMaxAge.PasswordChar = '\0';
            this.txtMaxAge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaxAge.SelectedText = "";
            this.txtMaxAge.Size = new System.Drawing.Size(145, 23);
            this.txtMaxAge.TabIndex = 7;
            this.txtMaxAge.UseSelectable = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(99, 268);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(178, 46);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "K A Y D E T";
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(23, 268);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 46);
            this.btnBack.TabIndex = 9;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MedicineOfDiseasesCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 352);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtMaxAge);
            this.Controls.Add(this.txtMinAge);
            this.Controls.Add(this.cmbbxDiseases);
            this.Controls.Add(this.cmbbxMedicines);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "MedicineOfDiseasesCreate";
            this.Text = "Hastalık - İlaç Bağlama";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MedicineOfDiseasesCreate_FormClosed);
            this.Load += new System.EventHandler(this.MedicineOfDiseases_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmbbxMedicines;
        private MetroFramework.Controls.MetroComboBox cmbbxDiseases;
        private MetroFramework.Controls.MetroTextBox txtMinAge;
        private MetroFramework.Controls.MetroTextBox txtMaxAge;
        private MetroFramework.Controls.MetroButton btnCreate;
        private MetroFramework.Controls.MetroButton btnBack;
    }
}