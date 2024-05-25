using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;
using System.Windows.Threading;

namespace Clicker
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();

        public string DisplayName { get; internal set; }
        public bool ThrowOnInvalidPropertyName { get; private set; }
        public Counter MainCounter { get; }
        public ICommand ClickCommand { get; private set; }
        public ICommand BuyCommand { get; private set; }
        public Upgrade DoubleClick { get; } 
        public Upgrade IdleClick { get; } 

        public ViewModelBase()
        {
            DoubleClick = new Upgrade("Double Click", 20);
            IdleClick = new Upgrade("Idle Click", 10);
            MainCounter = new Counter();
            BuyCommand = new RelayCommand(Buy, CanBuyUpgrade);
            ClickCommand = new RelayCommand(ClickCounter, CanClickCounter);
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);

            dispatcherTimer.IsEnabled = false;
        }

        private void dispatcherTimer_Tick(object? sender, EventArgs e)
        {
            MainCounter.CountClick();
            OnPropertyChanged(nameof(MainCounter));
        }

        private void Buy(object obj)
        {

            var up = obj as Upgrade;

            MainCounter.Count -= up.Cost;
            up.Buy();
            if(up == IdleClick)
            {
                dispatcherTimer.IsEnabled = true;
                dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1500 - IdleClick.Count * 150);
            }
            OnPropertyChanged(nameof(MainCounter));




        }
        private bool CanBuyUpgrade(object obj)
        {
            var up = obj as Upgrade;
            if (up != null && MainCounter.Count > (int)up.Cost)
            {
                return true;
            }
            else
            {
                return false;
            }

            
            
        }

        private bool CanClickCounter(object obj)
        {
            return true;
        }

        private void ClickCounter(object obj)
        {
            if (DoubleClick.Count != 0)
            {
                for(int i = 0; i <= DoubleClick.Count; i++)
                {
                    MainCounter.CountClick();
                }
            }
            else
            {
                MainCounter.CountClick();
            }
            
            OnPropertyChanged(nameof(MainCounter));
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }
        public void VerifyPropertyName(string propertyName)
        {
            // Verify that the property name matches a real, 
            // public, instance property on this object. 
            if (TypeDescriptor.GetProperties(this)[propertyName] == null)
            {
                string msg = "Invalid property name: " + propertyName;
                if (this.ThrowOnInvalidPropertyName)
                    throw new Exception(msg);
                else
                    Debug.Fail(msg);
            }
        }
    }
}
