namespace SaleManagementWinApp
{
    partial class frmOrderDetail
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
            dgvOrderDetail = new DataGridView();
            btnClose = new Button();
            lblTotalQuantity = new Label();
            lbTotalPrice = new Label();
            txtTotalQuantity = new TextBox();
            txtTotalPrice = new TextBox();
            txtPrice1 = new TextBox();
            txtQuantity1 = new TextBox();
            txtQuantity = new Label();
            txtPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(0, 1);
            dgvOrderDetail.Margin = new Padding(3, 4, 3, 4);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.RowHeadersWidth = 51;
            dgvOrderDetail.Size = new Size(687, 599);
            dgvOrderDetail.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(742, 467);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(146, 89);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTotalQuantity
            // 
            lblTotalQuantity.AutoSize = true;
            lblTotalQuantity.Location = new Point(693, 190);
            lblTotalQuantity.Name = "lblTotalQuantity";
            lblTotalQuantity.Size = new Size(102, 20);
            lblTotalQuantity.TabIndex = 2;
            lblTotalQuantity.Text = "Total Quantity";
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.AutoSize = true;
            lbTotalPrice.Location = new Point(693, 281);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(78, 20);
            lbTotalPrice.TabIndex = 3;
            lbTotalPrice.Text = "Total Price";
            // 
            // txtTotalQuantity
            // 
            txtTotalQuantity.Location = new Point(764, 214);
            txtTotalQuantity.Margin = new Padding(3, 4, 3, 4);
            txtTotalQuantity.Name = "txtTotalQuantity";
            txtTotalQuantity.ReadOnly = true;
            txtTotalQuantity.Size = new Size(114, 27);
            txtTotalQuantity.TabIndex = 4;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(764, 305);
            txtTotalPrice.Margin = new Padding(3, 4, 3, 4);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(114, 27);
            txtTotalPrice.TabIndex = 5;
            // 
            // txtPrice1
            // 
            txtPrice1.Location = new Point(764, 103);
            txtPrice1.Margin = new Padding(3, 4, 3, 4);
            txtPrice1.Name = "txtPrice1";
            txtPrice1.ReadOnly = true;
            txtPrice1.Size = new Size(114, 27);
            txtPrice1.TabIndex = 6;
            // 
            // txtQuantity1
            // 
            txtQuantity1.Location = new Point(764, 25);
            txtQuantity1.Margin = new Padding(3, 4, 3, 4);
            txtQuantity1.Name = "txtQuantity1";
            txtQuantity1.ReadOnly = true;
            txtQuantity1.Size = new Size(114, 27);
            txtQuantity1.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.AutoSize = true;
            txtQuantity.Location = new Point(693, 25);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(65, 20);
            txtQuantity.TabIndex = 8;
            txtQuantity.Text = "Quantity";
            // 
            // txtPrice
            // 
            txtPrice.AutoSize = true;
            txtPrice.Location = new Point(707, 106);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(41, 20);
            txtPrice.TabIndex = 9;
            txtPrice.Text = "Price";
            // 
            // frmOrderDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtQuantity1);
            Controls.Add(txtPrice1);
            Controls.Add(txtTotalPrice);
            Controls.Add(txtTotalQuantity);
            Controls.Add(lbTotalPrice);
            Controls.Add(lblTotalQuantity);
            Controls.Add(btnClose);
            Controls.Add(dgvOrderDetail);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmOrderDetail";
            Text = "frmOrderDetail";
            Load += frmOrderDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrderDetail;
        private Button btnClose;
        private Label lblTotalQuantity;
        private Label lbTotalPrice;
        private TextBox txtTotalQuantity;
        private TextBox txtTotalPrice;
        private TextBox txtPrice1;
        private TextBox txtQuantity1;
        private Label txtQuantity;
        private Label txtPrice;
    }
}