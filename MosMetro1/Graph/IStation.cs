﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    interface IStation
    {
        string GetStationName();

        string GetStationID();

        string GetColor();

        void ConnectStation(IStation station, bool isViceVersa);

        List<IStation> GetConnectedStations();
    }
}
