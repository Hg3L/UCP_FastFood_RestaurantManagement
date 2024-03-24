using BLL;
using DTO;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;

using Color = System.Windows.Media.Color;

namespace GUI.ViewForm.MainFormApp
{
    public partial class frmStatistic : Form
    {
        private decimal Yesterday_Income;

        private decimal Today_Income;

        private decimal Total_Income;

        private bool IsValidTypeAccount;

        private Dictionary<int, decimal> MapIncomeWithMonth;

        private Dictionary<string, int> MapNameFoodWithQuantity;

        public static int numTopSelling = 5;

        // Mảng chứa màu sắc tương ứng với từng phần trên biểu đồ
        private Color[] pieColors =
        {
            Color.FromRgb(230, 92, 94), // Đỏ hồng
            Color.FromRgb(0, 184, 196), // Xanh lơ
            Color.FromRgb(249, 213, 137), // Vàng nhạt
            Color.FromRgb(173, 123, 233), // Cam nhạt
            Color.FromRgb(250, 173, 143) // Tím nhạt
        };

        public frmStatistic()
        {
            InitializeComponent();
            Decentralization();
            LoadYesterdayIncome();
            LoadTodayIncome();
            LoadTotalIncome();
            LoadDictionaryIncomeList();
            LoadDictionaryTopSellingList();
            LoadPie();
            LoadLineChart();
        }

        private void LoadDictionaryIncomeList()
        {
            MapIncomeWithMonth = StatisticBLL.Instance().SelectIncomeByMonth(DateTime.Now.Year);
        }

        private void LoadDictionaryTopSellingList()
        {
            MapNameFoodWithQuantity = StatisticBLL.Instance().SelectTopSelling(numTopSelling);
        }

        // Phân quyền tài khoản
        private void Decentralization()
        {
            if (frmMain._account.Type_Account == "Admin")
            {
                IsValidTypeAccount = true;
                picLock.Visible = false;
            }
            else
            {
                IsValidTypeAccount = false;
                picLock.Visible = true;
            }
        }

        private void LoadYesterdayIncome()
        {
            Yesterday_Income = StatisticBLL.Instance().
                SelectYesterdayIncome(DateTime.Now);
            if (Yesterday_Income == null)
            {
                lblIncomeYesterday.Text = "0 đ";
            }
            else
            {
                lblIncomeYesterday.Text = Yesterday_Income.ToString("#,##0 đ");
            }
        }

        private void LoadTodayIncome()
        {
            Today_Income = StatisticBLL.Instance().
                SelectTodayIncome(DateTime.Now);
            if (Today_Income == null)
            {
                lblIncomeToday.Text = "0 đ";
            }
            else
            {
                lblIncomeToday.Text = Today_Income.ToString("#,##0 đ");
            }

            if (Yesterday_Income > Today_Income)
            {
                picArrow.Image = ResourceImageArrow.Down;
            }
            else if (Yesterday_Income < Today_Income)
            {
                picArrow.Image = ResourceImageArrow.Up;
            }
            else
            {
                picArrow.Image = ResourceImageArrow.Minus;
            }
        }

        private void LoadTotalIncome()
        {
            Total_Income = StatisticBLL.Instance().SelectTotalIncome();
            if (Total_Income == null)
            {
                lblTotalIncomeAllTime.Text = "0 đ";
            }
            else
            {
                lblTotalIncomeAllTime.Text = Total_Income.ToString("#,##0 đ");
            }
        }

        private void LoadLineChart()
        {
            string month_name;
            foreach (var entry in MapIncomeWithMonth)
            {
                month_name = $"Tháng {entry.Key}";
                datasetLineChart.DataPoints.Add(month_name, (double)entry.Value);
            }
            LineChartIncome.Update();
        }

        private void LoadPie()
        {
            SeriesCollection s = new SeriesCollection();

            int i = 0;
            foreach(var entry in MapNameFoodWithQuantity)
            {
                s.Add(new PieSeries()
                {
                    Title = entry.Key,
                    Values = new ChartValues<int> { entry.Value },
                    DataLabels = true,
                    FontSize = 14,
                    Fill = new SolidColorBrush(pieColors[i++])
                });
            }
     
            // Gán SeriesCollection và Legend cho biểu đồ Pie
            PieChartTopFood.Series = s;
            PieChartTopFood.LegendLocation = LegendLocation.Bottom;
        }

        private void ClearField()
        {
            Yesterday_Income = 0;
            Today_Income = 0;
            Today_Income = 0;
            lblIncomeYesterday.Text = "0 đ";
            lblIncomeToday.Text = "0 đ";
            lblTotalIncomeAllTime.Text = "0 đ";
            MapIncomeWithMonth.Clear();
            LoadDictionaryIncomeList();
        }

        private void btnResetStatistic_Click(object sender, EventArgs e)
        {
            if (IsValidTypeAccount)
            {
                string content = "Bạn có chắc muốn thiết lập lại thống kê?" +
                    "\nBạn sẽ mất hết dữ liệu trước đó";

                DialogResult result = MessageBox.Show(content,
                "THIẾT LẬP LẠI HÓA ĐƠN", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    StatisticBLL.Instance().DeleteAllStatistic();
                    ClearField();
                }
            }
            else
            {
                MessageBox.Show("Chức năng chỉ dành cho Admin",
                    "THÔNG BÁO", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
