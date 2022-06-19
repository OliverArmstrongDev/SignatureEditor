namespace SignatureEditor
{
    partial class MainForm
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
            this.btnAction = new System.Windows.Forms.Button();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtMob = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMob = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.lblExtraTxt = new System.Windows.Forms.Label();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(196, 369);
            this.btnAction.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 23);
            this.btnAction.TabIndex = 9;
            this.btnAction.Text = "Go";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(91, 25);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(180, 20);
            this.txtFname.TabIndex = 0;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(91, 68);
            this.txtLname.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(180, 20);
            this.txtLname.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(91, 154);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(105, 20);
            this.txtPhone.TabIndex = 3;
            // 
            // txtMob
            // 
            this.txtMob.Location = new System.Drawing.Point(91, 197);
            this.txtMob.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.txtMob.Name = "txtMob";
            this.txtMob.Size = new System.Drawing.Size(105, 20);
            this.txtMob.TabIndex = 4;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(91, 240);
            this.txtFax.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(105, 20);
            this.txtFax.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(91, 283);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(34, 28);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(52, 13);
            this.lblFName.TabIndex = 8;
            this.lblFName.Text = "Firstname";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(33, 71);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(53, 13);
            this.lblLName.TabIndex = 9;
            this.lblLName.Text = "Lastname";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(34, 157);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 13);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone (07)";
            // 
            // lblMob
            // 
            this.lblMob.AutoSize = true;
            this.lblMob.Location = new System.Drawing.Point(34, 200);
            this.lblMob.Name = "lblMob";
            this.lblMob.Size = new System.Drawing.Size(38, 13);
            this.lblMob.TabIndex = 11;
            this.lblMob.Text = "Mobile";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(34, 243);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(45, 13);
            this.lblFax.TabIndex = 12;
            this.lblFax.Text = "Fax (07)";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(34, 286);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(34, 114);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(47, 13);
            this.lblJobTitle.TabIndex = 16;
            this.lblJobTitle.Text = "Job Title";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(91, 111);
            this.txtJobTitle.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(180, 20);
            this.txtJobTitle.TabIndex = 2;
            // 
            // lblExtraTxt
            // 
            this.lblExtraTxt.AutoSize = true;
            this.lblExtraTxt.Location = new System.Drawing.Point(34, 329);
            this.lblExtraTxt.Name = "lblExtraTxt";
            this.lblExtraTxt.Size = new System.Drawing.Size(55, 13);
            this.lblExtraTxt.TabIndex = 18;
            this.lblExtraTxt.Text = "Extra Text";
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(91, 326);
            this.txtExtra.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(180, 20);
            this.txtExtra.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnAction;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 413);
            this.Controls.Add(this.lblExtraTxt);
            this.Controls.Add(this.txtExtra);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.lblMob);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtMob);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.btnAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signature Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtMob;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMob;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label lblExtraTxt;
        private System.Windows.Forms.TextBox txtExtra;

    }
}

