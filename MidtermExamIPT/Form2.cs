using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MidtermExamIPT.QueuingForm;

namespace MidtermExamIPT
{
    public partial class CashierWindowQueue : Form
    {
        public CashierWindowQueue()
        {
            InitializeComponent();
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCasahierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCasahierQueue.Items.Add(obj.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)

        {
            DisplayCashierQueue(CashierClass.CashierQueue);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            QueuingForm form = new QueuingForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listCasahierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listCasahierQueue_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
