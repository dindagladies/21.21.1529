using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void countingNumber (int index, int a, int b)
        {
            var calculator = new Calculator();

            if (index == 0)
            {
                result.Items.Add(string.Format("Hasil Penjumlahan {0} + {1} = {2}", a, b, calculator.Penambahan(a, b)));

            }
            
            if (index == 1)
            {
                result.Items.Add(string.Format("Hasil Pengurangan {0} - {1} = {2}", a, b, calculator.Pengurangan(a, b)));

            }
            
            if (index == 2)
            {
                result.Items.Add(string.Format("Hasil Perkalian {0} * {1} = {2}", a, b, calculator.Perkalian(a, b)));

            }
            
            if (index == 3)
            {
                result.Items.Add(string.Format("Hasil Pembagian {0} / {1} = {2}", a, b, calculator.Pembagian(a, b)));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEntryCalculator proses = new FrmEntryCalculator();

            proses.onCounting += countingNumber;
            proses.ShowDialog();
        }
    }
}
