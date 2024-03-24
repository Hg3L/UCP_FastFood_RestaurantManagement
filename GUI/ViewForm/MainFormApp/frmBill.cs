using BLL;
using DTO;
using GUI.ViewForm.MainFormApp.UserControls;

namespace GUI.ViewForm.MainFormApp
{
    public partial class frmBill : Form
    {
        private List<Bill> billList;
        private List<Bill>? filterBillList;
        public static FlowLayoutPanel _flpanelBill;

        public frmBill()
        {
            InitializeComponent();
            dtpDate.Value = DateTime.Now;
            _flpanelBill = flpanelBill;
            LoadBills();
            LoadBillCard();
        }

        private void LoadBills()
        {
            billList = BillBLL.Instance().SelectAllBills();
        }

        private void LoadBillCard()
        {
            billList.ForEach(bill =>
            {
                flpanelBill.Controls.Add(new ucBill(bill));
            });
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            flpanelBill.Controls.Clear();
            filterBillList = BillBLL.Instance().
                FilterBills(txtFrom.Text.Trim(), txtTo.Text.Trim(), 
                dtpDate.Value, billList);


            filterBillList?.ForEach(bill =>
            {
                flpanelBill.Controls.Add(new ucBill(bill));
            });
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            flpanelBill.Controls.Clear();
            txtFrom.Text = "";
            txtTo.Text = "";
            dtpDate.Value = DateTime.Now;
            LoadBillCard();
        }
    }
}
