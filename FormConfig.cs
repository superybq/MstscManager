using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MstscManager
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            ServerConfig.LoadGrid(dataGridView1,"All");
            //ServerConfig.LoadDDL(ddlGroup);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = GetDgvToTable(dataGridView1);
            dt.DefaultView.Sort = "index";
            string csvFileName = System.IO.Path.GetTempFileName();
            CSVFileHelper.SaveCSV(dt, csvFileName);
            DESFileClass.EncryptFile(csvFileName, "Server.dat", "c2Soecqg9f5GXCflI7c6wBNq4fAXiZcS");
            File.Delete(csvFileName);
            this.Close();
        }

        public DataTable GetDgvToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            // 列强制转换  
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }

            // 循环行
            for (int count = 0; count < dgv.Rows.Count; count++)
            {
                if (string.IsNullOrEmpty(Convert.ToString(dgv.Rows[count].Cells["Group"].Value)))
                {
                    continue;
                }
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
                {
                    dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub].Value);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
