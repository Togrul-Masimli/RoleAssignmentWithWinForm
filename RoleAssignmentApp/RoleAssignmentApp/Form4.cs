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
    public partial class Form4 : Form
    {
        Editor currentEdtior;
        Form1 form1 = new Form1();
        int index = 0;
        public Form4(Editor editor)
        {
            InitializeComponent();
            currentEdtior = editor;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roleAssignmentAppDBDataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.roleAssignmentAppDBDataSet1.Customers);



            button1.Enabled = false;
            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;

            if (currentEdtior.CanCreate == true)
            {
                button1.Enabled = true;
            }
            if (currentEdtior.CanUpdate == true)
            {
                updateBtn.Enabled = true;
            }
            if (currentEdtior.CanDelete == true)
            {
                deleteBtn.Enabled = true;
            }

            label1.Text = $"Hi, {currentEdtior.EditorName}!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (RoleAssignmentAppContext context = new RoleAssignmentAppContext())
            {
                Customer customer = new Customer { CustomerName = customerNameBox.Text, Email = customerEmailBox.Text, PhoneNumber = customerPhoneBox.Text };
                context.Customers.Add(customer);
                context.SaveChanges();
                this.customersTableAdapter.Fill(this.roleAssignmentAppDBDataSet1.Customers);
            }

            customerNameBox.Text = " ";
            customerEmailBox.Text = " ";
            customerPhoneBox.Text = " ";
        }

        

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            customerNameBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            customerEmailBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            customerPhoneBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
            using (RoleAssignmentAppContext context = new RoleAssignmentAppContext())
            {
                var deletedCustomer = context.Customers.SingleOrDefault(x => x.CustomerID == index);
                context.Customers.Remove(deletedCustomer);
                context.SaveChanges();
                MessageBox.Show($"{deletedCustomer.CustomerName} - deleted");
                this.customersTableAdapter.Fill(this.roleAssignmentAppDBDataSet1.Customers);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            using (RoleAssignmentAppContext context = new RoleAssignmentAppContext())
            {
                var updatedCustomer = context.Customers.SingleOrDefault(x => x.CustomerID == index);
                updatedCustomer.CustomerName = customerNameBox.Text;
                updatedCustomer.Email = customerEmailBox.Text;
                updatedCustomer.PhoneNumber = customerPhoneBox.Text;
                context.Customers.Update(updatedCustomer);
                context.SaveChanges();
                this.customersTableAdapter.Fill(this.roleAssignmentAppDBDataSet1.Customers);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}
