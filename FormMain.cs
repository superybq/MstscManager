using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MstscManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            ddlColor.SelectedIndex = 4;
            try
            {
                ServerConfig.LoadGrid(dataGridView1, "All");
                ServerConfig.LoadDDLGroup(ddlGroup);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
                txtDesktopwidth.Text = cfa.AppSettings.Settings["desktopwidth"].Value;
                txtDesktopheight.Text = cfa.AppSettings.Settings["desktopheight"].Value;
            }
            catch
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnOpen")
            {
                string ip = dataGridView1.Rows[e.RowIndex].Cells["ServerIp"].Value.ToString();
                string group = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Group"].Value);
                string serverName = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ServerName"].Value);
                string userName = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ServerUserName"].Value);
                string password = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ServerPassword"].Value);
                string domain = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ServerDomain"].Value);
                string index = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Index"].Value);
                if (string.IsNullOrEmpty(ip))
                {
                    return;
                }
                RunOpenMstsc(ip, userName, password, domain, group + "_" + serverName);
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Chk")
            {
                DataGridViewCheckBoxCell dataGridViewCheckBoxCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(dataGridViewCheckBoxCell.Value))
                {
                    dataGridViewCheckBoxCell.Value = false;
                }
                else
                {
                    dataGridViewCheckBoxCell.Value = true;
                }

            }
        }

        private void RunOpenMstsc(string ip, string userName, string password, string domain, string showName)
        {
            string color = "32";
            color = ddlColor.SelectedItem.ToString();
            string str = "start mstsc /v:" + ip;
            string filePath = Path.Combine(Path.GetTempPath(), showName + ".rdp");
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                FileStream fs = new FileStream(filePath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
                sw.Write(RDPData.GetRDPData(ip, userName, password, domain, txtDesktopwidth.Text, txtDesktopheight.Text, color));
                sw.Close();
                fs.Close();
                str = "start mstsc " + filePath + " /console /v:" + ip;
            }

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            p.StartInfo.CreateNoWindow = true;//不显示程序窗口
            p.Start();//启动程序

            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(str + "&exit");

            p.StandardInput.AutoFlush = true;

            p.WaitForExit();
            p.Close();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            FormConfig formConfig = new FormConfig();
            formConfig.ShowDialog();
            ServerConfig.LoadGrid(dataGridView1, ddlGroup.SelectedValue.ToString());
            ServerConfig.LoadDDLGroup(ddlGroup);
        }

        private void btnBatOpen_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    string ip = dataGridView1.Rows[row.Index].Cells["ServerIp"].Value.ToString();
                    string group = Convert.ToString(dataGridView1.Rows[row.Index].Cells["Group"].Value);
                    string serverName = Convert.ToString(dataGridView1.Rows[row.Index].Cells["ServerName"].Value);
                    string userName = Convert.ToString(dataGridView1.Rows[row.Index].Cells["ServerUserName"].Value);
                    string password = Convert.ToString(dataGridView1.Rows[row.Index].Cells["ServerPassword"].Value);
                    string domain = Convert.ToString(dataGridView1.Rows[row.Index].Cells["ServerDomain"].Value);
                    string index = Convert.ToString(dataGridView1.Rows[row.Index].Cells["Index"].Value);
                    if (string.IsNullOrEmpty(ip))
                    {
                        return;
                    }
                    RunOpenMstsc(ip, userName, password, domain, group + "_" + serverName);
                }
            }
        }

        private void txtDesktopwidth_TextChanged(object sender, EventArgs e)
        {
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            try
            {
                cfa.AppSettings.Settings["desktopwidth"].Value = txtDesktopwidth.Text;
            }
            catch
            {
                cfa.AppSettings.Settings.Add("desktopwidth", txtDesktopwidth.Text);
            }
            cfa.Save();
        }

        private void txtDesktopheight_TextChanged(object sender, EventArgs e)
        {
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            try
            {
                cfa.AppSettings.Settings["desktopheight"].Value = txtDesktopheight.Text;
            }
            catch
            {
                cfa.AppSettings.Settings.Add("desktopheight", txtDesktopheight.Text);
            }

            cfa.Save();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void ddlGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServerConfig.LoadGrid(dataGridView1, ddlGroup.SelectedValue.ToString());
        }
    }
}
