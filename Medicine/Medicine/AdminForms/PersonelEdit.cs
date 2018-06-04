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
    public partial class PersonelEdit : MetroForm
    {
        MedicalEntities db = new MedicalEntities();
        public PersonelEdit(PersonelList list)
        {
            InitializeComponent();
            personelList = list;
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        PersonelList personelList;
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void raiseUpdate()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler?.Invoke(this, args);
        }

        private void PersonelEdit_Load(object sender, EventArgs e)
        {
            int id = int.Parse(lblId.Text);
            Users user = db.Users.Find(id);
            txtUserName.Text = user.UserName;
            txtNameSurname.Text = user.NameSurname;
            txtEmail.Text = user.Email;
            txtPassword.Text = user.Password;
            txtPhone.Text = user.Phone;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(lblId.Text);
                Users user = db.Users.Find(id);
                user.UserName = txtUserName.Text;
                user.NameSurname = txtNameSurname.Text;
                user.Email = txtEmail.Text;
                user.Password = txtPassword.Text;
                user.Phone = txtPhone.Text;
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                DialogResult result = MessageBox.Show(this, "Kullanıcı kaydı başarıyla düzenlendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    raiseUpdate();
                    this.Close();
                }
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show(this, "Kullanıcı kaydı düzenlenirken hata ile karşılaşıldı.", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
