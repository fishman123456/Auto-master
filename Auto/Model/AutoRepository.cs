using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAutomobile.Model
{
    public static class AutoRepository
    {
        static ObservableCollection<Auto> _automobiles;
        public static ObservableCollection<Auto> Automobiles
        {
            get
            {
                if (_automobiles == null)
                    _automobiles = GenerateAutoRepository();
                return _automobiles;
            }
        }

        static ObservableCollection<Auto> GenerateAutoRepository()
        {
            var tmp = new ObservableCollection<Auto>
            {
                new Auto{Brand = "Mersedes", Color = "Black", Price = 34000, Image ="/../img/Mercedes.jpg"},
                new Auto{Brand = "BMW", Color = "White", Price = 50000, Image ="/../img/BMW.jpg"},
                new Auto{Brand = "Ford", Color = "Blue", Price = 20000, Image ="/../img/Ford.jpg"},
                new Auto{Brand = "Nisan", Color = "Yellow", Price = 15000, Image ="/../img/Nissan.jpg"},
                new Auto{Brand = "Ferrari", Color = "Red", Price = 100000, Image ="/../img/Ferrari.jpg"}             
            };
            return tmp;
        }
    }
}
