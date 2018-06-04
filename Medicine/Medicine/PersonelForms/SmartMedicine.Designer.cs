namespace Medicine.PersonelForms
{
    partial class SmartMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartMedicine));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbbxDiseases = new MetroFramework.Controls.MetroComboBox();
            this.txtMinAge = new MetroFramework.Controls.MetroTextBox();
            this.txtMaxAge = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.listViewMedicine = new System.Windows.Forms.ListView();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Hastalık";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(164, 96);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Minimum Yaş";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(291, 96);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Maksimum Yaş";
            // 
            // cmbbxDiseases
            // 
            this.cmbbxDiseases.FormattingEnabled = true;
            this.cmbbxDiseases.ItemHeight = 23;
            this.cmbbxDiseases.Location = new System.Drawing.Point(19, 132);
            this.cmbbxDiseases.Name = "cmbbxDiseases";
            this.cmbbxDiseases.Size = new System.Drawing.Size(121, 29);
            this.cmbbxDiseases.TabIndex = 3;
            this.cmbbxDiseases.UseSelectable = true;
            this.cmbbxDiseases.SelectedIndexChanged += new System.EventHandler(this.cmbbxDiseases_SelectedIndexChanged);
            // 
            // txtMinAge
            // 
            this.txtMinAge.Lines = new string[0];
            this.txtMinAge.Location = new System.Drawing.Point(164, 138);
            this.txtMinAge.MaxLength = 32767;
            this.txtMinAge.Name = "txtMinAge";
            this.txtMinAge.PasswordChar = '\0';
            this.txtMinAge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMinAge.SelectedText = "";
            this.txtMinAge.Size = new System.Drawing.Size(87, 23);
            this.txtMinAge.TabIndex = 4;
            this.txtMinAge.UseSelectable = true;
            // 
            // txtMaxAge
            // 
            this.txtMaxAge.Lines = new string[0];
            this.txtMaxAge.Location = new System.Drawing.Point(291, 138);
            this.txtMaxAge.MaxLength = 32767;
            this.txtMaxAge.Name = "txtMaxAge";
            this.txtMaxAge.PasswordChar = '\0';
            this.txtMaxAge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaxAge.SelectedText = "";
            this.txtMaxAge.Size = new System.Drawing.Size(87, 23);
            this.txtMaxAge.TabIndex = 5;
            this.txtMaxAge.UseSelectable = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(435, 131);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "B U L";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listViewMedicine
            // 
            this.listViewMedicine.Location = new System.Drawing.Point(19, 182);
            this.listViewMedicine.Name = "listViewMedicine";
            this.listViewMedicine.Size = new System.Drawing.Size(600, 308);
            this.listViewMedicine.TabIndex = 7;
            this.listViewMedicine.UseCompatibleStateImageBehavior = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(569, 42);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SmartMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 513);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.listViewMedicine);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtMaxAge);
            this.Controls.Add(this.txtMinAge);
            this.Controls.Add(this.cmbbxDiseases);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "SmartMedicine";
            this.Text = "Akıllı İlaç";
            this.Load += new System.EventHandler(this.SmartMedicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbbxDiseases;
        private MetroFramework.Controls.MetroTextBox txtMinAge;
        private MetroFramework.Controls.MetroTextBox txtMaxAge;
        private MetroFramework.Controls.MetroButton btnSearch;
        private System.Windows.Forms.ListView listViewMedicine;
        private System.Windows.Forms.Button btnExit;
    }
}