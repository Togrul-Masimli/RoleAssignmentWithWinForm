namespace RoleAssignmentApp
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.editorNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.editorPasswordBox = new System.Windows.Forms.TextBox();
            this.labelpas = new System.Windows.Forms.Label();
            this.createCheck = new System.Windows.Forms.CheckBox();
            this.readCheck = new System.Windows.Forms.CheckBox();
            this.updateCheck = new System.Windows.Forms.CheckBox();
            this.deleteCheck = new System.Windows.Forms.CheckBox();
            this.addEditorBrn = new System.Windows.Forms.Button();
            this.showEditorBtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(163, 91);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(100, 22);
            this.usernameBox.TabIndex = 1;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(163, 155);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 22);
            this.emailBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(163, 224);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 22);
            this.passwordBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(163, 278);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 41);
            this.UpdateBtn.TabIndex = 6;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add Editor";
            // 
            // editorNameBox
            // 
            this.editorNameBox.Location = new System.Drawing.Point(586, 88);
            this.editorNameBox.Name = "editorNameBox";
            this.editorNameBox.Size = new System.Drawing.Size(124, 22);
            this.editorNameBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Editor Name:";
            // 
            // editorPasswordBox
            // 
            this.editorPasswordBox.Location = new System.Drawing.Point(584, 128);
            this.editorPasswordBox.Name = "editorPasswordBox";
            this.editorPasswordBox.Size = new System.Drawing.Size(126, 22);
            this.editorPasswordBox.TabIndex = 11;
            // 
            // labelpas
            // 
            this.labelpas.AutoSize = true;
            this.labelpas.Location = new System.Drawing.Point(460, 128);
            this.labelpas.Name = "labelpas";
            this.labelpas.Size = new System.Drawing.Size(114, 17);
            this.labelpas.TabIndex = 10;
            this.labelpas.Text = "Editor Password:";
            // 
            // createCheck
            // 
            this.createCheck.AutoSize = true;
            this.createCheck.Location = new System.Drawing.Point(463, 187);
            this.createCheck.Name = "createCheck";
            this.createCheck.Size = new System.Drawing.Size(101, 21);
            this.createCheck.TabIndex = 12;
            this.createCheck.Text = "Can Create";
            this.createCheck.UseVisualStyleBackColor = true;
            // 
            // readCheck
            // 
            this.readCheck.AutoSize = true;
            this.readCheck.Location = new System.Drawing.Point(586, 187);
            this.readCheck.Name = "readCheck";
            this.readCheck.Size = new System.Drawing.Size(93, 21);
            this.readCheck.TabIndex = 13;
            this.readCheck.Text = "Can Read";
            this.readCheck.UseVisualStyleBackColor = true;
            // 
            // updateCheck
            // 
            this.updateCheck.AutoSize = true;
            this.updateCheck.Location = new System.Drawing.Point(463, 226);
            this.updateCheck.Name = "updateCheck";
            this.updateCheck.Size = new System.Drawing.Size(105, 21);
            this.updateCheck.TabIndex = 14;
            this.updateCheck.Text = "Can Update";
            this.updateCheck.UseVisualStyleBackColor = true;
            // 
            // deleteCheck
            // 
            this.deleteCheck.AutoSize = true;
            this.deleteCheck.Location = new System.Drawing.Point(586, 226);
            this.deleteCheck.Name = "deleteCheck";
            this.deleteCheck.Size = new System.Drawing.Size(100, 21);
            this.deleteCheck.TabIndex = 15;
            this.deleteCheck.Text = "Can Delete";
            this.deleteCheck.UseVisualStyleBackColor = true;
            // 
            // addEditorBrn
            // 
            this.addEditorBrn.Location = new System.Drawing.Point(509, 278);
            this.addEditorBrn.Name = "addEditorBrn";
            this.addEditorBrn.Size = new System.Drawing.Size(96, 41);
            this.addEditorBrn.TabIndex = 16;
            this.addEditorBrn.Text = "Add Editor";
            this.addEditorBrn.UseVisualStyleBackColor = true;
            this.addEditorBrn.Click += new System.EventHandler(this.addEditorBrn_Click);
            // 
            // showEditorBtn
            // 
            this.showEditorBtn.Location = new System.Drawing.Point(347, 358);
            this.showEditorBtn.Name = "showEditorBtn";
            this.showEditorBtn.Size = new System.Drawing.Size(118, 36);
            this.showEditorBtn.TabIndex = 17;
            this.showEditorBtn.Text = "Show Editors";
            this.showEditorBtn.UseVisualStyleBackColor = true;
            this.showEditorBtn.Click += new System.EventHandler(this.showEditorBtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(86, 30);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(111, 17);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login as Editor?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.showEditorBtn);
            this.Controls.Add(this.addEditorBrn);
            this.Controls.Add(this.deleteCheck);
            this.Controls.Add(this.updateCheck);
            this.Controls.Add(this.readCheck);
            this.Controls.Add(this.createCheck);
            this.Controls.Add(this.editorPasswordBox);
            this.Controls.Add(this.labelpas);
            this.Controls.Add(this.editorNameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox editorNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox editorPasswordBox;
        private System.Windows.Forms.Label labelpas;
        private System.Windows.Forms.CheckBox createCheck;
        private System.Windows.Forms.CheckBox readCheck;
        private System.Windows.Forms.CheckBox updateCheck;
        private System.Windows.Forms.CheckBox deleteCheck;
        private System.Windows.Forms.Button addEditorBrn;
        private System.Windows.Forms.Button showEditorBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}