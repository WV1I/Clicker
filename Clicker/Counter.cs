using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clicker
{
    public class Counter : INotifyPropertyChanged
    {
        
        public int Count { get { return count; } set { if (value == count) return; count = value; OnPropertyChanged(); } }
        private int count; 
        public int TotalCount { get { return totalcount; } set { if (value == totalcount) return; totalcount = value; OnPropertyChanged(); } }
        private int totalcount;


        public event PropertyChangedEventHandler? PropertyChanged;

        public void CountClick()
        {
            count++;
            totalcount++;
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
