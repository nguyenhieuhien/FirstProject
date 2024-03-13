using BusinessObjects.Model;
using Repositories.Repository;
using System.Diagnostics;
using System.Security.Policy;

namespace SaleManagementWinApp
{
    public partial class frmLogin : Form
    {
        private ICustomerRepository customerRepository;

        public frmLogin()
        {
            customerRepository = new CustomerRepository();
            InitializeComponent();
            btnLogin.Visible = false;
            btnDelete.Visible = false;
            txtEmail.TextChanged += TxtEmailPassword_TextChanged;
            txtPassword.TextChanged += TxtEmailPassword_TextChanged;
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Customer? customer = customerRepository.CheckLogin(txtEmail.Text, txtPassword.Text);
            (string, string) adminAccount = customerRepository.checkLoginAdmin();


            if (customer != null && customer.CustomerStatus != 0)
            {
                frmMain frmMain = new frmMain()
                {
                    Customer = customer,
                    isAdmin = false
                };
                this.Hide();
                frmMain.ShowDialog();
                this.Visible = true;
                txtEmail.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
            else if (txtEmail.Text.Equals(adminAccount.Item1) && txtPassword.Text.Equals(adminAccount.Item2))
            {
                frmMain frmMain = new frmMain()
                {
                    Customer = null,
                    isAdmin = true
                };
                this.Hide();
                frmMain.ShowDialog();
                this.Visible = true;
                txtEmail.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Email or password is incorrect", "Cannot log in", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtPassword.Clear();
            btnLogin.Visible = false;
            btnDelete.Visible = false;
        }
        private void TxtEmailPassword_TextChanged(object sender, EventArgs e)
        {
            bool hasInput = !string.IsNullOrEmpty(txtEmail.Text) || !string.IsNullOrEmpty(txtPassword.Text);
            btnLogin.Visible = hasInput;
            btnDelete.Visible = hasInput;
        }

    }
}
