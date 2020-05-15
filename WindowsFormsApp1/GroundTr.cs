using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public abstract class GroundTr : Transport
    {

        protected Wheels wheels;
        public abstract void SetWheels(int quantity, float diameter, string typeTire);
        public Wheels _wheels {get { return wheels; } set { wheels = value; } }

        public GroundTr()
        {

        }

        public GroundTr(Wheels wheels, int weight, string bitmapPath, int capacity) : base(weight, bitmapPath, capacity)
        {
            this.wheels = wheels;
        }

    }
}
