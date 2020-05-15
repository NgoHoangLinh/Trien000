using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Plane : AirTr
    {
        int numWings;
        public string planeName;
        public static List<Transport> planes = new List<Transport>();
        public int _numWings { get { return numWings; } set { numWings = value; } }
        public string _planeName { get { return planeName; } set { planeName = value; } }

        public Plane(string bitmapPath, string planeName, int passengersNum, int weight, int numWings, float height) : base(height, weight, bitmapPath, passengersNum)
        {
            this.planeName = planeName;
            this.numWings = numWings;
            planes.Add(this);
        }

        public Plane()
        {
            
        }
        public override List<Transport> getList()
        {
            return planes;
        }
        public override string getTransportName()
        {
            return planeName;
        }

        public override Bitmap getTransportBitmap()
        {
            return transportBitmap;
        }

        public override void removeTransportFromList(string transportName)
        {
            List<Transport> tr = new List<Transport>();
            foreach (Transport tran in planes)
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
            planes = tr;
        }

        public override List<string> getAllFieldsAsStringList()
        {
            List<string> a = new List<string>();
            a.Add("Capacity: " + capacity);
            a.Add("Weight: " + weight);
            a.Add("Height: " + height);
            a.Add("Number of wings: " + numWings);
            return a;
        }

    }
}
