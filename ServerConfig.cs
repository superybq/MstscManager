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

        public static void Load(DataGridView dataGridView)
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
                dataGridView.DataSource = dt.DefaultView;

            }
        }

    }
}
