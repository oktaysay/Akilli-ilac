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
    public partial class ManufacturerList : MetroForm
    {
        public ManufacturerList()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ManufacturerCreate create = new ManufacturerCreate(this);
            create.UpdateEventHandler += Create_UpdateEventHandler1;
            create.ShowDialog();
        }

        private void Create_UpdateEventHandler1(object sender, ManufacturerCreate.UpdateEventArgs args)
        {
            BindSource();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MedicalEntities db = new MedicalEntities();
                int id = int.Parse(listManufacturer.SelectedItems[0].Text);
                Manufacturers manufacturers = db.Manufacturers.Find(id);
                db.Manufacturers.Remove(manufacturers);
                db.SaveChanges();
                BindSource();
                MessageBox.Show(this, "Üretici Firma başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Üretici Firma silinirken hata ile karşılaşıldı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Create_UpdateEventHandler(object sender, PersonelCreate.UpdateEventArgs args)
        {
            BindSource();
        }
        private void ManufacturerList_Load(object sender, EventArgs e)
        {
            BindSource();
        }
        public void BindSource()
        {
            listManufacturer.Items.Clear();

            MedicalEntities db = new MedicalEntities();
            foreach (var item in db.Manufacturers.ToList())
            {
                string[] row = { item.ID.ToString(), item.Name };
                var satir = new ListViewItem(row);
                listManufacturer.Items.Add(satir);
            }
          
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ManufacturerEdit edit = new ManufacturerEdit(this);
            edit.UpdateEventHandler += Edit_UpdateEventHandler;
            int id = int.Parse(listManufacturer.SelectedItems[0].Text);
            edit.lblId.Text = id.ToString();
            edit.ShowDialog();
        }


        private void Edit_UpdateEventHandler(object sender, ManufacturerEdit.UpdateEventArgs args)
        {
            BindSource();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }

        private void ManufacturerList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }
    }
}
