using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    /// <summary>
    /// Класс станции метро
    /// </summary>
    class Station : IStation
    {
        private List<IStation> ConnectedStations;
        private string name;
        private string id;
        private string color;

        private static int global_id = 0;

        public Station(string name, string color)
        {
            this.name = name.ToLower();
            this.id = global_id++.ToString();
            this.color = color;
            ConnectedStations = new List<IStation>(0);
        }

        public void ConnectStation(IStation station, bool isViceVersa)
        {
            ConnectedStations.Add(station);
            if(isViceVersa == true)
            {
                station.ConnectStation(this, false);
            }
        }

        public string GetStationID()
        {
            return id;
        }

        public string GetStationName()
        {
            return name;
        }

        public string GetColor()
        {
            return color;
        }

        public List<IStation> GetConnectedStations()
        {
            return ConnectedStations;
        }
    }
}
