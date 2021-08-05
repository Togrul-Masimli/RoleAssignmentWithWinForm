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
    public partial class Form3 : Form
    {
        int index = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roleAssignmentAppDBDataSet.Editors' table. You can move, or remove it, as needed.
            this.editorsTableAdapter.Fill(this.roleAssignmentAppDBDataSet.Editors);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            using (RoleAssignmentAppContext context = new RoleAssignmentAppContext())
            {
                var addedEditor = new Editor { EditorName = editorNameBox.Text, Password = editorPasswordBox.Text };
                if (createCheck.Checked == true)
                {
                    addedEditor.CanCreate = true;
                }
                if (readCheck.Checked == true)
                {
                    addedEditor.CanRead = true;
                }
                if (updateCheck.Checked == true)
                {
                    addedEditor.CanUpdate = true;
                }
                if (deleteCheck.Checked == true)
                {
                    addedEditor.CanDelete = true;
                }
                context.Editors.Add(addedEditor);
                context.SaveChanges();
                MessageBox.Show("New Editor Added");
                this.editorsTableAdapter.Fill(this.roleAssignmentAppDBDataSet.Editors);
            }

            editorNameBox.Text = " ";
            editorPasswordBox.Text = " ";
            createCheck.Checked = false;
            readCheck.Checked = false;
            updateCheck.Checked = false;
            deleteCheck.Checked = false;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            using (RoleAssignmentAppContext context = new RoleAssignmentAppContext())
            {
                var updatedEditor = context.Editors.SingleOrDefault(x => x.EditorId == index);
                updatedEditor.EditorName = editorNameBox.Text;
                updatedEditor.Password = editorPasswordBox.Text;
                if (createCheck.Checked == true)
                {
                    updatedEditor.CanCreate = true;
                }
                else
                {
                    updatedEditor.CanCreate = false;
                }
                if (readCheck.Checked == true)
                {
                    updatedEditor.CanRead = true;
                }
                else
                {
                    updatedEditor.CanRead = false;
                }
                if (updateCheck.Checked == true)
                {
                    updatedEditor.CanUpdate = true;
                }
                else
                {
                    updatedEditor.CanUpdate = false;
                }
                if (deleteCheck.Checked == true)
                {
                    updatedEditor.CanDelete = true;
                }
                else
                {
                    updatedEditor.CanDelete = false;
                }
                context.Editors.Update(updatedEditor);
                context.SaveChanges();
                this.editorsTableAdapter.Fill(this.roleAssignmentAppDBDataSet.Editors);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            using (RoleAssignmentAppContext context = new RoleAssignmentAppContext())
            {
                var deletedEditor = context.Editors.SingleOrDefault(x => x.EditorId == index);
                context.Editors.Remove(deletedEditor);
                context.SaveChanges();
                MessageBox.Show($"{deletedEditor.EditorName} - deleted");
                this.editorsTableAdapter.Fill(this.roleAssignmentAppDBDataSet.Editors);
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            editorNameBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            editorPasswordBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
