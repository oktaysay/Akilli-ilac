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
using System.Data.Entity;

namespace Medicine.AdminForms
{
    public partial class MedicineEdit : MetroForm
    {
        MedicalEntities db = new MedicalEntities();
        public MedicineEdit(MedicineList list)
        {
            InitializeComponent();
            mediList = list;
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        MedicineList mediList;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void raiseUpdate()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler?.Invoke(this, args);
        }

        private void MedicineEdit_Load(object sender, EventArgs e)
        {
            int id = int.Parse(lblId.Text);
            Medicines medicine = db.Medicines.Find(id);
            txtMedicineName.Text = medicine.Name;
            txtBarcodeNo.Text = medicine.BarcodeNo;
            txtPrice.Text = medicine.Price.ToString();
            txtPurposeOfUsing.Text = medicine.PurposeOfUsing;
            txtSideEffects.Text = medicine.SideEffects;

            List<Manufacturers> list = db.Manufacturers.ToList();
            cmbbxManufacturer.DataSource = list.OrderBy(x => x.ID).ToList();
            cmbbxManufacturer.DisplayMember = "Name";
            cmbbxManufacturer.ValueMember = "ID";
            cmbbxManufacturer.SelectedValue = medicine.ManufacturerId;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(lblId.Text);
                Medicines medicine = db.Medicines.Find(id);
                medicine.Name = txtMedicineName.Text;
                medicine.BarcodeNo = txtBarcodeNo.Text;
                medicine.ManufacturerId = int.Parse(cmbbxManufacturer.SelectedValue.ToString());
                medicine.Price = Convert.ToDouble(txtPrice.Text.Replace(".", ","));
                medicine.PurposeOfUsing = txtPurposeOfUsing.Text;
                medicine.SideEffects = txtSideEffects.Text;
                db.Entry(medicine).State = EntityState.Modified;
                db.SaveChanges();
                DialogResult result = MessageBox.Show(this, "İlaç kaydı başarıyla düzenlendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    raiseUpdate();
                    this.Close();
                }
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show(this, "İlaç kaydı düzenlenirken hata ile karşılaşıldı.", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
    
}
