using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class ReportViewer : Form
    {
        private string id = "";
        private int intRow = 0;

        public ReportViewer()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            
            DbConnection.sql = "SELECT * FROM client";
            DbConnection.cmd = new NpgsqlCommand(DbConnection.sql, DbConnection.connection);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(DbConnection.cmd);

            DataTable dataTable = DbConnection.executeConnection(DbConnection.cmd);

            dataSet.Tables.Add(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                intRow = Convert.ToInt32(dataTable.Rows.Count.ToString());
            }
            else
            {
                intRow = 0;
            }

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dataSet));

            this.reportViewer1.RefreshReport();
        }
    }
}
