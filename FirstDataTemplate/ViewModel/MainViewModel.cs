using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;

namespace FirstDataTemplate.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>

        public ObservableCollection<ItemVM> Items { get; set; }
        public ObservableCollection<string> PrioList { get; set; }
        public ItemVM NewItem { get; set; }
        public ItemVM SelectedItem { get; set; }
        public RelayCommand AddBtnClickCmd { get; set; }
        public RelayCommand DeleteBtnClickCmd { get; set; }

        public MainViewModel()
        {
            NewItem = new ItemVM();
            PrioList = new ObservableCollection<string>() { "Hoch", "Mittel", "Niedrig" };
            AddBtnClickCmd = new RelayCommand(
                //Action
                () => { Items.Add(NewItem); },
                () =>
                {
                    return NewItem.OrderId.Length > 0;
                });
        }
    }
}