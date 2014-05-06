namespace MobilePhoneDevice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GSM
    {   // 01 
        private string model;
        private string manufacturer;
        private  int price;
        private string owner;
        private Battery battery;
        private Display display;
        static private GSM iphone = new GSM("Iphone4s", "Apple");

        //02
        public string Model
        {
            get { return this.model;}

            set {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("Enter name for the phone model");
                    }
                    else
                    {
                        this.model = value;
                    }
                }
        }

        public string Manufacturer
        {
            get { return this.manufacturer;}
            set {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("Enter name of the phone manufacturer");
                    }
                    else
                    {
                        this.manufacturer = value;
                    }
                }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Enter name of the phone owner");
                }
                else
                {
                    this.owner = value;
                }
            }
        }

        public int Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Enter correct price, please");
                }
                else
                {
                    this.price = value;
                }
            }
        }
        public Battery mybattery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display mydisplay
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public static GSM IPhone4S
        {
            get { return iphone; }
        }

        public GSM(string model, string manufacturer) : this(model,manufacturer, null) {}
      

        public GSM(string model, string manufacturer, string owner, int? price, int? batteryhours, int? batteryidle, int? numberofcolors, int? size)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.owner = owner;
            this.price = price;
            this.battery.HoursTalk = batteryhours;
            this.battery.HoursIdle = batteryidle;
            this.display.NumberOfColors = numberofcolors;
            this.display.Size = size;

        }
        
    }
        
}
