using System;

using System.Windows.Forms;
using Banking;
using Taxation;
using Policiy;
using Subsidy;
using Contract;
namespace SarkarApp
{
    public partial class lblTaxMsg : Form
    {
        
        Account acct=null;

        public lblTaxMsg()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            acct = new Account();
            acct.OverBalance += new Operation(Tax.PayITax);
            acct.OverBalance += new Operation(Tax.PayGST);
            acct.OverBalance += new Operation(Tax.PayProfessionalTax);
            acct.UnderBalance += new Operation(Welfare.AddAllowance);
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {

            double initialBalance = double.Parse(txtBalance.Text);
            double amount = double.Parse(txtAmount.Text);
            IAccount iacct = acct;
            iacct.Balance = initialBalance;

            acct.Withdraw(amount);

            double remBalance = iacct.Balance;
            lblMsgBalance.Text = remBalance.ToString();

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            double initialBalance = double.Parse(txtBalance.Text);
            double amount = double.Parse(txtAmount.Text);
            IAccount iacct = acct;
            iacct.Balance = initialBalance;

            acct.Deposit(amount);

            double remBalance = iacct.Balance;
            lblMsgBalance.Text = remBalance.ToString();
        }

       
    }
}
