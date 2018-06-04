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
namespace Medicine
{
    public partial class Login : MetroForm
    {
        MedicalEntities db = new MedicalEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName, password;
            userName = txtUserName.Text;
            password = txtPassword.Text;
            Users user = db.Users.Where(x => x.UserName == userName && x.Password == password).FirstOrDefault();
            if(user != null)
            {
                if(user.isManager == true)
                {
                    AdminForms.Dashboard dashboard = new AdminForms.Dashboard();
                    this.Hide();
                    dashboard.ShowDialog();
                }
                else
                {
                    PersonelForms.SmartMedicine sm = new PersonelForms.SmartMedicine();
                    this.Hide();
                    sm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola yanlış.");
            }
            
        }
    }
}
