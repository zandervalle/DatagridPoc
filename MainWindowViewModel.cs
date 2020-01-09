using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DatagridPoc
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<MyEntity> _myCollection;
        public ObservableCollection<MyEntity> MyCollection
        {
            get => _myCollection;
            set
            {
                _myCollection = value;
                OnPropertyChanged(nameof(MyCollection));
            }
        }

        public MainWindowViewModel()
        {
            MyCollection = new ObservableCollection<MyEntity>
            {
                new MyEntity { MyEntityId = 1, Description = "Some Description", Value = 74.28 },
                new MyEntity { MyEntityId = 2, Description = "Some more Description", Value = 32.32 }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
