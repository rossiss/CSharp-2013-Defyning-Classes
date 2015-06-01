using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    public class Display
    {
        private float? width;
        private float? height;
        private double? colors;

        public Display()
        { }

        public Display(float? width, float? height)
            : this(width, height, null)
        { }

        public Display(double? colors)
            : this(null, null, colors)
        { }

        public Display(float? width, float? height, double? colors)
        {
            this.width = width;
            this.height = height;
            this.colors = colors;
        }

        public float? Width
        {
            get { return this.width; }
            set
            {
                if (width < 0)
                {
                    throw new ArgumentException("Incorrect entry! The width cannot be negative.");
                }
                this.width = value;
            }
        }

        public float? Height
        {
            get { return this.height; }
            set
            {
                if (height < 0)
                {
                    throw new ArgumentException("Incorrect entry! The height cannot be negative.");
                }
                this.height = value;
            }
        }

        public double? Colors
        {
            get { return this.colors; }
            set
            {
                if (colors < 0)
                {
                    throw new ArgumentException("Incorrect entry! The colors cannot be negative.");
                }
                this.colors = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Display width: {0}\nDisplay height: {1}\nDisplay colours: {2}\n",
                this.width, this.height, this.colors);
        }
    }
}
