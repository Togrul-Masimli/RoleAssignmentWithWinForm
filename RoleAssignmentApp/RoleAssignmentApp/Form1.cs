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
    public partial class Form1 : Form
    {
        public Editor editor { get; set; }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
           
            using (RoleAssignmentAppContext context = new RoleAssignmentAppContext())
            {
                if (context.Admins.Any(x => x.Username == emailBox.Text && x.Password == passwordBox.Text))
                {
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                    this.Close();
                }
                else if (context.Editors.Any(x => x.EditorName == emailBox.Text && x.Password == passwordBox.Text))
                {
                    editor = context.Editors.SingleOrDefault(x => x.EditorName == emailBox.Text && x.Password == passwordBox.Text);
                    this.Hide();
                    Form4 form4 = new Form4(editor);
                    form4.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email ve ya password yanlisdir");
                }

            }
            
        }
    }
}
