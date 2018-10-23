using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MstscManager
{
    public static class ServerConfig
    {

        public static void LoadGrid(DataGridView dataGridView, string group)
        {
            if (File.Exists("Server.csv"))
            {
                DataTable dt = CSVFileHelper.ReadCSV("Server.csv");
                if (!dt.Columns.Contains("OrderIndex"))
                {
                    dt.Columns.Add("OrderIndex", typeof(Int32));
                }
                foreach (DataRow row in dt.Rows)
                {
                    row["OrderIndex"] = Convert.ToInt32(row["Index"]);
                }

                dt.DefaultView.Sort = "OrderIndex ASC";
                if (string.Compare(group, "All", false) != 0)
                {
                    dt.DefaultView.RowFilter = string.Format("Group = '{0}'", group);
                    dataGridView.DataSource = dt.DefaultView;
                }
                else
                {
                    dataGridView.DataSource = dt.DefaultView;
                }
            }
        }

        public static void LoadDDLGroup(ComboBox ddl)
        {
            List<string> groupList = new List<string>();
            groupList.Add("All");
            if (File.Exists("Server.csv"))
            {
                DataTable dt = CSVFileHelper.ReadCSV("Server.csv");
                foreach (DataRow row in dt.Rows)
                {
                    if (groupList.Contains(row["Group"].ToString()))
                    {
                        continue;
                    }
                    groupList.Add(row["Group"].ToString());
                    //groupList[row["Group"].ToString()] = "";
                }
            }
            ddl.DataSource = groupList;
        }
    }
}
