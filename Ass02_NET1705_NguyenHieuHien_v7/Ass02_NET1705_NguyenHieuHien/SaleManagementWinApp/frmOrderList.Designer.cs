namespace SaleManagementWinApp
{
    partial class frmOrderList
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
            dgvOrder = new DataGridView();
            pnlSearchByDate = new Panel();
            btnClear = new Button();
            btnReport = new Button();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            lbEndDate = new Label();
            lbStartDate = new Label();
            lbOrder = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            label1 = new Label();
            txttotalAllOrders = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            pnlSearchByDate.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(37, 65);
            dgvOrder.Margin = new Padding(3, 4, 3, 4);
            dgvOrder.MultiSelect = false;
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 24;
            dgvOrder.Size = new Size(811, 752);
            dgvOrder.TabIndex = 0;
            dgvOrder.CellClick += dgvOrder_CellClick;
            // 
            // pnlSearchByDate
            // 
            pnlSearchByDate.Controls.Add(btnClear);
            pnlSearchByDate.Controls.Add(btnReport);
            pnlSearchByDate.Controls.Add(dtpEndDate);
            pnlSearchByDate.Controls.Add(dtpStartDate);
            pnlSearchByDate.Controls.Add(lbEndDate);
            pnlSearchByDate.Controls.Add(lbStartDate);
            pnlSearchByDate.Location = new Point(928, 65);
            pnlSearchByDate.Margin = new Padding(3, 4, 3, 4);
            pnlSearchByDate.Name = "pnlSearchByDate";
            pnlSearchByDate.Size = new Size(496, 188);
            pnlSearchByDate.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(330, 97);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 57);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(330, 19);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(125, 57);
            btnReport.TabIndex = 8;
            btnReport.Text = "Search";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(111, 108);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(175, 27);
            dtpEndDate.TabIndex = 7;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(111, 29);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(175, 27);
            dtpStartDate.TabIndex = 6;
            // 
            // lbEndDate
            // 
            lbEndDate.AutoSize = true;
            lbEndDate.Location = new Point(42, 108);
            lbEndDate.Name = "lbEndDate";
            lbEndDate.Size = new Size(70, 20);
            lbEndDate.TabIndex = 5;
            lbEndDate.Text = "End Date";
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Location = new Point(38, 29);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new Size(76, 20);
            lbStartDate.TabIndex = 4;
            lbStartDate.Text = "Start Date";
            // 
            // lbOrder
            // 
            lbOrder.AutoSize = true;
            lbOrder.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbOrder.Location = new Point(37, 12);
            lbOrder.Name = "lbOrder";
            lbOrder.Size = new Size(113, 46);
            lbOrder.TabIndex = 4;
            lbOrder.Text = "Order";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1039, 328);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(206, 64);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update Order";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1039, 464);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(206, 64);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Order";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1039, 616);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(206, 64);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(627, 841);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 9;
            label1.Text = "Total All Orders";
            // 
            // txttotalAllOrders
            // 
            txttotalAllOrders.Location = new Point(745, 838);
            txttotalAllOrders.Name = "txttotalAllOrders";
            txttotalAllOrders.ReadOnly = true;
            txttotalAllOrders.Size = new Size(125, 27);
            txttotalAllOrders.TabIndex = 10;
            // 
            // frmOrderList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1459, 884);
            Controls.Add(txttotalAllOrders);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(lbOrder);
            Controls.Add(pnlSearchByDate);
            Controls.Add(dgvOrder);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmOrderList";
            Text = "frmOrderList";
            Load += frmOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            pnlSearchByDate.ResumeLayout(false);
            pnlSearchByDate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrder;
        private Panel pnlSearchByDate;
        private Label lbOrder;
        private Button btnClear;
        private Button btnReport;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Label lbEndDate;
        private Label lbStartDate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private Label label1;
        private TextBox txttotalAllOrders;
    }
}