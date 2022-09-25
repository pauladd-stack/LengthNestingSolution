using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LengthNestingSolution.Classes
{
    public class Inventory : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string? propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ObservableCollection<InventoryItems> inventory = new ObservableCollection<InventoryItems>();

        public ObservableCollection<InventoryItems> InventoryList
        {
            get { return inventory; }
            set
            {
                inventory.Add(new InventoryItems());
                NotifyPropertyChanged(value.ToString());
                
            }


        }
        public class InventoryItems
        {
            public double Qty { get; set; }

            public double _length;
            public double Length
            {
                get { return _length; }
                set
                {
                    _length = Conversion.ftToMm(value);
                }
            }
            public override string ToString()
            {
                return "Qty: " + Qty.ToString() + " Length:" + Length.ToString();
            }
        }
        
        
    }

    
}
