﻿using System;
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
    public partial class ManufacturerCreate : MetroForm
    {
        MedicalEntities db = new MedicalEntities();
        public ManufacturerCreate(ManufacturerList list)
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
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Manufacturers manufacturer = new Manufacturers();
                manufacturer.Name = txtName.Text;
                db.Manufacturers.Add(manufacturer);
                db.SaveChanges();
                DialogResult result = MessageBox.Show(this, "Firma başarıyla kayıt edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(this, "Firma oluştururken hata ile karşılaşıldı.", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        
    }
}