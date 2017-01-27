using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jewellery_Solution
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Master_Entry.FrmCustomerMaster Frm = new Master_Entry.FrmCustomerMaster();
            PnlControll.Controls.Clear();
            PnlControll.Controls.Add(Frm);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Master_Entry.SupplierMaster Frm = new Master_Entry.SupplierMaster();
            PnlControll.Controls.Clear();
            PnlControll.Controls.Add(Frm);
        }
    }
}
