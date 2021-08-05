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

        private void addEditorBrn_Click(object sender, EventArgs e)
        {
            using (RoleAssignmentAppContext context = new RoleAssignmentAppContext())
            {
                var editor = new Editor { EditorName = editorNameBox.Text, Password = editorPasswordBox.Text };
                if (createCheck.Checked == true)
                {
                    editor.CanCreate = true;
                }
                if (readCheck.Checked == true)
                {
                    editor.CanRead = true;
                }
                if (updateCheck.Checked == true)
                {
                    editor.CanUpdate = true;
                }
                if (deleteCheck.Checked == true)
                {
                    editor.CanDelete = true;
                }
                context.Editors.Add(editor);
                context.SaveChanges();
                MessageBox.Show("New Editor Added");
            }

            editorNameBox.Text = " ";
            editorPasswordBox.Text = " ";
            createCheck.Checked = false;
            readCheck.Checked = false;
            updateCheck.Checked = false;
            deleteCheck.Checked = false;

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
