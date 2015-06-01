using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        public static GSM iPhone;
        
        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null, null)
        { }

        public GSM(string model, string manufacturer, decimal? price)
            : this(model, manufacturer, price, null)
        { }

        public GSM(string model, string manufacturer, decimal? price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name too short! It should be at least 3 letters");
                }
                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (price < 0)
                {
                    throw new ArgumentException("Incorrect entry! The price cannot be negative.");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name too short! It should be at least 3 letters");
                }
                this.owner = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Manufacturer: {0}\n Phone model: {1}\nPrice: {2:C}\nOwner:",
                this.manufacturer, this.model, this.price, this.owner));
            
            if (this.battery != null)
            {
                sb.Append(string.Format("{0}", this.battery.ToString()));
            }
            if (this.display != null)
            {
                sb.Append(string.Format("{0}", this.display.ToString()));
            }

            return sb.ToString();
        }


        public static GSM IPhone
        {
            get { 
                iPhone.model = "iPhone 4S";
                iPhone.manufacturer = "Apple";
                iPhone.price = 1000;
                iPhone.battery.ModelBattery = "non removable";
                iPhone.battery.IdleHours = 200;
                iPhone.battery.TalkHours = 14;
                iPhone.battery.Type = BatteryType.Types.LiPoly;
                iPhone.display.Width = 640;
                iPhone.display.Height = 960;
                return iPhone; 
            }
        }
        static void Main(string[] args)
        {


        }
    }
}
