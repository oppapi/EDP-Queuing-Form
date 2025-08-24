using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        private CashierWindowQueue window;

        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass(); 
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            if (window == null || window.IsDisposed)  
            {
                window = new CashierWindowQueue();
                window.Show();
            }
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}
