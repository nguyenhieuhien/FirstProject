using Repositories.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmOrderDetail : Form
    {
        private int orderID;

        private IOrderDetailRepository OrderDetailRepository;

        private decimal totalPrice;

        private int totalQuantity;

        public frmOrderDetail(int orderID)
        {
            InitializeComponent();
            OrderDetailRepository = new OrderDetailRepository();
            this.orderID = orderID;
        }

        private void LoadOrderDetail()
        {
            var orderDetails = OrderDetailRepository.GetOrderDetailByOrderID(orderID)
                                .Select(c => new
                                {
                                    c.OrderId,
                                    FlowerBouquetName = c.FlowerBouquet.FlowerBouquetName,
                                    c.UnitPrice,
                                    c.Quantity,
                                    c.Discount
                                }).ToList();

            dgvOrderDetail.DataSource = orderDetails;
            totalPrice = orderDetails.Sum(c => c.UnitPrice * c.Quantity);
            totalQuantity = orderDetails.Sum(c => c.Quantity);
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            LoadOrderDetail();
            txtTotalQuantity.Text = totalQuantity.ToString();
            txtTotalPrice.Text = totalPrice.ToString();

            
            dgvOrderDetail.CellClick += DgvOrderDetail_CellClick;
        }

        private void DgvOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvOrderDetail.Rows[e.RowIndex];

                object unitPriceObj = row.Cells["UnitPrice"].Value;
                object quantityObj = row.Cells["Quantity"].Value;

                if (unitPriceObj != null && quantityObj != null &&
                    decimal.TryParse(unitPriceObj.ToString(), out decimal unitPrice) &&
                    int.TryParse(quantityObj.ToString(), out int quantity))
                {
                    decimal totalPrice = unitPrice * quantity;
                    txtPrice1.Text = totalPrice.ToString("N2"); 
                }
                else
                {
                    txtPrice1.Text = "Invalid data";
                }

                txtQuantity1.Text = quantityObj?.ToString() ?? "Error";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
