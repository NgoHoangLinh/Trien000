using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Helicopter : AirTr
    {
        int numBlades;
        public string helicopterName;
        public static List<Transport> helicopters = new List<Transport>();
        public int _numBlades { get { return numBlades; } set { numBlades = value; } }
        public string _helicopterName { get { return helicopterName; } set { helicopterName = value; } }

        public Helicopter(string bitmapPath, string helicopterName, int passengersNum, int weight, int numBlades, float height) : base(height, weight, bitmapPath, passengersNum)
        {
            this.helicopterName = helicopterName;
            this.numBlades = numBlades;
            helicopters.Add(this);
        }

        public Helicopter()
        {

        }
        public override List<Transport> getList()
        {
            return helicopters;
        }
        public override string getTransportName()
        {
            return helicopterName;
        }

        public override Bitmap getTransportBitmap()
        {
            return transportBitmap;
        }

        public override void removeTransportFromList(string transportName)
        {
            List<Transport> tr = new List<Transport>();
            foreach (Transport tran in helicopters)
            {
                if (tran.getTransportName() == transportName)
                {
                    continue;
                }
                else
                {
                    tr.Add(tran);
                }
            }
            helicopters = tr;
        }

        public override List<string> getAllFieldsAsStringList()
        {
            List<string> a = new List<string>();
            a.Add("Capacity: " + capacity);
            a.Add("Weight: " + weight);
            a.Add("Height: " + height);
            a.Add("Number of blades: " + numBlades);
            return a;
        }
    }
}
