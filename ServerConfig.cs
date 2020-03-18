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
        private static DataTable dt = new DataTable();
        public static void LoadGrid(DataGridView dataGridView, string group)
        {
            //if (File.Exists("Server.csv"))
            //{
            //    DESFileClass.EncryptFile("Server.csv", "Server.dat", "c2Soecqg9f5GXCflI7c6wBNq4fAXiZcS");
            //    //File.Delete("Server.csv");
            //}
            if (File.Exists("Server.dat"))
            {
                string csvFileName = System.IO.Path.GetTempFileName();
                DESFileClass.DecryptFile("Server.dat", csvFileName, "c2Soecqg9f5GXCflI7c6wBNq4fAXiZcS");
                dt = CSVFileHelper.ReadCSV(csvFileName);
                File.Delete(csvFileName);
                if (!dt.Columns.Contains("OrderIndex"))
                {
                    dt.Columns.Add("OrderIndex", typeof(Int32));
                }
                foreach (DataRow row in dt.Rows)
                {
                    int index = 0;
                    int.TryParse(row["Index"].ToString(), out index);
                    row["OrderIndex"] = index;
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
            if (dt != null)
            {
                //DataTable dt = CSVFileHelper.ReadCSV("Server.csv");
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
