using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class FrmEntryCalculator : Form
    {
        public delegate void CreateUpdateEventHandler(int index,int nilaiA, int nilaiB);

        public event CreateUpdateEventHandler onCounting;

        public FrmEntryCalculator()
        {
            InitializeComponent();

            operation.Items.Add("Penjumlahan");
            operation.Items.Add("Pengurangan");
            operation.Items.Add("Perkalian");
            operation.Items.Add("Pembagian");

            operation.SelectedIndex = 0;
            operation.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        
        private void btnProses_Click(object sender, EventArgs e)
        {
            int nilaiA = int.Parse(txtNilaiA.Text);
            int nilaiB = int.Parse(txtNilaiB.Text);

            if (operation.SelectedIndex == 0)
            {
                onCounting(0, nilaiA, nilaiB);
            }

            if (operation.SelectedIndex == 1)
            {
                onCounting(1, nilaiA, nilaiB);
            }
            if (operation.SelectedIndex == 2)
            {
                onCounting(2, nilaiA, nilaiB);
            }

            if (operation.SelectedIndex == 3)
            {
                onCounting(3, nilaiA, nilaiB);
            }
        }
    }
}
