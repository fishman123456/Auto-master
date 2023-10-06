using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfAutomobile.Infractructure;
using WpfAutomobile.Model;

namespace WpfAutomobile.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private Auto _selectedAuto;
        public ObservableCollection<Auto> Automobiles { get; set; }
        public Auto SelectedAuto
        {
            get => _selectedAuto;
            set
            {
                if (_selectedAuto != value)
                {
                    _selectedAuto = value;
                    OnPropertyChanged();
                }
            }
        }
        public MainWindowViewModel()
        {
            Automobiles = AutoRepository.Automobiles;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
