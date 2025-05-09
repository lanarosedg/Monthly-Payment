using System.Diagnostics.Contracts;

namespace Real_Estate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int unit1Price = 3300000;
        public int unit2Price = 2100000;
        public int unit3Price = 4600000;

        public class PaymentCalculation()
        {

            public double Months { get; set; }
            public double CalculatePayment(double price, double months)
            {
                double monthlyPayment = price / months;
                return monthlyPayment;
            }
        }

        public class Unit1MonthlyPayment : PaymentCalculation
        {

        }

        public class Unit2MonthlyPayment : PaymentCalculation
        {

        }

        public class Unit3MonthlyPayment : PaymentCalculation
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Unit1MonthlyPayment unit1MonthlyPayment = new Unit1MonthlyPayment();
            Unit2MonthlyPayment unit2MonthlyPayment = new Unit2MonthlyPayment();
            Unit3MonthlyPayment unit3MonthlyPayment = new Unit3MonthlyPayment();

            unit1MonthlyPayment.Months = unit1Price;
            unit2MonthlyPayment.Months = unit2Price;
            unit3MonthlyPayment.Months = unit3Price;

            double months = Convert.ToDouble(monthsTextBox.Text);

            amountPerMonth1.Text = "Monthly Payment: \n"
                + unit1MonthlyPayment.CalculatePayment(unit1Price, months).ToString("C");
            amountPerMonth2.Text = "Monthly Payment: \n"
                + unit2MonthlyPayment.CalculatePayment(unit2Price, months).ToString("C");
            amountPerMonth3.Text = "Monthly Payment: \n"
                + unit3MonthlyPayment.CalculatePayment(unit3Price, months).ToString("C");
        }
    }
}
