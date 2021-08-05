using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoleAssignmentApp
{
    public partial class Form2 : Form
    {
        Admin admin;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (RoleAssignmentAppContext context = new RoleAssignmentAppContext())
            {
                admin = context.Admins.SingleOrDefault(x => x.Id == 1);
            }

            usernameBox.Text = admin.Username;
            emailBox.Text = admin.Email;
            passwordBox.Text = admin.Password;

            emailBox.Enabled = false;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            using (RoleAssignmentAppContext context = new RoleAssignmentAppContext())
            {
                admin = context.Admins.SingleOrDefault(x => x.Id == 1);
                admin.Username = usernameBox.Text;
                admin.Password = passwordBox.Text;
                context.SaveChanges();
            }
        }

        

        private void showEditorBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
