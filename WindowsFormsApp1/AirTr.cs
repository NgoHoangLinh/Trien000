using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public abstract class AirTr : Transport
    {
        protected float height;
        public float _height { get { return height; } set { height = value; } }
    }
}
