using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Neetsonic.Tool;

namespace SenkaPicDownload
{
    public partial class Form1 : Form
    {
        private static readonly DataTable Servers = new DataTable();

        public Form1()
        {
            InitializeComponent();
            Servers.Columns.Add(@"Name", typeof(string));
            Servers.Columns.Add(@"Value", typeof(int));
            Servers.Rows.Add(@"横须贺", 1);
            Servers.Rows.Add(@"吴", 2);
            Servers.Rows.Add(@"佐世保", 3);
            Servers.Rows.Add(@"舞鹤", 4);
            Servers.Rows.Add(@"大凑", 5);
            Servers.Rows.Add(@"特鲁克", 6);
            Servers.Rows.Add(@"林加", 7);
            Servers.Rows.Add(@"拉包尔", 8);
            Servers.Rows.Add(@"肖特兰", 9);
            Servers.Rows.Add(@"布因", 10);
            Servers.Rows.Add(@"塔威塔威", 11);
            Servers.Rows.Add(@"帕劳", 12);
            Servers.Rows.Add(@"文莱", 13);
            Servers.Rows.Add(@"单冠湾", 14);
            Servers.Rows.Add(@"幌筵", 15);
            Servers.Rows.Add(@"宿毛湾", 16);
            Servers.Rows.Add(@"鹿屋", 17);
            Servers.Rows.Add(@"岩川", 18);
            Servers.Rows.Add(@"佐伯湾", 19);
            Servers.Rows.Add(@"柱岛", 20);
            cmbServer.DisplayMember = @"Name";
            cmbServer.ValueMember = @"Value";
            cmbServer.DataSource = Servers;
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            const string Url = "http://203.104.209.7/kcscontents/information/image/rank";
            const int ServerCount = 20;
            DateTime currDate = new DateTime(dateStart.Value.Year, dateStart.Value.Month, 1);
            DateTime endDate = new DateTime(dateEnd.Value.Year, dateEnd.Value.Month, 1);
            WebClient myWebClient = new WebClient();
            while(currDate <= endDate)
            {
                int serverNO = Convert.ToInt32(cmbServer.SelectedValue);
                //for(int serverNO = 1; serverNO <= ServerCount; serverNO++)
                //{
                    string filename = string.Format($@"{currDate.Year}{currDate.Month:00}{serverNO:00}.jpg").Substring(2);
                    string url = string.Concat(Url, filename);
                    string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"战果人事表");
                    if(!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                    string filePath = Path.Combine(dir, filename);
                    try { myWebClient.DownloadFile(url, filePath); }
                    catch { }
                //}
                currDate = currDate.AddMonths(1);
            }
            MessageBoxEx.Info(@"完成！");
        }
    }
}