using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MzansiPayrollSystem
{
    public partial class FrmPayroll : Form
    {
        public FrmPayroll()
        {
            InitializeComponent();
        }


        private void lblMembership_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            PayrollCalculator calc = new PayrollCalculator();

            // INPUTS
            string name = txtContractorName.Text;
            double hours = Convert.ToDouble(txtHoursWorked.Text);
            int dependents = Convert.ToInt32(txtDependents.Text);

            if (string.IsNullOrWhiteSpace(txtContractorName.Text))
            {
                MessageBox.Show("Enter contractor name");
                return;
            }

            if (!double.TryParse(txtHoursWorked.Text, out double hoursWorked) || hours < 0)
            {
                MessageBox.Show("Invalid hours worked");
                return;
            }

            if (!int.TryParse(txtDependents.Text, out int numberOfdependents) || dependents < 0 || dependents > 10)
            {
                MessageBox.Show("Dependents must be 0–10");
                return;
            }

            // CALCULATIONS
            double gross = calc.CalculateGrossPay(hours);
            double uif = calc.CalculateUIFDeduction(gross);
            double membership = calc.CalculateMembershipFee(gross);
            double paye = calc.CalculatePAYEDeduction(gross, dependents);
            double totalDeductions = calc.CalculateTotalDeductions(uif, paye, membership);
            double net = calc.CalculateNetPay(gross, uif, paye, membership);

            // OUTPUT
            txtGrossPay.Text = gross.ToString("0.00");
            txtUIF.Text = uif.ToString("0.00");
            txtPAYE.Text = paye.ToString("0.00");
            txtMembership.Text = membership.ToString("0.00");
            txtTotalDeductions.Text = totalDeductions.ToString("0.00");
            txtNetPay.Text = net.ToString("0.00");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtContractorName.Clear();
            txtHoursWorked.Clear();
            txtDependents.Clear();

            txtGrossPay.Clear();
            txtUIF.Clear();
            txtPAYE.Clear();
            txtMembership.Clear();
            txtTotalDeductions.Clear();
            txtNetPay.Clear();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
