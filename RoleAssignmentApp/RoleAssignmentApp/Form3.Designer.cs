namespace RoleAssignmentApp
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.editorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canCreateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.canReadDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.canUpdateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.canDeleteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.editorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleAssignmentAppDBDataSet = new RoleAssignmentApp.RoleAssignmentAppDBDataSet();
            this.editorsTableAdapter = new RoleAssignmentApp.RoleAssignmentAppDBDataSetTableAdapters.EditorsTableAdapter();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.editorNameBox = new System.Windows.Forms.TextBox();
            this.editorPasswordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createCheck = new System.Windows.Forms.CheckBox();
            this.readCheck = new System.Windows.Forms.CheckBox();
            this.updateCheck = new System.Windows.Forms.CheckBox();
            this.deleteCheck = new System.Windows.Forms.CheckBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleAssignmentAppDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editors:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editorIdDataGridViewTextBoxColumn,
            this.editorNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.canCreateDataGridViewCheckBoxColumn,
            this.canReadDataGridViewCheckBoxColumn,
            this.canUpdateDataGridViewCheckBoxColumn,
            this.canDeleteDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.editorsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(928, 267);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // editorIdDataGridViewTextBoxColumn
            // 
            this.editorIdDataGridViewTextBoxColumn.DataPropertyName = "EditorId";
            this.editorIdDataGridViewTextBoxColumn.HeaderText = "EditorId";
            this.editorIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.editorIdDataGridViewTextBoxColumn.Name = "editorIdDataGridViewTextBoxColumn";
            this.editorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.editorIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // editorNameDataGridViewTextBoxColumn
            // 
            this.editorNameDataGridViewTextBoxColumn.DataPropertyName = "EditorName";
            this.editorNameDataGridViewTextBoxColumn.HeaderText = "EditorName";
            this.editorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.editorNameDataGridViewTextBoxColumn.Name = "editorNameDataGridViewTextBoxColumn";
            this.editorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.editorNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // canCreateDataGridViewCheckBoxColumn
            // 
            this.canCreateDataGridViewCheckBoxColumn.DataPropertyName = "CanCreate";
            this.canCreateDataGridViewCheckBoxColumn.HeaderText = "CanCreate";
            this.canCreateDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.canCreateDataGridViewCheckBoxColumn.Name = "canCreateDataGridViewCheckBoxColumn";
            this.canCreateDataGridViewCheckBoxColumn.ReadOnly = true;
            this.canCreateDataGridViewCheckBoxColumn.Width = 125;
            // 
            // canReadDataGridViewCheckBoxColumn
            // 
            this.canReadDataGridViewCheckBoxColumn.DataPropertyName = "CanRead";
            this.canReadDataGridViewCheckBoxColumn.HeaderText = "CanRead";
            this.canReadDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.canReadDataGridViewCheckBoxColumn.Name = "canReadDataGridViewCheckBoxColumn";
            this.canReadDataGridViewCheckBoxColumn.ReadOnly = true;
            this.canReadDataGridViewCheckBoxColumn.Width = 125;
            // 
            // canUpdateDataGridViewCheckBoxColumn
            // 
            this.canUpdateDataGridViewCheckBoxColumn.DataPropertyName = "CanUpdate";
            this.canUpdateDataGridViewCheckBoxColumn.HeaderText = "CanUpdate";
            this.canUpdateDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.canUpdateDataGridViewCheckBoxColumn.Name = "canUpdateDataGridViewCheckBoxColumn";
            this.canUpdateDataGridViewCheckBoxColumn.ReadOnly = true;
            this.canUpdateDataGridViewCheckBoxColumn.Width = 125;
            // 
            // canDeleteDataGridViewCheckBoxColumn
            // 
            this.canDeleteDataGridViewCheckBoxColumn.DataPropertyName = "CanDelete";
            this.canDeleteDataGridViewCheckBoxColumn.HeaderText = "CanDelete";
            this.canDeleteDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.canDeleteDataGridViewCheckBoxColumn.Name = "canDeleteDataGridViewCheckBoxColumn";
            this.canDeleteDataGridViewCheckBoxColumn.ReadOnly = true;
            this.canDeleteDataGridViewCheckBoxColumn.Width = 125;
            // 
            // editorsBindingSource
            // 
            this.editorsBindingSource.DataMember = "Editors";
            this.editorsBindingSource.DataSource = this.roleAssignmentAppDBDataSet;
            // 
            // roleAssignmentAppDBDataSet
            // 
            this.roleAssignmentAppDBDataSet.DataSetName = "RoleAssignmentAppDBDataSet";
            this.roleAssignmentAppDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editorsTableAdapter
            // 
            this.editorsTableAdapter.ClearBeforeFill = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(42, 29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(39, 17);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // editorNameBox
            // 
            this.editorNameBox.Location = new System.Drawing.Point(100, 395);
            this.editorNameBox.Name = "editorNameBox";
            this.editorNameBox.Size = new System.Drawing.Size(121, 22);
            this.editorNameBox.TabIndex = 4;
            // 
            // editorPasswordBox
            // 
            this.editorPasswordBox.Location = new System.Drawing.Point(330, 392);
            this.editorPasswordBox.Name = "editorPasswordBox";
            this.editorPasswordBox.Size = new System.Drawing.Size(121, 22);
            this.editorPasswordBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // createCheck
            // 
            this.createCheck.AutoSize = true;
            this.createCheck.Location = new System.Drawing.Point(490, 392);
            this.createCheck.Name = "createCheck";
            this.createCheck.Size = new System.Drawing.Size(101, 21);
            this.createCheck.TabIndex = 7;
            this.createCheck.Text = "Can Create";
            this.createCheck.UseVisualStyleBackColor = true;
            // 
            // readCheck
            // 
            this.readCheck.AutoSize = true;
            this.readCheck.Location = new System.Drawing.Point(594, 391);
            this.readCheck.Name = "readCheck";
            this.readCheck.Size = new System.Drawing.Size(93, 21);
            this.readCheck.TabIndex = 8;
            this.readCheck.Text = "Can Read";
            this.readCheck.UseVisualStyleBackColor = true;
            // 
            // updateCheck
            // 
            this.updateCheck.AutoSize = true;
            this.updateCheck.Location = new System.Drawing.Point(698, 391);
            this.updateCheck.Name = "updateCheck";
            this.updateCheck.Size = new System.Drawing.Size(105, 21);
            this.updateCheck.TabIndex = 9;
            this.updateCheck.Text = "Can Update";
            this.updateCheck.UseVisualStyleBackColor = true;
            // 
            // deleteCheck
            // 
            this.deleteCheck.AutoSize = true;
            this.deleteCheck.Location = new System.Drawing.Point(802, 391);
            this.deleteCheck.Name = "deleteCheck";
            this.deleteCheck.Size = new System.Drawing.Size(100, 21);
            this.deleteCheck.TabIndex = 10;
            this.deleteCheck.Text = "Can Delete";
            this.deleteCheck.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(267, 435);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(90, 39);
            this.createBtn.TabIndex = 11;
            this.createBtn.Text = "Add";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(445, 435);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(85, 39);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(627, 435);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(83, 39);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(28, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "<";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 510);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.deleteCheck);
            this.Controls.Add(this.updateCheck);
            this.Controls.Add(this.readCheck);
            this.Controls.Add(this.createCheck);
            this.Controls.Add(this.editorPasswordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editorNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleAssignmentAppDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RoleAssignmentAppDBDataSet roleAssignmentAppDBDataSet;
        private System.Windows.Forms.BindingSource editorsBindingSource;
        private RoleAssignmentAppDBDataSetTableAdapters.EditorsTableAdapter editorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canCreateDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canReadDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canUpdateDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canDeleteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editorNameBox;
        private System.Windows.Forms.TextBox editorPasswordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox createCheck;
        private System.Windows.Forms.CheckBox readCheck;
        private System.Windows.Forms.CheckBox updateCheck;
        private System.Windows.Forms.CheckBox deleteCheck;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label4;
    }
}