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
using Medicine.Models;
using System.Data.Entity;
namespace Medicine.PersonelForms
{
    public partial class SmartMedicine : MetroForm
    {
        MedicalEntities db = new MedicalEntities();
        public SmartMedicine()
        {
            InitializeComponent();
        }

        private void SmartMedicine_Load(object sender, EventArgs e)
        {
            List<Diseases> list = db.Diseases.ToList();
            Diseases disease = new Diseases();
            disease.Name = "Hastalık Seçiniz";
            disease.ID = -1;
            list.Add(disease);
            cmbbxDiseases.DataSource = list.OrderBy(x => x.ID).ToList();
            cmbbxDiseases.DisplayMember = "Name";
            cmbbxDiseases.ValueMember = "ID";
            listViewMedicine.View = View.Details;
            listViewMedicine.GridLines = true;
            listViewMedicine.FullRowSelect = true;

            listViewMedicine.Columns.Add("Sıra", 30);
            listViewMedicine.Columns.Add("İlaç Adı", 100);
            listViewMedicine.Columns.Add("Kullanım Amacı", 150);
            listViewMedicine.Columns.Add("Yan Etkileri", 150);
            listViewMedicine.Columns.Add("Minimum Yaş", 50);
            listViewMedicine.Columns.Add("Maksimum Yaş", 50);
            listViewMedicine.Columns.Add("Fiyat", 70);



        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listViewMedicine.Items.Clear();
            List<MedicineOfDiseases> mod = new List<MedicineOfDiseases>();
            if(cmbbxDiseases.SelectedValue.ToString() == "-1")
            {
                DialogResult result = MessageBox.Show(this, "Lütfen hastalık seçiniz.", "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                if (cmbbxDiseases.SelectedValue.ToString() != "-1" && txtMinAge.Text != "" && txtMaxAge.Text != "")
                {
                    int minAge = int.Parse(txtMinAge.Text);
                    int maxAge = int.Parse(txtMaxAge.Text);
                    int diseasesId = int.Parse(cmbbxDiseases.SelectedValue.ToString());
                    mod = db.MedicineOfDiseases.Where(x => x.D_ID == diseasesId && x.MinAge >= minAge && x.MaxAge <= maxAge).ToList();
                }
                else
                {
                    if (txtMinAge.Text != "")
                    {
                        int minAge = int.Parse(txtMinAge.Text);
                        int diseasesId = int.Parse(cmbbxDiseases.SelectedValue.ToString());
                        mod = db.MedicineOfDiseases.Where(x => x.D_ID == diseasesId && x.MinAge >= minAge).ToList();
                    }
                    else if (txtMaxAge.Text != "")
                    {
                        int maxAge = int.Parse(txtMaxAge.Text);
                        int diseasesId = int.Parse(cmbbxDiseases.SelectedValue.ToString());
                        mod = db.MedicineOfDiseases.Where(x => x.D_ID == diseasesId && x.MaxAge <= maxAge).ToList();
                    }
                    else
                    {
                        int diseasesId = int.Parse(cmbbxDiseases.SelectedValue.ToString());
                        mod = db.MedicineOfDiseases.Where(x => x.D_ID == diseasesId).ToList();
                    }
                }
                int i = 0;
                foreach (var item in mod)
                {
                    i++;
                    Medicines medicine = db.Medicines.Find(item.M_ID);
                    string[] row = { i.ToString(),medicine.Name,medicine.PurposeOfUsing,medicine.SideEffects,item.MinAge.ToString(),item.MaxAge.ToString(),medicine.Price.ToString() + " ₺"};
                    var satir = new ListViewItem(row);
                    listViewMedicine.Items.Add(satir);
                }
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.ShowDialog();
        }

        private void cmbbxDiseases_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
