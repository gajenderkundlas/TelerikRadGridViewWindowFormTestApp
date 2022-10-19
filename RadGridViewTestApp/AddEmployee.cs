using RadGridViewTestApp.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace RadGridViewTestApp
{
    public partial class AddEmployee : Telerik.WinControls.UI.RadForm
    {
        private readonly radGridViewForm mainForm;
        EmployeeDto empObj;
        public AddEmployee(radGridViewForm mainForm,EmployeeDto _empObj)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            empObj =_empObj;
            if (empObj.Id > 0) {
                SetEditMode(empObj);
            }
        }
        void SetEditMode(EmployeeDto _empObj) {
            txtTitleOfCourtesy.Text=empObj.TitleOfCourtesy;
            txtLastName.Text=empObj.LastName;
            txtFirstName.Text=empObj.FirstName;
            txtTitle.Text=empObj.Title;
            dtpDateOfBirth.Text=empObj.DateOfBirth.ToString("MM/dd/yyyy");
            dtpHireDate.Text=empObj.HireDate.ToString("MM/dd/yyyy");
            txtAddress.Text=empObj.Address;
            txtCity.Text=empObj.City;
            txtRegion.Text=empObj.Region;
            txtPostalCode.Text=empObj.PostalCode.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                empObj.TitleOfCourtesy = txtTitleOfCourtesy.Text;
                empObj.LastName = txtLastName.Text;
                empObj.FirstName = txtFirstName.Text;
                empObj.Title = txtTitle.Text;
                empObj.DateOfBirth = Convert.ToDateTime(dtpDateOfBirth.Text);
                empObj.HireDate = Convert.ToDateTime(dtpHireDate.Text);
                empObj.Address = txtAddress.Text;
                empObj.City = txtCity.Text;
                empObj.Region = txtRegion.Text;
                empObj.PostalCode = Convert.ToInt32(txtPostalCode.Text);
                EmployeeService.SaveAndUpdateEmployee(empObj);
                this.mainForm.BindData();
                if (empObj.Id > 0) {
                    MessageBox.Show("Data updated successfully");
                } else {
                    MessageBox.Show("Data saved successfully");
                }
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
