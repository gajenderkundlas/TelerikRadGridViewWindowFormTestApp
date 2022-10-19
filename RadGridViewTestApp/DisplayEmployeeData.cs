using RadGridViewTestApp.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinForms.Controls.Spreadsheet.Dialogs;

namespace RadGridViewTestApp
{
    public partial class radGridViewForm : Telerik.WinControls.UI.RadForm
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public radGridViewForm()
        {
            InitializeComponent();
            BindData();
            timer.Interval = 2000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            callMenuHelp();
            timer.Stop();
        }
        /// <summary>
        /// Used to fill the grid view
        /// </summary>
        public void BindData() {
            DataSet ds = EmployeeService.GetEmployee(0);
            if (ds.Tables.Count > 0) {
                radGridView.DataSource = ds.Tables[0];
            }
           
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void menuAddEmployee_Click(object sender, EventArgs e)
        {
            EmployeeDto employee = new EmployeeDto();
            employee.Id = 0;
            AddEmployee add = new AddEmployee(this,employee);
            add.Show();
        }

        private void menuDeleteEmployee_Click(object sender, EventArgs e)
        {
            DeleteEmployee();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();         
        }

        private void radGridView_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            EditEmployee(e.Row);
        }

        private void radGridView_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            e.ContextMenu = ContextGridView.DropDown;
        }

        private void menuEdit_Click(object sender, EventArgs e)
        {
            var row = radGridView.SelectedRows;
            EditEmployee(row[0]);
        }
       void DeleteEmployee() {
            var row = radGridView.SelectedRows;
            var confirmResult = MessageBox.Show($"Are you sure you want to delete employee-id:{row[0].Cells[0].Value.ToString()} ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    EmployeeService.DeleteEmployee(Convert.ToInt32(row[0].Cells[0].Value));
                    MessageBox.Show("Record delete successfully.");
                    this.BindData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        void EditEmployee(GridViewRowInfo Row) {
            EmployeeDto employee = new EmployeeDto();
            employee.Id = Convert.ToInt16(Row.Cells[0].Value);
            employee.LastName = Convert.ToString(Row.Cells[1].Value);
            employee.FirstName = Convert.ToString(Row.Cells[2].Value);
            employee.Title = Convert.ToString(Row.Cells[3].Value);
            employee.TitleOfCourtesy = Convert.ToString(Row.Cells[4].Value);
            employee.DateOfBirth = Convert.ToDateTime(Row.Cells[5].Value);
            employee.HireDate = Convert.ToDateTime(Row.Cells[6].Value);
            employee.Address = Convert.ToString(Row.Cells[7].Value);
            employee.City = Convert.ToString(Row.Cells[8].Value);
            employee.Region = Convert.ToString(Row.Cells[9].Value);
            employee.PostalCode = Convert.ToInt32(Row.Cells[10].Value);
            AddEmployee add = new AddEmployee(this, employee);
            add.Show();
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            DeleteEmployee();
        }

        private void menuHelp_Click(object sender, EventArgs e)
        {
            callMenuHelp();
        }
        void callMenuHelp() {
            Help helpObj = new Help();
            helpObj.Show();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            About aboutObj = new About();
            aboutObj.Show();    
        }
    }
}
