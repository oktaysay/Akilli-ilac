﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace Medicine.AdminForms
{
    public partial class Dashboard : MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnDiseases_Click(object sender, EventArgs e)
        {
            DiseasesList diseases = new DiseasesList();
            this.Hide();
            diseases.ShowDialog();
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            MedicineList medicines = new MedicineList();
            this.Hide();
            medicines.ShowDialog();
        }

        private void btnManufacturers_Click(object sender, EventArgs e)
        {
            ManufacturerList manufacturers = new ManufacturerList();
            this.Hide();
            manufacturers.ShowDialog();
        }

        private void btnPersonels_Click(object sender, EventArgs e)
        {
            PersonelList personels = new PersonelList();
            this.Hide();
            personels.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            MedicineOfDiseasesCreate mod = new MedicineOfDiseasesCreate();
            this.Hide();
            mod.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.ShowDialog();
        }
    }
}
