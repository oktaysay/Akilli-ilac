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
    public partial class PersonelList : MetroForm
    {
        public PersonelList()
        {
            InitializeComponent();
        }
       
        private void PersonelList_Load(object sender, EventArgs e)
        {
            BindSource();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            PersonelCreate create = new PersonelCreate(this);
            create.UpdateEventHandler += Create_UpdateEventHandler;
            create.ShowDialog();
        }

        private void Create_UpdateEventHandler(object sender, PersonelCreate.UpdateEventArgs args)
        {
            BindSource();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MedicalEntities db = new MedicalEntities();
                int id = int.Parse(listPersonel.SelectedItems[0].Text);
                Users user = db.Users.Find(id);
                db.Users.Remove(user);
                db.SaveChanges();
                BindSource();
                MessageBox.Show(this, "Kullanıcı başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Kullanıcı silinirken hata ile karşılaşıldı.","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        public void BindSource()
        {
            listPersonel.Items.Clear();

            MedicalEntities db = new MedicalEntities();
           
            foreach (var item in db.Users.ToList())
            {
                string[] row = { item.ID.ToString(), item.UserName, item.NameSurname, item.Email, item.Phone, item.Password };
                var satir = new ListViewItem(row);
                listPersonel.Items.Add(satir);
            }
          
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            PersonelEdit edit = new PersonelEdit(this);
            edit.UpdateEventHandler += Edit_UpdateEventHandler;
            int id = int.Parse(listPersonel.SelectedItems[0].Text);
            edit.lblId.Text = id.ToString();
            edit.ShowDialog();
        }

        private void Edit_UpdateEventHandler(object sender, PersonelEdit.UpdateEventArgs args)
        {
            BindSource();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }

        private void PersonelList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }
    }
}
