using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public abstract class WaterTr : Transport
    {
        protected float waterline;
        protected string boatName;
        public string _boatName { get { return boatName; } set { boatName = value; } }
        public float _waterline { get { return waterline; } set { waterline = value; } }

        public WaterTr()
        {

        }
        public WaterTr(float waterline, string boatName, int weight, string bitmapPath, int capacity) : base(weight, bitmapPath, capacity)
        {
            this.waterline = waterline;
            this.boatName = boatName;
        }
    }
}
