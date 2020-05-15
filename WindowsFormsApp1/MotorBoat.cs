using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class MotorBoat : WaterTr
    {
        int motorPower;
        public static List<Transport> motorBoats = new List<Transport>();
        public int _motorPower { get { return motorPower; } set { motorPower = value; } }

        public MotorBoat()
        {
            
        }

        public MotorBoat(string bitmapPath, string boatName, int motorPower, int passengersNum, int weight, float waterline) : base(waterline, boatName, weight, bitmapPath, passengersNum)
        {
            _motorPower = motorPower;
            motorBoats.Add(this);
        }

        public override List<Transport> getList()
        {
            return motorBoats;
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
            foreach (Transport tran in motorBoats)
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
            motorBoats = tr;
        }

        public override List<string> getAllFieldsAsStringList()
        {
            List<string> a = new List<string>();
            a.Add("Capacity: " + capacity);
            a.Add("Weight: " + weight);
            a.Add("Motor power:" + motorPower);
            a.Add("Waterline:" + waterline);
            return a;
        }
    }
}
