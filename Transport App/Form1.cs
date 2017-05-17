using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace Transport_App
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow item in this.dataGridViewConnection.SelectedRows)
            {
                dataGridViewConnection.Rows.RemoveAt(item.Index);
            }

            Transport tp = new Transport();
            Connections connections = tp.GetConnections(comboBoxDepart.Text, comboBoxDestination.Text);
            
            foreach (Connection connection in connections.ConnectionList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewConnection);
                row.Cells[0].Value = connection.From.Station.Name;
                row.Cells[1].Value = connection.From.Platform;
                row.Cells[2].Value = connection.To.Station.Name;
                row.Cells[3].Value = connection.To.Platform;
                row.Cells[4].Value = Convert.ToDateTime(connection.From.Departure).ToString("HH:mm");
                row.Cells[5].Value = Convert.ToDateTime(connection.To.Arrival).ToString("HH:mm");

                row.Cells[6].Value = connection.Duration.Substring(3, 2) + "h " + connection.Duration.Substring(6, 2) + "min";

                dataGridViewConnection.Rows.Add(row);
            }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxDepart_TextUpdate(object sender, EventArgs e)
        {
            //only Check if Text lengh > 3 and a odd number (3, 5, 7...)
            if (comboBoxDepart.Text.Length >= 3 && (comboBoxDepart.Text.Length + 1) % 2 == 0) {

                SwissTransport.Transport transport = new Transport();

                var equalStations = transport.GetStations(comboBoxDepart.Text);

                foreach (var station in equalStations.StationList)
                {
                    comboBoxDepart.Items.Add(station.Name);
                }
            }

        }
    }
}
