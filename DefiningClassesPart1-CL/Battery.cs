using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    public class Battery
    {
        private string modelBattery;
        private float? idleHours;
        private float? talkHours;
        private BatteryType.Types? type;

        public Battery(string modelBattery)
            : this(modelBattery, null, null, null)
        { }

        public Battery(BatteryType.Types? type)
            : this(null, null, null, type)
        { }

        public Battery(float? talkHours, float? idleHours)
            : this(null, talkHours, idleHours, null)
        { }

        public Battery(string modelBattery, float? idleHours, float? talkHours)
            : this(modelBattery, idleHours, talkHours, null)
        { }

        public Battery(string modelBattery, float? idleHours, float? talkHours, BatteryType.Types? type)
        {
            this.modelBattery = modelBattery;
            this.idleHours = idleHours;
            this.talkHours = talkHours;
            this.type = type;
        }

        public BatteryType.Types? Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string ModelBattery
        {
            get { return this.modelBattery; }
            set { this.modelBattery = value; }
        }

        public float? IdleHours
        {
            get { return this.idleHours; }
            set { this.idleHours = value; }
        }

        public float? TalkHours
        {
            get { return this.talkHours; }
            set { this.talkHours = value; }
        }

        public override string ToString()
        {
            return string.Format("Battery model: {0}\nBattery type: {1}\nBattery idle hours: {2}\nBattery talk hours: {3}\n",
                this.modelBattery, this.type, this.idleHours, this.talkHours);
        }
    }
}
