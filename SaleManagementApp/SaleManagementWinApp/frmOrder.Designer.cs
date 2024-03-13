namespace SaleManagementWinApp
{
    partial class frmOrder
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
            lbOrderID = new Label();
            txtOrderID = new TextBox();
            lbCustomerID = new Label();
            txtCustomerID = new TextBox();
            lbOrderDate = new Label();
            lbShippedDate = new Label();
            lbTotal = new Label();
            txtTotal = new TextBox();
            lbOrderStatus = new Label();
            dtpOrderDate = new DateTimePicker();
            dtpShippedDate = new DateTimePicker();
            cbOrderStatus = new CheckBox();
            btnSave = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new Point(54, 48);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(66, 20);
            lbOrderID.TabIndex = 0;
            lbOrderID.Text = "Order ID";
            // 
            // txtOrderID
            // 
            txtOrderID.Enabled = false;
            txtOrderID.Location = new Point(126, 45);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(199, 27);
            txtOrderID.TabIndex = 1;
            // 
            // lbCustomerID
            // 
            lbCustomerID.AutoSize = true;
            lbCustomerID.Location = new Point(29, 85);
            lbCustomerID.Name = "lbCustomerID";
            lbCustomerID.Size = new Size(91, 20);
            lbCustomerID.TabIndex = 0;
            lbCustomerID.Text = "Customer ID";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Enabled = false;
            txtCustomerID.Location = new Point(126, 81);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(199, 27);
            txtCustomerID.TabIndex = 1;
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new Point(39, 117);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(83, 20);
            lbOrderDate.TabIndex = 0;
            lbOrderDate.Text = "Order Date";
            // 
            // lbShippedDate
            // 
            lbShippedDate.AutoSize = true;
            lbShippedDate.Location = new Point(24, 153);
            lbShippedDate.Name = "lbShippedDate";
            lbShippedDate.Size = new Size(100, 20);
            lbShippedDate.TabIndex = 0;
            lbShippedDate.Text = "Shipped Date";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(78, 192);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(42, 20);
            lbTotal.TabIndex = 0;
            lbTotal.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(127, 189);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(199, 27);
            txtTotal.TabIndex = 1;
            // 
            // lbOrderStatus
            // 
            lbOrderStatus.AutoSize = true;
            lbOrderStatus.Location = new Point(31, 225);
            lbOrderStatus.Name = "lbOrderStatus";
            lbOrderStatus.Size = new Size(91, 20);
            lbOrderStatus.TabIndex = 0;
            lbOrderStatus.Text = "Order Status";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Enabled = false;
            dtpOrderDate.Location = new Point(126, 117);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(199, 27);
            dtpOrderDate.TabIndex = 2;
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Location = new Point(127, 153);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new Size(198, 27);
            dtpShippedDate.TabIndex = 2;
            // 
            // cbOrderStatus
            // 
            cbOrderStatus.AutoSize = true;
            cbOrderStatus.Location = new Point(128, 225);
            cbOrderStatus.Name = "cbOrderStatus";
            cbOrderStatus.Size = new Size(109, 24);
            cbOrderStatus.TabIndex = 3;
            cbOrderStatus.Text = "is Delivered";
            cbOrderStatus.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(332, 163);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 53);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(332, 45);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 53);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 279);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(cbOrderStatus);
            Controls.Add(dtpShippedDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(lbOrderStatus);
            Controls.Add(txtTotal);
            Controls.Add(lbTotal);
            Controls.Add(lbShippedDate);
            Controls.Add(lbOrderDate);
            Controls.Add(txtCustomerID);
            Controls.Add(lbCustomerID);
            Controls.Add(txtOrderID);
            Controls.Add(lbOrderID);
            Name = "frmOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmOrder";
            Load += frmOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbOrderID;
        private TextBox txtOrderID;
        private Label lbCustomerID;
        private TextBox txtCustomerID;
        private Label lbOrderDate;
        private Label lbShippedDate;
        private Label lbTotal;
        private TextBox txtTotal;
        private Label lbOrderStatus;
        private DateTimePicker dtpOrderDate;
        private DateTimePicker dtpShippedDate;
        private CheckBox cbOrderStatus;
        private Button btnSave;
        private Button btnClose;
    }
}