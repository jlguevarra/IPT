using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermExamIPT
{

    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
      
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();

        }
        

        public class CashierClass
    {
        private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue;

        public CashierClass()
        {
            x = 10000;
            CashierQueue = new Queue<string>();
        }

        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }
    }





    private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            CashierWindowQueue form2 = new CashierWindowQueue();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
    }
}
