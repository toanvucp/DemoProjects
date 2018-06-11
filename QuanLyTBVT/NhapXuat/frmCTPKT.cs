using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTBVT.Model;

namespace QuanLyTBVT.NhapXuat
{
    public partial class frmCTPKT : UserControl
    {
        private DBQLVT db = new DBQLVT();
        public frmCTPKT()
        {
            InitializeComponent();
        }

        private void frmCTPKT_Load(object sender, EventArgs e)
        {
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }
    }
}
