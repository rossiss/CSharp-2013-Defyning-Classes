using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    class Call
    {
        private string date;
        private string time;
        private int dialed;
        private int duration;

        public string Date
        { 
            get { return this.date; }
            set { this.date = value; }
        }

        public string Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        public int Dialed
        {
            get { return this.dialed; }
            set { this.dialed = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
    }
}
