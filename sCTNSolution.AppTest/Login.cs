using Microsoft.Extensions.DependencyInjection;
using sCTNSolution.AppTest.Models.Request;
using sCTNSolution.AppTest.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sCTNSolution.AppTest
{
    public partial class Login : Form
    {
        private readonly UserApiClient _userApiClient;
       // private readonly HttpClient _httpClient;
       
        public Login()
        {
            InitializeComponent();
          //  _httpClient = httpClient;
            _userApiClient =new UserApiClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (WaitForm frm= new WaitForm(LoginAPI))
            {
                frm.ShowDialog();
            }
             

            //gridresult
        }
        protected async void LoginAPI()
        {
            var loginRequest = new LoginRequest()
            {
                UserName = txtusername.Text,
                Password = txtpassword.Text,
                RememberMe = chkrememberme.Checked
            };
            var token = await _userApiClient.Authenticate(loginRequest);
            //var data = await _userApiClient.GetTram();
            //txttoken.Invoke(new Action(() => 
            //    txttoken.Text = token 
            //));
            //gridresult.Invoke(new Action(() => gridresult.DataSource = data));
            LoadKy();
            LoadTram();
        }
        Form1 frm1 = new Form1();
        private void SetLoading(bool displayLoader)
        {
            if (displayLoader)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    frm1.Show();
                   // picLoader.Visible = true;
                   // this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    frm1.Close();
                    //picLoader.Visible = false;
                    //  this.Cursor = System.Windows.Forms.Cursors.Default;
                });
            }
        }
        private void btngettram_Click(object sender, EventArgs e)
        {
            using (WaitForm frm = new WaitForm(LoadTram))
            {
                frm.ShowDialog();
            }
        }
        protected async void LoadTram()
        {
            var data = await _userApiClient.GetTram();
            cbhtcn.Invoke(new Action(() => {
                cbhtcn.DataSource = data.OrderBy(p => p.MaTram).ToList();
                cbhtcn.ValueMember = "MaTram";
                cbhtcn.DisplayMember = "TenTram";
            }));
        }
        private async void LoadKy()
        {
            var data = await _userApiClient.GetKyHoaDon();
            cbkyxuathd.Invoke(new Action(() => {
                cbkyxuathd.DataSource = data.OrderByDescending(p => p.MaKyTinh).ToList();
                cbkyxuathd.ValueMember = "MaKyTinh";
                cbkyxuathd.DisplayMember = "MaKyTinh";
                cbkyxuathd.FormatString = "MM/yyyy";
            }));
        }
        private async void LoadHoaDonByTram(GetHoaDonPagingRepuest repuest)
        {
            var data = await _userApiClient.GetHoaDon(repuest);
            gridresult.Invoke(new Action(() => {
                gridresult.DataSource = data.Items.OrderByDescending(h=>h.MaKh).ToList();
            }));
            groupBox2.Invoke(new Action(() => groupBox2.Text = $@"Kỳ tính: {data.KyHoaDon}, Mã trạm: {repuest.MaTram}, Total: {data.TotalRecord}"));
        }
        private async void LoadHoaDonByKy(PagingRequestBase repuest)
        {
            var data = await _userApiClient.GetHoaDon(repuest);
            gridresult.Invoke(new Action(() => {
                gridresult.DataSource = data.Items.OrderByDescending(h => h.MaKh).ToList();
            }));
            groupBox2.Invoke(new Action(() => groupBox2.Text = $@"Kỳ tính: {data.KyHoaDon}, Mã trạm: All, Total: {data.TotalRecord}"));
        }
        private void DisplayData()
        {
            SetLoading(true);

            // Do other operations...
            var kytinh =new DateTime();
            var tramnuoc = string.Empty;

            this.Invoke((MethodInvoker)delegate
            {
                 kytinh = DateTime.Parse(cbkyxuathd.SelectedValue.ToString());
                 tramnuoc = cbhtcn.SelectedValue.ToString();
            });
            
            GetHoaDonPagingRepuest repuest = new GetHoaDonPagingRepuest()
            {
                KyHoadon = kytinh,
                MaTram = tramnuoc
            };
            LoadHoaDonByTram(repuest);
            SetLoading(false);
        }
        private void DisplayError(Exception ex)
        {
            MessageBox.Show("The below error occurred while processing the request: \n\r \n\r" + ex.Message);
        }
        private void btngetHDbykytram_Click(object sender, EventArgs e)
        {
            var sw = new Stopwatch();
            sw.Start();
            try
            {
                Thread threadInput = new Thread(DisplayData);
                threadInput.Start();
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
            
            sw.Stop();
            MessageBox.Show($"Thời gian truy xuất: {sw.Elapsed.TotalSeconds.ToString("#,##0.00 'seconds'")}");
        }

        private void GetHDByky_Click(object sender, EventArgs e)
        {
            var sw = new Stopwatch();
            sw.Start();
            var kytinh = DateTime.Parse(cbkyxuathd.SelectedValue.ToString());
            var tramnuoc = cbhtcn.SelectedValue.ToString();
            PagingRequestBase repuest = new PagingRequestBase()
            {
                KyHoadon = kytinh
                
            };
            LoadHoaDonByKy(repuest);
            sw.Stop();
            MessageBox.Show($"Thời gian truy xuất: {sw.Elapsed.TotalSeconds.ToString("#,##0.00 'seconds'")}");
        }
    }
}
