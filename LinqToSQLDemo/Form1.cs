using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSQLDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var dbCtx = new ValtechDBDataContext();//creating object for connection
            tbl_employee record = new tbl_employee
            {
                Ecode = int.Parse(txtEcode.Text),
                Ename=txtEname.Text,
                salary=int.Parse(txtSalary.Text),
                deptid=int.Parse(txtDeptid.Text)
            };
            //insert using linq to sql
            dbCtx.tbl_employees.InsertOnSubmit(record);
            //save changes to database
            dbCtx.SubmitChanges();
            MessageBox.Show("Record inserted");
            //refresh datagrid
            RefreshData();
        }
        private void RefreshData()
        {
            var dbCtx = new ValtechDBDataContext();
            dgv.DataSource = dbCtx.tbl_employees.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Ecode = int.Parse(txtEcode.Text);
            //find record to be deleted
            var dbCtx = new ValtechDBDataContext();
            var records = dbCtx.tbl_employees
                .Where(o => o.Ecode == Ecode);
            if (records.Count() == 0)
            {
                MessageBox.Show("record does not exist");

            }
            else
            {
                //delete the recordfound
                dbCtx.tbl_employees.DeleteAllOnSubmit(records);
                dbCtx.SubmitChanges();
                RefreshData();
                MessageBox.Show("record deleted");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int Ecode = int.Parse(txtEcode.Text);
            //find the record to be updated
            var dbCtx = new ValtechDBDataContext();
            var record = dbCtx.tbl_employees.Where(o => o.Ecode == Ecode).SingleOrDefault();
            //update the values
            record.salary = int.Parse(txtSalary.Text);
            //save changes to databse
            dbCtx.SubmitChanges();
            RefreshData();
            MessageBox.Show("record updated");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEname.SelectedText = string.Empty;
            txtSalary.SelectedText = string.Empty;
            txtDeptid.SelectedText = string.Empty;
           
            int Ecode = int.Parse(txtEcode.Text);
            var dbCtx = new ValtechDBDataContext();
            var record = dbCtx.tbl_employees.Where(o => o.Ecode == Ecode).Single();
            txtEname.SelectedText = record.Ename;
            txtSalary.SelectedText = record.salary.ToString();
            txtDeptid.SelectedText = record.deptid.ToString();
            dbCtx.SubmitChanges();

        }

        private void sumofsalary_Click(object sender, EventArgs e)
        {
            var dbCtx = new ValtechDBDataContext();
            var record = dbCtx.tbl_employees.Sum(o => o.salary);
            txtsum.SelectedText = record.ToString();
            dbCtx.SubmitChanges();
        }
    }
}
