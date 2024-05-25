using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clicker
{
    public class Upgrade: INotifyPropertyChanged
    {
        public int Cost { get { return cost; } set { if (value == cost) return; cost = value; OnPropertyChanged();  } }
        public string Name { get { return name; } set { if (value == name) return; name = value; OnPropertyChanged(); } }
        private string name;
        private int cost;
        public int Count { get { return count; }  set { if (value == count) return; count = value; OnPropertyChanged(); } }
        private int count;

        public Upgrade(string Name, int Cost) 
        { 
            this.name = Name;
            this.cost = Cost;
            
        }
        public void Buy()
        {
            Count++;
            Cost = Cost * count + Cost / count;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
