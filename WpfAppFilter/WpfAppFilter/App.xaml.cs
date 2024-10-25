using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfAppFilter.Models;

namespace WpfAppFilter
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static List<Pers> Pers;
        public static List<PersAtribut> PersAtribut;
        public App()
        {
            Pers = new List<Pers>();
            Pers.Add(new Pers() { Id = 1, Name = "Джаггернаут", Atribut = "Ловкость", PersAtributId = 1 });
            Pers.Add(new Pers() { Id = 2, Name = "Алхимик", Atribut = "Сила", PersAtributId = 2 });
            Pers.Add(new Pers() { Id = 3, Name = "Течис", Atribut = "Универсал", PersAtributId = 3 });
            Pers.Add(new Pers() { Id = 4, Name = "Марси", Atribut = "Универсал", PersAtributId = 4 });
            Pers.Add(new Pers() { Id = 5, Name = "ОгрМаг", Atribut = "Сила", PersAtributId = 5 });
            Pers.Add(new Pers() { Id = 6, Name = "Лич", Atribut = "Интелект", PersAtributId = 6 });

            PersAtribut = new List<PersAtribut>();
            PersAtribut.Add(new PersAtribut() { Id = 1, Atribut = "Ловкость" });
            PersAtribut.Add(new PersAtribut() { Id = 2, Atribut = "Сила" });
            PersAtribut.Add(new PersAtribut() { Id = 3, Atribut = "Универсал" });
            PersAtribut.Add(new PersAtribut() { Id = 4, Atribut = "Универсал" });
            PersAtribut.Add(new PersAtribut() { Id = 5, Atribut = "Сила" });
            PersAtribut.Add(new PersAtribut() { Id = 6, Atribut = "Интелект" });
        }
    }
}
