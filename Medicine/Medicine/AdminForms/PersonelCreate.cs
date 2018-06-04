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
    public partial class PersonelCreate : MetroForm
    {
        MedicalEntities db = new MedicalEntities();
        public PersonelCreate(PersonelList list)
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
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUserName.Text != "" && txtEmail.Text != "" && txtUserName.Text != "" && txtPhone.Text != "" && txtPassword.Text != "")
                {
                    Users user = new Users();
                    user.NameSurname = txtNameSurname.Text;
                    user.Email = txtEmail.Text;
                    user.Phone = txtPhone.Text;
                    user.UserName = txtUserName.Text;
                    user.Password = txtPassword.Text;
                    user.isManager = false;
                    db.Users.Add(user);
                    db.SaveChanges();
                    DialogResult result = MessageBox.Show(this, "Kullanıcı başarıyla kayıt edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        PersonelList list = new PersonelList();
                        raiseUpdate();
                        this.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Lütfen tüm bilgileri doldurunuz.");
                }
              
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(this, "Kullanıcı oluştururken hata ile karşılaşıldı.", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        
    }
}
