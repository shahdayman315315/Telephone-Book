using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Book
{
    public partial class PhoneBook : Form
    {
        DataTable contacts=new DataTable();
        bool editing=false;
        public PhoneBook()
        {
            InitializeComponent();
        }
        


        private void PhoneBook_Load(object sender, EventArgs e)
        {
            contacts.Columns.Add("Fisrt Name");
            contacts.Columns.Add("Last Name");
            contacts.Columns.Add("Email");
            contacts.Columns.Add("Phone Num");

            contactsdatagrid.DataSource = contacts;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            firstnametextbox.Text = "";
            lastnametextbox.Text = "";
            emailtextbox.Text = "";
            phonenumtextbox.Text = "";

        }

       

        private void contactsdatagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            firstnametextbox.Text = contacts.Rows[contactsdatagrid.CurrentCell.RowIndex].ItemArray[0].ToString();
            lastnametextbox.Text = contacts.Rows[contactsdatagrid.CurrentCell.RowIndex].ItemArray[1].ToString();
            emailtextbox.Text = contacts.Rows[contactsdatagrid.CurrentCell.RowIndex].ItemArray[2].ToString();
            phonenumtextbox.Text = contacts.Rows[contactsdatagrid.CurrentCell.RowIndex].ItemArray[3].ToString();
            editing = true;
        }

        private void laodbuttonclick(object sender, EventArgs e)
        {
            firstnametextbox.Text = contacts.Rows[contactsdatagrid.CurrentCell.RowIndex].ItemArray[0].ToString();
            lastnametextbox.Text = contacts.Rows[contactsdatagrid.CurrentCell.RowIndex].ItemArray[1].ToString(); 
            emailtextbox.Text = contacts.Rows[contactsdatagrid.CurrentCell.RowIndex].ItemArray[2].ToString(); 
            phonenumtextbox.Text = contacts.Rows[contactsdatagrid.CurrentCell.RowIndex].ItemArray[3].ToString();
            editing = true;
        }

        private void savebuttonclick(object sender, EventArgs e)
        {
            if (editing)
            {
                contacts.Rows[contactsdatagrid.CurrentCell.RowIndex]["First Name"] = firstnametextbox.Text;
                contacts.Rows[contactsdatagrid.CurrentCell.RowIndex]["Last Name"] = lastnametextbox.Text;
                contacts.Rows[contactsdatagrid.CurrentCell.RowIndex]["Email"] = emailtextbox.Text;
                contacts.Rows[contactsdatagrid.CurrentCell.RowIndex]["Phone Num"] = phonenumtextbox.Text;

            }
            else { 
            contacts.Rows.Add(firstnametextbox.Text, lastnametextbox.Text,emailtextbox.Text, phonenumtextbox.Text);
            
            }

            firstnametextbox.Text = "";
            lastnametextbox.Text = "";
            emailtextbox.Text = "";
            phonenumtextbox.Text = "";
            editing = false;
        }

        private void deletebuttonclick(object sender, EventArgs e)
        {
            try
            {
                contacts.Rows[contactsdatagrid.CurrentCell.RowIndex].Delete();

            }
            catch
            {
                Console.WriteLine("Not valid Row");
            }

        }
    }
}
