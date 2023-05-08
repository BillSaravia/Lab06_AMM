using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Lab06_AMM
{
    public class Tecsup : List<Person>
    {
        public string Title { get; set; }

        public Tecsup(string title)
        {
            Title = title;
        }
    }
}