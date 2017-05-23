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

        //Autofill Eventhandler
        private void comboBoxDepart_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isKeyValid(e)) return;
            AutoCompleteDepart.UpdateSuggestions();
        }

        //Autofill Eventhandler
        private void comboBoxDestination_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isKeyValid(e)) return;
            AutoCompleteDestination.UpdateSuggestions();
        }

        //Check if the entered Key is valid
        private bool isKeyValid(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Tab)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Sets de Visible state of the Destination Label and Combobox
        private void rBtnYes_CheckedChanged(object sender, EventArgs e)
        {
            bool state = comboBoxDestination.Visible;

            comboBoxDestination.Visible = !state;
            lblDestination.Visible = !state;
        }

        //Switches the Contents from Depart and Destination Combobox
        private void btnChange_Click(object sender, EventArgs e)
        {
            string tempText = comboBoxDepart.Text;

            comboBoxDepart.Text = comboBoxDestination.Text;
            comboBoxDestination.Text = tempText;
        }

        private void btnSearchConncections_Click(object sender, EventArgs e)
        {
            //clear and refresh the dataGrid
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

                //fill Data into the DataGrid
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

                    //fill Data into the DataGrid
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

        private void btnSearchMapDepart_Click(object sender, EventArgs e)
        {
            searchOnGoogle(comboBoxDepart);
        }

        private void btnSearchMapDestination_Click(object sender, EventArgs e)
        {
            searchOnGoogle(comboBoxDestination);
        }

        //Opens a Google Maps Website in the Default Browser with x and y coordinates of the Station the User wantet to search
        private void searchOnGoogle(ComboBox cbBox)
        {
            Transport tp = new Transport();
            Stations stationDepart = tp.GetStations(cbBox.Text);
            foreach (Station station in stationDepart.StationList)
            {
                Coordinate coordinates = station.Coordinate;
                string xValue = coordinates.XCoordinate.ToString().Replace(",", ".");
                string yValue = coordinates.YCoordinate.ToString().Replace(",", ".");
                string url = "https://www.google.ch/maps/?q=loc:" + xValue + "+" + yValue;
                Process.Start(url);
            }
        }
    }
}
