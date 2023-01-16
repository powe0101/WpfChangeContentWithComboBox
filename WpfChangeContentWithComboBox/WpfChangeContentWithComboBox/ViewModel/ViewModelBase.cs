using CommunityToolkit.Mvvm.ComponentModel;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfChangeContentWithComboBox.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public abstract class ViewModelBase : ObservableObject
    {
        public string Title { get; set; }
    }
}
