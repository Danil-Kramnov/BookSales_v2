using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace BookSalesSys
{
    public static class DBConnection
    {
        private static string connStr = "Data Source=localhost:1521/orcl;User Id=c##user1;Password=Oracle123456;";

        public static bool IsConnected { get; set; } = false;

        // get a connection
        public static OracleConnection GetConnection()
        {
            return new OracleConnection(connStr);
        }

        // Color scheme and font recommendations referenced from:
        // https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-set-the-background-of-a-windows-forms-panel
        // https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.backcolor
        public static void ApplyStyling(Form form)
        {
            // // reference: https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color.fromargb
            Console.WriteLine(form.ToString());

            form.BackColor = Color.FromArgb(235, 240, 245); // light blue grey

            foreach (Control ctrl in GetAllControls(form))
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(30, 58, 95); // oxford blue
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat; // new style of the button https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.flatstyle?view=windowsdesktop-10.0
                    btn.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                }
                else if (ctrl is GroupBox grp)
                {
                    grp.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                    grp.ForeColor = Color.FromArgb(30, 58, 95);
                }
                else if (ctrl is Label lbl)
                {
                    lbl.Font = new Font("Segoe UI", 9f);
                    lbl.ForeColor = Color.FromArgb(30, 58, 95);
                }
                else if (ctrl is DataGridView dgv)
                {
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 58, 95);
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                    dgv.EnableHeadersVisualStyles = false;
                }
            }

        }

        // to get all controls recursively including inside groupboxes
        // referencing:
        // https://stackoverflow.com/questions/3419159/how-to-get-all-child-controls-of-a-windows-form-of-a-specific-type
        private static IEnumerable<Control> GetAllControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                yield return ctrl;
                foreach (Control child in GetAllControls(ctrl))
                    yield return child;
            }
        }
    }
}