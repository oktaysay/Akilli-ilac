using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Medicine.Models;
namespace Medicine.AdminForms
{
    public partial class MedicineOfDiseasesCreate : MetroForm
    {
        MedicalEntities db = new MedicalEntities();
        public MedicineOfDiseasesCreate()
        {
            InitializeComponent();
        }

        private void MedicineOfDiseases_Load(object sender, EventArgs e)
        {
            List<Medicines> listMedicine = db.Medicines.ToList();
            Medicines medicine = new Medicines();
            medicine.Name = "İlaç Seçiniz";
            medicine.ID = -1;
            listMedicine.Add(medicine);
            cmbbxMedicines.DataSource = listMedicine.OrderBy(x => x.ID).ToList();
            cmbbxMedicines.DisplayMember = "Name";
            cmbbxMedicines.ValueMember = "ID";

            List<Diseases> listDisease = db.Diseases.ToList();
            Diseases disiase = new Diseases();
            disiase.Name = "Hastalık Seçiniz";
            disiase.ID = -1;
            listDisease.Add(disiase);
            cmbbxDiseases.DataSource = listDisease.OrderBy(x => x.ID).ToList();
            cmbbxDiseases.DisplayMember = "Name";
            cmbbxDiseases.ValueMember = "ID";

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                MedicineOfDiseases mod = new MedicineOfDiseases();
                mod.M_ID = int.Parse(cmbbxMedicines.SelectedValue.ToString());
                mod.D_ID = int.Parse(cmbbxDiseases.SelectedValue.ToString());
                mod.MinAge = int.Parse(txtMinAge.Text);
                if(txtMaxAge.Text != "" && txtMaxAge.Text != null)
                {
                    mod.MaxAge = int.Parse(txtMaxAge.Text);
                }
                db.MedicineOfDiseases.Add(mod);
                db.SaveChanges();
                DialogResult result = MessageBox.Show(this, "Hastalık-ilaç bağlama işlemi başarıyla kayıt edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.ShowDialog();
                }
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show(this, "Hastalık-ilaç bağlama işlemi kaydedilirken hata ile karşılaşıldı.", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void MedicineOfDiseasesCreate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }

        private void cmbbxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
