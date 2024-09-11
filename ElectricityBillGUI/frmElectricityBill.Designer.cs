namespace ElectricityBillGUI
{
    partial class frmElectricityBill
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstCustomers = new ListBox();
            lblCustomers = new Label();
            btnAddCustomer = new Button();
            btnEditCustomer = new Button();
            btnDeleteCustomer = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNumCustomers = new TextBox();
            txtkWhUsed = new TextBox();
            txtAvgBillAmt = new TextBox();
            SuspendLayout();
            // 
            // lstCustomers
            // 
            lstCustomers.Font = new Font("Lucida Console", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstCustomers.FormattingEnabled = true;
            lstCustomers.ItemHeight = 17;
            lstCustomers.Location = new Point(33, 55);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new Size(902, 140);
            lstCustomers.TabIndex = 0;
            // 
            // lblCustomers
            // 
            lblCustomers.AutoSize = true;
            lblCustomers.Location = new Point(33, 32);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(78, 20);
            lblCustomers.TabIndex = 1;
            lblCustomers.Text = "Customers";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(33, 218);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(163, 29);
            btnAddCustomer.TabIndex = 2;
            btnAddCustomer.Text = "&Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Location = new Point(227, 218);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(163, 29);
            btnEditCustomer.TabIndex = 3;
            btnEditCustomer.Text = "&Edit Customer";
            btnEditCustomer.UseVisualStyleBackColor = true;
            btnEditCustomer.Click += btnEditCustomer_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(427, 218);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(163, 29);
            btnDeleteCustomer.TabIndex = 4;
            btnDeleteCustomer.Text = "&Delete Customer";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 283);
            label1.Name = "label1";
            label1.Size = new Size(226, 20);
            label1.TabIndex = 5;
            label1.Text = "Number of customers processed:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 327);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 6;
            label2.Text = "Total number of kWh used:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 370);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 7;
            label3.Text = "Average bill amount:";
            // 
            // txtNumCustomers
            // 
            txtNumCustomers.Enabled = false;
            txtNumCustomers.Location = new Point(265, 280);
            txtNumCustomers.Name = "txtNumCustomers";
            txtNumCustomers.Size = new Size(125, 27);
            txtNumCustomers.TabIndex = 8;
            // 
            // txtkWhUsed
            // 
            txtkWhUsed.Enabled = false;
            txtkWhUsed.Location = new Point(265, 324);
            txtkWhUsed.Name = "txtkWhUsed";
            txtkWhUsed.Size = new Size(125, 27);
            txtkWhUsed.TabIndex = 9;
            // 
            // txtAvgBillAmt
            // 
            txtAvgBillAmt.Enabled = false;
            txtAvgBillAmt.Location = new Point(265, 367);
            txtAvgBillAmt.Name = "txtAvgBillAmt";
            txtAvgBillAmt.Size = new Size(125, 27);
            txtAvgBillAmt.TabIndex = 10;
            // 
            // frmElectricityBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 445);
            Controls.Add(txtAvgBillAmt);
            Controls.Add(txtkWhUsed);
            Controls.Add(txtNumCustomers);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnEditCustomer);
            Controls.Add(btnAddCustomer);
            Controls.Add(lblCustomers);
            Controls.Add(lstCustomers);
            Name = "frmElectricityBill";
            Text = "Electricity Bill App";
            Load += frmElectricityBill_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCustomers;
        private Label lblCustomers;
        private Button btnAddCustomer;
        private Button btnEditCustomer;
        private Button btnDeleteCustomer;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumCustomers;
        private TextBox txtkWhUsed;
        private TextBox txtAvgBillAmt;
    }
}
