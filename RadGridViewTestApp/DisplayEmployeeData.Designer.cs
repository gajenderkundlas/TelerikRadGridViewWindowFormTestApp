namespace RadGridViewTestApp
{
    partial class radGridViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGridView = new Telerik.WinControls.UI.RadGridView();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.menuAddEmployee = new Telerik.WinControls.UI.RadMenuItem();
            this.menuDeleteEmployee = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.menuHelp = new Telerik.WinControls.UI.RadMenuItem();
            this.menuAbout = new Telerik.WinControls.UI.RadMenuItem();
            this.menuExit = new Telerik.WinControls.UI.RadMenuItem();
            this.ContextGridView = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.menuEdit = new Telerik.WinControls.UI.RadMenuItem();
            this.menuDelete = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView
            // 
            this.radGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView.Location = new System.Drawing.Point(0, 0);
            this.radGridView.Margin = new System.Windows.Forms.Padding(48);
            // 
            // 
            // 
            this.radGridView.MasterTemplate.AllowAddNewRow = false;
            this.radGridView.MasterTemplate.AllowColumnChooser = false;
            this.radGridView.MasterTemplate.AllowDeleteRow = false;
            this.radGridView.MasterTemplate.AllowEditRow = false;
            this.radGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.DataType = typeof(int);
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "#Employee ID";
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.Width = 97;
            gridViewTextBoxColumn2.FieldName = "LastName";
            gridViewTextBoxColumn2.HeaderText = "Last Name";
            gridViewTextBoxColumn2.Name = "lastName";
            gridViewTextBoxColumn2.Width = 97;
            gridViewTextBoxColumn3.FieldName = "FirstName";
            gridViewTextBoxColumn3.HeaderText = "First Name";
            gridViewTextBoxColumn3.Name = "firstName";
            gridViewTextBoxColumn3.Width = 97;
            gridViewTextBoxColumn4.FieldName = "Title";
            gridViewTextBoxColumn4.HeaderText = "Title";
            gridViewTextBoxColumn4.Name = "title";
            gridViewTextBoxColumn4.Width = 97;
            gridViewTextBoxColumn5.FieldName = "TitleOfCurtesy";
            gridViewTextBoxColumn5.HeaderText = "Title Of Courtesy";
            gridViewTextBoxColumn5.Name = "titleOfCurtesy";
            gridViewTextBoxColumn5.Width = 97;
            gridViewTextBoxColumn6.FieldName = "BirthDate";
            gridViewTextBoxColumn6.HeaderText = "Birth Date";
            gridViewTextBoxColumn6.Name = "birthDate";
            gridViewTextBoxColumn6.Width = 97;
            gridViewTextBoxColumn7.FieldName = "HireDate";
            gridViewTextBoxColumn7.HeaderText = "Hire Date";
            gridViewTextBoxColumn7.Name = "hireDate";
            gridViewTextBoxColumn7.Width = 97;
            gridViewTextBoxColumn8.FieldName = "Address";
            gridViewTextBoxColumn8.HeaderText = "Address";
            gridViewTextBoxColumn8.Name = "address";
            gridViewTextBoxColumn8.Width = 97;
            gridViewTextBoxColumn9.FieldName = "City";
            gridViewTextBoxColumn9.HeaderText = "City";
            gridViewTextBoxColumn9.Name = "city";
            gridViewTextBoxColumn9.Width = 97;
            gridViewTextBoxColumn10.FieldName = "Region";
            gridViewTextBoxColumn10.HeaderText = "Region";
            gridViewTextBoxColumn10.Name = "Region";
            gridViewTextBoxColumn10.Width = 97;
            gridViewTextBoxColumn11.DataType = typeof(int);
            gridViewTextBoxColumn11.FieldName = "PostalCode";
            gridViewTextBoxColumn11.HeaderText = "Postal Code";
            gridViewTextBoxColumn11.Name = "postalCode";
            gridViewTextBoxColumn11.Width = 72;
            this.radGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11});
            this.radGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView.Name = "radGridView";
            this.radGridView.Size = new System.Drawing.Size(1072, 431);
            this.radGridView.TabIndex = 0;
            this.radGridView.UseWaitCursor = true;
            this.radGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView_CellDoubleClick);
            this.radGridView.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.radGridView_ContextMenuOpening);
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Margin = new System.Windows.Forms.Padding(15);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(1072, 25);
            this.radMenu1.TabIndex = 1;
            this.radMenu1.UseWaitCursor = true;
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.menuAddEmployee,
            this.menuDeleteEmployee,
            this.menuHelp,
            this.menuAbout,
            this.menuExit});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Menu";
            // 
            // menuAddEmployee
            // 
            this.menuAddEmployee.Name = "menuAddEmployee";
            this.menuAddEmployee.Text = "Add Employee";
            this.menuAddEmployee.Click += new System.EventHandler(this.menuAddEmployee_Click);
            // 
            // menuDeleteEmployee
            // 
            this.menuDeleteEmployee.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem2});
            this.menuDeleteEmployee.Name = "menuDeleteEmployee";
            this.menuDeleteEmployee.Text = "Delete Employee";
            this.menuDeleteEmployee.Click += new System.EventHandler(this.menuDeleteEmployee_Click);
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "radMenuItem2";
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Text = "Help";
            this.menuHelp.Click += new System.EventHandler(this.menuHelp_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Text = "Exit ";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // ContextGridView
            // 
            this.ContextGridView.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.menuEdit,
            this.menuDelete});
            // 
            // menuEdit
            // 
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Text = "Edit";
            this.menuEdit.Click += new System.EventHandler(this.menuEdit_Click);
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Text = "Delete";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // radGridViewForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 431);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.radGridView);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "radGridViewForm";
            this.Text = "Rad Grid View";
            this.UseWaitCursor = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem menuAddEmployee;
        private Telerik.WinControls.UI.RadMenuItem menuDeleteEmployee;
        private Telerik.WinControls.UI.RadMenuItem menuExit;
        private Telerik.WinControls.UI.RadContextMenu ContextGridView;
        private Telerik.WinControls.UI.RadMenuItem menuEdit;
        private Telerik.WinControls.UI.RadMenuItem menuDelete;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem menuHelp;
        private Telerik.WinControls.UI.RadMenuItem menuAbout;
    }
}