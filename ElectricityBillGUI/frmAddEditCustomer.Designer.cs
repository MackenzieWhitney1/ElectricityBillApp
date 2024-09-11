namespace ElectricityBillGUI
{
    partial class frmAddEditCustomer
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtkWhUsed = new TextBox();
            btnAddEdit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(11, 70);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(18, 109);
            label3.Name = "label3";
            label3.Size = new Size(105, 28);
            label3.TabIndex = 2;
            label3.Text = "kWh Used:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F);
            txtFirstName.Location = new Point(118, 31);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(250, 34);
            txtFirstName.TabIndex = 3;
            txtFirstName.Tag = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F);
            txtLastName.Location = new Point(118, 72);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(250, 34);
            txtLastName.TabIndex = 4;
            txtLastName.Tag = "Last Name";
            // 
            // txtkWhUsed
            // 
            txtkWhUsed.Font = new Font("Segoe UI", 12F);
            txtkWhUsed.Location = new Point(120, 114);
            txtkWhUsed.Name = "txtkWhUsed";
            txtkWhUsed.Size = new Size(125, 34);
            txtkWhUsed.TabIndex = 5;
            txtkWhUsed.Tag = "kWh Used";
            // 
            // btnAddEdit
            // 
            btnAddEdit.Font = new Font("Segoe UI", 12F);
            btnAddEdit.Location = new Point(51, 158);
            btnAddEdit.Name = "btnAddEdit";
            btnAddEdit.Size = new Size(124, 36);
            btnAddEdit.TabIndex = 6;
            btnAddEdit.Text = "Text";
            btnAddEdit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(190, 158);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(124, 36);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddEditCustomer
            // 
            AcceptButton = btnAddEdit;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(395, 218);
            Controls.Add(btnCancel);
            Controls.Add(btnAddEdit);
            Controls.Add(txtkWhUsed);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddEditCustomer";
            Text = "Title";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtkWhUsed;
        private Button btnAddEdit;
        private Button btnCancel;
    }
}