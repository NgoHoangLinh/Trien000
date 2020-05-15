using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class HandBoat : WaterTr
    {
        public static List<Transport> handBoats = new List<Transport>();
        int paddles;
        public int _paddles { get { return paddles; } set { paddles = value; } }


        public HandBoat()
        {
            
        }

        public HandBoat(string boatName, int paddles, string bitmapPath, int passengersNum, int weight, float waterline) : base(waterline, boatName, weight, bitmapPath, passengersNum)
        {
            this.paddles = paddles;
            handBoats.Add(this);
        }
        public override List<Transport> getList()
        {
            return handBoats; 
        }
        public override string getTransportName()
        {
            return boatName;
        }

        public override Bitmap getTransportBitmap()
        {
            return transportBitmap;
        }

        public override void removeTransportFromList(string transportName)
        {
            List<Transport> tr = new List<Transport>();
            foreach (Transport tran in handBoats)
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
            handBoats = tr;
        }

        public override List<string> getAllFieldsAsStringList()
        {
            List<string> a = new List<string>();
            a.Add("Capacity: " + capacity);
            a.Add("Weight: " + weight);
            a.Add("Number of paddles:" + paddles);
            a.Add("Waterline:" + waterline);
            return a;
        }
    }
}
