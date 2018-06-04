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
    public partial class DiseasesList : MetroForm
    {
        public DiseasesList()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DiseasesCreate create = new DiseasesCreate(this);
            create.UpdateEventHandler += Create_UpdateEventHandler1;
            create.ShowDialog();
        }

        private void Create_UpdateEventHandler1(object sender, DiseasesCreate.UpdateEventArgs args)
        {
            BindSource();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                MedicalEntities db = new MedicalEntities();
                int id = int.Parse(listDiseases.SelectedItems[0].Text);
                Diseases diseases = db.Diseases.Find(id);
                db.Diseases.Remove(diseases);
                db.SaveChanges();
                BindSource();
                MessageBox.Show(this, "Hastalık başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Hastalık silinirken hata ile karşılaşıldı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }
        private void Create_UpdateEventHandler(object sender, PersonelCreate.UpdateEventArgs args)
        {
            BindSource();
        }
        public void BindSource()
        {
            listDiseases.Items.Clear();

            MedicalEntities db = new MedicalEntities();
            DataTable dt = new DataTable();
            foreach (var item in db.Diseases.ToList())
            {
                string[] row = { item.ID.ToString(), item.Name };
                var satir = new ListViewItem(row);
                listDiseases.Items.Add(satir);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DiseasesEdit edit = new DiseasesEdit(this);
            edit.UpdateEventHandler += Edit_UpdateEventHandler;
            int id = int.Parse(listDiseases.SelectedItems[0].Text);
            edit.lblId.Text = id.ToString();
            edit.ShowDialog();


        }
        private void Edit_UpdateEventHandler(object sender, DiseasesEdit.UpdateEventArgs args)
        {
            BindSource();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }

        private void DiseasesList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }

        private void DiseasesList_Load(object sender, EventArgs e)
        {
            BindSource();
        }
    }
}
