using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace Stock
{
    public partial class StockMain : Form
    {
        private int childFormNumber = 0;

        public StockMain()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products pro = new Products();
            pro.MdiParent = this;
            pro.StartPosition = FormStartPosition.CenterScreen;
            pro.Show();
        }

        bool close = true;

        private void StockMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure wawnt to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    close = false;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock sck = new Stock();
            sck.MdiParent = this;
            sck.StartPosition = FormStartPosition.CenterScreen;
            sck.Show();
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm.ProductReport prod = new ReportForm.ProductReport();
            prod.MdiParent = this;
            prod.StartPosition = FormStartPosition.CenterScreen;
            prod.Show();
        }

        private void stockListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm.StockReport strp = new ReportForm.StockReport();
            strp.MdiParent = this;
            strp.StartPosition = FormStartPosition.CenterScreen;
            strp.Show();
        }
    }
}
