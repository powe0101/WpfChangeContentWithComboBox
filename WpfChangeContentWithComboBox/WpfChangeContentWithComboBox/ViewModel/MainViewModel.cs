using CommunityToolkit.Mvvm.Input;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfChangeContentWithComboBox.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class MainViewModel : ViewModelBase
    {
        public RelayCommand<string> OnSelectComboBox { get; set; }
        public string CurrentContentView { get; set; } = "DefaultContent";

        public MainViewModel()
        {
            OnSelectComboBox = new RelayCommand<string>(OnSelectComboBoxAction);
        }

        private void OnSelectComboBoxAction(string name)
        {
            Console.WriteLine("Selected Page : " + name);

            if(CurrentContentView != name)
                CurrentContentView = name;
        }
    }
}
