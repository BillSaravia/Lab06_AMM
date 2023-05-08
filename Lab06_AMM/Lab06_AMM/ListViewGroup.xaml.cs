using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab06_AMM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        public ObservableCollection<Tecsup> Tecsups { get; set; }
        public ListViewGroup()
        {
            InitializeComponent();
            Tecsups = new ObservableCollection<Tecsup>
        {
            new Tecsup("Coordinadores")
            {
                new Person { Title = "Emily", lastname = "Cooper", Date = "28", Code = "9864227" },
                new Person { Title = "Gabriela", lastname = "Ortiz", Date = "31", Code = "7758432" },
                new Person { Title = "Ava", lastname = "Gonzalez", Date = "22", Code = "2876121" },
                new Person { Title = "Keylin", lastname = "Rodriguez", Date = "42", Code = "6357890" },
            },
            new Tecsup("Docentes")
            {
                new Person { Title = "Carmen", lastname = "Ortega", Date = "23", Code = "4478922" },
                new Person { Title = "Noah", lastname = "Garcia", Date = "49", Code = "2015634" },
                new Person { Title = "Olivia", lastname = "Davis", Date = "37", Code = "9458712" },
                new Person { Title = "Liam", lastname = "Trujillo", Date = "45", Code = "8834567" },
            },
            new Tecsup("Alumnos")
            {
                new Person { Title = "Bill", lastname = "Saravia", Date = "20", Code = "1122255" },
                new Person { Title = "Jose", lastname = "Pumahuacre", Date = "24", Code = "5167823" },
                new Person { Title = "Erika", lastname = "Choncen", Date = "21", Code = "2457890" },
                new Person { Title = "Amelia", lastname = "Pari", Date = "21", Code = "1234567" },
                new Person { Title = "Mia", lastname = "Caytuiro", Date = "29", Code = "3894752" },
            },
        };
            TecsupView.ItemsSource = Tecsups;
        }
    }
}