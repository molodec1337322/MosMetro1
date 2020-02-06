using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MosMetro1
{
    public partial class Form1 : Form
    {
        private Graph.IPathFinder searcher;

        private List<Graph.IStation> path;
        private int travelTime;

        private Graph.IUnderground underground;

        private Graph.IBranch departureBranch = null;
        private Graph.IBranch destinationBranch = null;
        private Graph.IStation departureStation = null;
        private Graph.IStation destinationStation = null;

        private string[] branchNames = { "Замоскворецкая линия", "Сокольническая линия", "Арбатско-покровская линия",
                "Кольцевая линия"};

        private string[] stationNamesGreen = {"Ховрино", "Беломорская", "Речной вокзал", "Водный стадион", "Войковская",
                "Сокол", "Аэропорт", "Динамо", "Белорусская", "Маяковская", "Тверская", "Театральная", "Новокузнецкая",
                "Павелецкая", "Автозаводская", "Технопарк", "Коломенская", "Каширская", "Кантемировская", "Царицыно",
                "Ленино", "Орехово", "Домодедовская", "Красногвардейская","Алма - Атинская"};

        private string[] stationsNamesRed = {"Бульвар Рокоссовского", "Черкизовская", "Преображенская площадь",
                "Сокольники", "Красносельская", "Комсомольская", "Красные Ворота", "Чистые пруды", "Лубянка",
                "Охотный Ряд", "Библиотека имени Ленина", "Кропоткинская", "Парк культуры", "Фрунзенская",
                "Спортивная", "Воробьёвы горы", "Университет", "Проспект Вернадского", "Юго-Западная", "Тропарёво",
                "Румянцево", "Саларьево", "Филатов луг", "Прокшино", "Ольховая", "Коммунарка"};

        private string[] stationsNamesBlue = {"Пятницкое шоссе", "Митино", "Волоколамская", "Мякинино", "Строгино",
                "Крылатское", "Молодёжная", "Кунцевская", "Славянский бульвар", "Парк Победы", "Киевская", "Смоленская",
                "Арбатская", "Площадь Революции", "Курская", "Бауманская", "Электрозаводская", "Семёновская",
                "Партизанская", "Измайловская", "Первомайская","Щёлковская"};

        private string[] stationsNamesBrown = {"Парк культуры", "Октябрьская", "Добрынинская", "Павелецкая",
                "Таганская", "Курская", "Комсомольская", "Проспект Мира", "Новослободская", "Белорусская",
                "Краснопресненская", "Киевская"};

        public Form1()
        {
            underground = new Graph.Underground();
            InitializeSettingsAndStations();

            searcher = new Graph.BreadthFirstSearch();

            InitializeComponent(); //инициализация элементов

            BranchDepartureComboBox.Items.AddRange(branchNames);
            BranchDestinationComboBox.Items.AddRange(branchNames);

            BranchDepartureComboBox.SelectedIndexChanged += BranchDepartureComboBox_SelectedIndexChanged;
            BranchDestinationComboBox.SelectedIndexChanged += BranchDestinationComboBox_SelectedIndexChanged;
            StationDepartureComboBox.SelectedIndexChanged += StationDepartureComboBox_SelectedIndexChanged;
            StationDestinationComboBox.SelectedIndexChanged += StationDestinationComboBox_SelectedIndexChanged;

            CheckFindPathButtonIsEnable();
        }

        /// <summary>
        /// инициализация настроек и параметров метро
        /// </summary>
        private void InitializeSettingsAndStations()
        {

            Graph.IBranch stationsGreenBranch = new Graph.Branch("Замоскворецкая линия", "green", stationNamesGreen);
            Graph.IBranch stationsRedBranch = new Graph.Branch("Сокольническая линия", "red", stationsNamesRed);
            Graph.IBranch stationsBlueBranch = new Graph.Branch("Арбатско-покровская линия", "blue", stationsNamesBlue);
            Graph.IBranch stationsBrownBranch = new Graph.Branch("Кольцевая линия", "brown", stationsNamesBrown);

            Graph.Branch.ConnectBranches(stationsBrownBranch.GetStationByName("Парк культуры"),
                stationsBrownBranch.GetStationByName("Киевская"));

            Graph.Branch.ConnectBranches(stationsRedBranch.GetStationByName("Охотный Ряд"),
                stationsGreenBranch.GetStationByName("Театральная"));

            Graph.Branch.ConnectBranches(stationsBlueBranch.GetStationByName("Площадь Революции"),
                stationsGreenBranch.GetStationByName("Театральная"));

            Graph.Branch.ConnectBranches(stationsRedBranch.GetStationByName("Библиотека имени Ленина"),
                stationsBlueBranch.GetStationByName("Арбатская"));

            Graph.Branch.ConnectBranches(stationsBrownBranch.GetStationByName("Парк культуры"),
                stationsRedBranch.GetStationByName("Парк культуры"));

            Graph.Branch.ConnectBranches(stationsBrownBranch.GetStationByName("Павелецкая"),
                stationsGreenBranch.GetStationByName("Павелецкая"));

            Graph.Branch.ConnectBranches(stationsBrownBranch.GetStationByName("Курская"),
                stationsBlueBranch.GetStationByName("Курская"));

            Graph.Branch.ConnectBranches(stationsBrownBranch.GetStationByName("Комсомольская"),
                stationsRedBranch.GetStationByName("Комсомольская"));

            Graph.Branch.ConnectBranches(stationsBrownBranch.GetStationByName("Белорусская"),
                stationsGreenBranch.GetStationByName("Белорусская"));

            Graph.Branch.ConnectBranches(stationsBrownBranch.GetStationByName("Киевская"),
                stationsBlueBranch.GetStationByName("Киевская"));

            underground.AddBranch(stationsBlueBranch);
            underground.AddBranch(stationsBrownBranch);
            underground.AddBranch(stationsGreenBranch);
            underground.AddBranch(stationsRedBranch);
        }

        private void StationDestinationLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void StationDestinationLabel_Click_1(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// выбор стнанции назначения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StationDestinationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStation = StationDestinationComboBox.SelectedItem.ToString();

            destinationStation = destinationBranch.GetStationByName(selectedStation);

            CheckFindPathButtonIsEnable();
        }

        /// <summary>
        /// выбор ветки назначения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BranchDestinationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StationDestinationComboBox.Items.Clear();

            string selectedBranch = BranchDestinationComboBox.SelectedItem.ToString();

            destinationBranch = underground.GetBranchByName(selectedBranch);
            StationDestinationComboBox.Items.AddRange(ConvertFromListToArray(destinationBranch.GetAllStations()));

            destinationStation = null;

            CheckFindPathButtonIsEnable();
        }

        /// <summary>
        /// выбор станции отправления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StationDepartureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStation = StationDepartureComboBox.SelectedItem.ToString();

            departureStation = departureBranch.GetStationByName(selectedStation);

            CheckFindPathButtonIsEnable();
        }

        /// <summary>
        /// выбор ветки отправления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BranchDepartureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StationDepartureComboBox.Items.Clear();

            string selectedBranch = BranchDepartureComboBox.SelectedItem.ToString();

            departureBranch = underground.GetBranchByName(selectedBranch);
            StationDepartureComboBox.Items.AddRange(ConvertFromListToArray(departureBranch.GetAllStations()));

            departureStation = null;

            CheckFindPathButtonIsEnable();
        }

        /// <summary>
        /// конвертирует список станций в массив имен этих станций
        /// </summary>
        /// <param name="stationList"></param>
        /// <returns></returns>
        private string[] ConvertFromListToArray(List<Graph.IStation> stationList)
        {
            string[] stationNamesArray = new string[stationList.Count];
            for (int i = 0; i < stationList.Count; i++)
            {
                stationNamesArray[i] = stationList[i].GetStationName();
            }
            return stationNamesArray;
        }

        /// <summary>
        /// кнопка поиска маршрута
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindPathButton_Click(object sender, EventArgs e)
        {
            path = searcher.FindPath(departureStation, destinationStation);
            travelTime = path.Count * 3;

            PathListBox.Items.Clear();
            PathListBox.Items.AddRange(ConvertFromListToArray(path));
            TimeTravelLabel.Text = $"Примерное время в пути {travelTime} минут";
        }

        /// <summary>
        /// проверяет, доложна ли кнопка быть активной
        /// </summary>
        private void CheckFindPathButtonIsEnable()
        {
            if (departureBranch != null && destinationBranch != null && departureStation != null && destinationStation != null)
            {
                FindPathButton.Enabled = true;
            }
            else
            {
                FindPathButton.Enabled = false;
            }
        }

        private void TimeTravelLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
