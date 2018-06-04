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
    public partial class MedicineList : MetroForm
    {
        public MedicineList()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MedicineCreate create = new MedicineCreate(this);
            create.UpdateEventHandler += Create_UpdateEventHandler1;
            create.ShowDialog();
        }

        private void Create_UpdateEventHandler1(object sender, MedicineCreate.UpdateEventArgs args)
        {
            BindSource();
        }
  

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MedicalEntities db = new MedicalEntities();
                int id = int.Parse(listMedicine.SelectedItems[0].Text);
                Manufacturers manufacturers = db.Manufacturers.Find(id);
                db.Manufacturers.Remove(manufacturers);
                db.SaveChanges();
                BindSource();
                MessageBox.Show(this, "İlaç başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "İlaç silinirken hata ile karşılaşıldı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
     
        private void ManufacturerList_Load(object sender, EventArgs e)
        {
            BindSource();
        }
        public void BindSource()
        {
            listMedicine.Items.Clear();

            MedicalEntities db = new MedicalEntities();

            foreach (var item in db.Medicines.ToList())
            {
                
                Manufacturers manufacturers=db.Manufacturers.Find(item.ManufacturerId);
               
                string[]  row = { item.ID.ToString(), item.Name, manufacturers==null?"-Üretici Firma Silinmiş-":manufacturers.Name, item.Price + " ₺", item.PurposeOfUsing, item.SideEffects};
                var satir = new ListViewItem(row);
                listMedicine.Items.Add(satir);
            }
 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MedicalEntities db = new MedicalEntities();

            MedicineEdit edit = new MedicineEdit(this);
            edit.UpdateEventHandler += Edit_UpdateEventHandler;
            int id = int.Parse(listMedicine.SelectedItems[0].Text);
            
            edit.lblId.Text = id.ToString();
            edit.ShowDialog();

        }

        private void Edit_UpdateEventHandler(object sender, MedicineEdit.UpdateEventArgs args)
        {
            BindSource();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }

        private void MedicineList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }
    }
}
