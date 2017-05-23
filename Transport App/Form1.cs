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
using System.Net;
using System.Diagnostics;

namespace Transport_App
{
    public partial class mainForm : Form
    {
        private AutoComplete AutoCompleteDepart;
        private AutoComplete AutoCompleteDestination;

        public mainForm()
        {
            InitializeComponent();
            AutoCompleteDepart = new AutoComplete(comboBoxDepart);
            AutoCompleteDestination = new AutoComplete(comboBoxDestination);
        }

        private void btnSearchConncections_Click(object sender, EventArgs e)
        {
            dataGridViewConnection.Rows.Clear();
            dataGridViewConnection.Refresh();

            if (rBtnNo.Checked == true)
            {
                foreach (DataGridViewRow item in this.dataGridViewConnection.SelectedRows)
                {
                    dataGridViewConnection.Rows.RemoveAt(item.Index);
                }

                Transport tp = new Transport();

                string date = datePicker.Value.ToString("yyyy-MM-dd");
                string time = timePicker.Value.ToString("HH:mm");

                Connections connections = tp.GetConnectionsWithTime(comboBoxDepart.Text, comboBoxDestination.Text, date, time);
                
                foreach (Connection connection in connections.ConnectionList)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridViewConnection);
                    row.Cells[0].Value = connection.From.Station.Name;
                    row.Cells[2].Value = connection.From.Platform;
                    row.Cells[3].Value = connection.To.Station.Name;
                    row.Cells[4].Value = connection.To.Platform;
                    row.Cells[5].Value = Convert.ToDateTime(connection.From.Departure).ToString("HH:mm");
                    row.Cells[6].Value = Convert.ToDateTime(connection.To.Arrival).ToString("HH:mm");
                    row.Cells[7].Value = connection.Duration.Substring(3, 2) + "h " + connection.Duration.Substring(6, 2) + "min";

                    dataGridViewConnection.Rows.Add(row);
                }
            }
            else
            {
                Transport tp = new Transport();
                Stations stations = tp.GetStations(comboBoxDepart.Text);
                foreach (Station station in stations.StationList)
                {
                    String id = station.Id;
                    StationBoardRoot stationBoardRoot = tp.GetStationBoard(comboBoxDepart.Text, id);
                    foreach (StationBoard stationBoard in stationBoardRoot.Entries)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridViewConnection);
                        row.Cells[0].Value = comboBoxDepart.Text;
                        row.Cells[1].Value = stationBoard.Name;
                        row.Cells[3].Value = stationBoard.To;
                        row.Cells[5].Value = stationBoard.Stop.Departure.ToString("HH:mm:ss");

                        dataGridViewConnection.Rows.Add(row);
                    }
                }
            }

        }

        // Event-Handlers für Haltestellensuche
        private void comboBoxDepart_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isKeyValid(e)) return;
            AutoCompleteDepart.UpdateSuggestions();
        }

        private void comboBoxDestination_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isKeyValid(e)) return;
            AutoCompleteDestination.UpdateSuggestions();
        }

        private bool isKeyValid(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up ||
                e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Left ||
                e.KeyCode == Keys.Right ||
                e.KeyCode == Keys.Tab) return false;
            return true;
        }








        private void rBtnYes_CheckedChanged(object sender, EventArgs e)
        {
            bool state = comboBoxDestination.Visible;

            comboBoxDestination.Visible = !state;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string tempText = comboBoxDepart.Text;

            comboBoxDepart.Text = comboBoxDestination.Text;
            comboBoxDestination.Text = tempText;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Transport tp = new Transport();
            Stations stationVon = tp.GetStations(comboBoxDepart.Text);
            foreach (Station station in stationVon.StationList)
            {
                Coordinate cordinates = station.Coordinate;
                string xValue = cordinates.XCoordinate.ToString().Replace(",", ".");
                string yValue = cordinates.YCoordinate.ToString().Replace(",", ".");
                string url = "https://www.google.ch/maps/?q=loc:" + xValue + "+" + yValue;
                Process.Start(url);
            }
        }
    }
}
