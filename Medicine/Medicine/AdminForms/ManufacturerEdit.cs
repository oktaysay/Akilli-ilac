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
    public partial class ManufacturerEdit : MetroForm
    {

        MedicalEntities db = new MedicalEntities();
        public ManufacturerEdit(ManufacturerList list)
        {
            InitializeComponent();
            manuList = list;
        }
        ManufacturerList manuList;
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void raiseUpdate()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler?.Invoke(this, args);
        }
        private void ManufacturerEdit_Load(object sender, EventArgs e)
        {
            int id = int.Parse(lblId.Text);
            Manufacturers manufacturer = db.Manufacturers.Find(id);
            txtName.Text = manufacturer.Name;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(lblId.Text);
                Manufacturers manufacturer = db.Manufacturers.Find(id);
                manufacturer.Name = txtName.Text;
                db.Entry(manufacturer).State = EntityState.Modified;
                db.SaveChanges();
                DialogResult result = MessageBox.Show(this, "Üretici firma kaydı başarıyla düzenlendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    raiseUpdate();
                    this.Close();
                }
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show(this, "Üretici firma kaydı düzenlenirken hata ile karşılaşıldı.", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
