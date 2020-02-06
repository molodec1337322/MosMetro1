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
        public Form1()
        {
            string[] stationNamesGreen =
               {
                "Ховрино",
                "Беломорская",
                "Речной вокзал",
                "Водный стадион",
                "Войковская",
                "Сокол",
                "Аэропорт",
                "Динамо",
                "Белорусская",
                "Маяковская",
                "Тверская",
                "Театральная",
                "Новокузнецкая",
                "Павелецкая",
                "Автозаводская",
                "Технопарк",
                "Коломенская",
                "Каширская",
                "Кантемировская",
                "Царицыно",
                "Ленино",
                "Орехово",
                "Домодедовская",
                "Красногвардейская",
                "Алма - Атинская"
            };

            string[] stationsNamesRed =
            {
                "Бульвар Рокоссовского",
                "Черкизовская",
                "Преображенская площадь",
                "Сокольники",
                "Красносельская",
                "Комсомольская",
                "Красные Ворота",
                "Чистые пруды",
                "Лубянка",
                "Охотный Ряд",
                "Библиотека имени Ленина",
                "Кропоткинская",
                "Парк культуры",
                "Фрунзенская",
                "Спортивная",
                "Воробьёвы горы",
                "Университет",
                "Проспект Вернадского",
                "Юго-Западная",
                "Тропарёво",
                "Румянцево",
                "Саларьево",
                "Филатов луг",
                "Прокшино",
                "Ольховая",
                "Коммунарка"
            };

            string[] stationsNamesBlue =
            {
                "Пятницкое шоссе",
                "Митино",
                "Волоколамская",
                "Мякинино",
                "Строгино",
                "Крылатское",
                "Молодёжная",
                "Кунцевская",
                "Славянский бульвар",
                "Парк Победы",
                "Киевская",
                "Смоленская",
                "Арбатская",
                "Площадь Революции",
                "Курская",
                "Бауманская",
                "Электрозаводская",
                "Семёновская",
                "Партизанская",
                "Измайловская",
                "Первомайская",
                "Щёлковская"
            };

            string[] stationsNamesBrown =
            {
                "Парк культуры",
                "Октябрьская",
                "Добрынинская",
                "Павелецкая",
                "Таганская",
                "Курская",
                "Комсомольская",
                "Проспект Мира",
                "Новослободская",
                "Белорусская",
                "Краснопресненская",
                "Киевская"
            };


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


            Graph.IUnderground underground = new Graph.Underground();
            underground.AddBranch(stationsBlueBranch);
            underground.AddBranch(stationsBrownBranch);
            underground.AddBranch(stationsGreenBranch);
            underground.AddBranch(stationsRedBranch);


            InitializeComponent();
        }
    }
}
