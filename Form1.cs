using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Management;
using System.ServiceProcess;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ServiceGrid
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_grid();
        }

        void update_grid()
        {
            var data = new DataSet();
            data.Tables.Add("services");
            data.Tables["services"].Columns.Add("ServiceDisplayName", Type.GetType("System.String"));
            data.Tables["services"].Columns.Add("ServiceDescription", Type.GetType("System.String"));
            data.Tables["services"].Columns.Add("ServiceState", Type.GetType("System.String"));
            data.Tables["services"].Columns.Add("ServiceStartMode", Type.GetType("System.String"));
            data.Tables["services"].Columns.Add("ServiceStartName", Type.GetType("System.String"));
            data.Tables["services"].Columns.Add("ServiceName", Type.GetType("System.String"));
            data.Tables["services"].Columns.Add("ServiceAcceptStop", Type.GetType("System.String"));
            data.Tables["services"].Columns.Add("ServiceStarted", Type.GetType("System.String"));

            ManagementClass mcServices = new ManagementClass("Win32_Service");

            foreach (ManagementObject moService in mcServices.GetInstances())
            {
                data.Tables["services"].Rows.Add(new object[] {
                      get_property(moService, "DisplayName")
                    , get_property(moService, "Description")
                    , get_property(moService, "State")
                    , get_property(moService, "StartMode")
                    , get_property(moService, "StartName")
                    , get_property(moService, "Name")
                    , get_property(moService, "AcceptStop")
                    , get_property(moService, "Started")
                });
            }

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "services";
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        String get_property(ManagementObject service, String name)
        {
            var ret = service.GetPropertyValue(name);
            if (ret == null)
            {
                return "";
            }
            else
            {
                return ret.ToString();
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataSet dt = (DataSet)dataGridView1.DataSource;
            if (dataGridView1.Rows[e.RowIndex].Cells["ServiceName"].Value != null) {
                DataRow[] rows = dt.Tables["services"].Select("ServiceName='" + dataGridView1.Rows[e.RowIndex].Cells["ServiceName"].Value+"'");

                label1.Text = rows[0].Field<String>("ServiceDisplayName");
                label3.Text = rows[0].Field<String>("ServiceDescription");
                String started = rows[0].Field<String>("ServiceStarted");
                String acceptstop = rows[0].Field<String>("ServiceAcceptStop");
                String startmode = rows[0].Field<String>("ServiceStartMode");

                stopLayoutPanel3.Visible = false;
                startLayoutPanel2.Visible = false;
                restartLayoutPanel4.Visible = false;
                if (started.Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    if (acceptstop.Equals("true", StringComparison.OrdinalIgnoreCase))
                    {
                        stopLayoutPanel3.Visible = true;
                        restartLayoutPanel4.Visible = true;
                    }
                }
                else
                {
                    if (!startmode.Equals("disabled", StringComparison.OrdinalIgnoreCase))
                    {
                        startLayoutPanel2.Visible = true;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            update_grid();
        }
    }
}
