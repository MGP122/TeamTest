using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Jewellery_Solution.Master_Entry
{
    public partial class FrmCustomerMaster : DevExpress.XtraEditors.XtraUserControl
    {
        public FrmCustomerMaster()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Master_Entry.FrmWebCam Frm = new FrmWebCam();
            Frm.ShowDialog();
        }
    }
}
