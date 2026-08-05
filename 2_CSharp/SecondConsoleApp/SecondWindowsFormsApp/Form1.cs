using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondWindowsFormsApp
{
    public partial class gggg : Form
    {
        public gggg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int num1 = int.Parse(txtnum1.Text);
            int num2 = int.Parse(txtnum2.Text);

            int sum = AddNumbers(num1, num2);

            MessageBox.Show("The sum is: " + sum, "Result");


        }
        private  int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
