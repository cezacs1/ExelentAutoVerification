using System;
using System.Drawing;
using System.Windows.Forms;
using ExelentAutoVerification.Models;

namespace ExelentAutoVerification
{
    public partial class ExelentSidePanel : Form
    {
        private readonly UserInfo _user;

        public ExelentSidePanel(UserInfo user)
        {
            InitializeComponent();

            _user = user;

            LoadUserData();
            SetDesktopLocation();

            StartCloseTimer(); // 4.5 saniye sonra formu kapat
        }

        private void ExelentSidePanel_Load(object sender, EventArgs e)
        {

        }

        private void LoadUserData()
        {
            lblUsername.Text = _user.Username;
            lblBalance.Text = $"{_user.Balance} TL";
            lblSteamId.Text = "Steam ID: " + (_user.SteamId ?? "-");
            lblFriendCode.Text = "Friend Code: " + (_user.FriendCode ?? "-");

            // Licenses
            if (_user.Purchases != null)
            {
                foreach (var p in _user.Purchases)
                {
                    lstLicenses.Items.Add(
                        $"{p.ProductName}"
                    );
                }
            }

            // HourBoost
            if (_user.HourboostPurchases != null)
            {
                foreach (var p in _user.HourboostPurchases)
                {
                    lstHourBoost.Items.Add(
                        $"{p.ProductName}"
                    );
                }
            }

            // Market
            if (_user.MarketPurchases != null)
            {
                foreach (var m in _user.MarketPurchases)
                {
                    lstMarket.Items.Add(
                        $"{m.ItemName} x{m.Quantity}"
                    );
                }
            }
        }

        private void SetDesktopLocation()
        {
            Rectangle area = Screen.PrimaryScreen.WorkingArea;
            Location = new Point(
                area.Width - Width - 10,
                area.Height - Height - 10
            );
        }

        private void StartCloseTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 4500;
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                Close();
            };
            timer.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblSteamId_Click(object sender, EventArgs e) { }
        private void lblFriendCode_Click(object sender, EventArgs e) { }
    }
}