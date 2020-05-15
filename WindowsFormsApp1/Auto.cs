using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApp1
{
    [Serializable]
    public class Auto : GroundTr
    {
        public string brand;
        public static List<Transport> autos = new List<Transport>();
        public string _brand { get { return brand; } set { brand = value; } }

        public Auto(string brand, int passengersNum, string bitmapPath, int weight, Wheels wheels) : base(wheels, weight, bitmapPath, passengersNum)
        {
            this.brand = brand;
            autos.Add(this);
        }

        public Auto()
        {
            
        }

        public override List<Transport> getList()
        {
            return autos;
        }
        public override string getTransportName()
        {
            return brand;
        }

        public override Bitmap getTransportBitmap()
        {
            return transportBitmap;
        }

        public override void removeTransportFromList(string transportName)
        {
            List<Transport> tr = new List<Transport>();
            foreach (Transport tran in autos)
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
            autos = tr;
        }

        public override List<string> getAllFieldsAsStringList()
        {
            List<string> a = new List<string>();
            a.Add("Capacity: " + capacity);
            a.Add("Weight: " + weight);
            a.Add("Wheels:");
            a.Add("\tQuantity: " + wheels._quantity);
            a.Add("\tDiameter: " + wheels._diameter);
            a.Add("\tType of tire: " + wheels._typeTire);
            return a;
        }

        public override void SetWheels(int quantity, float diameter, string typeTire)
        {
            wheels._quantity = quantity;
            wheels._diameter = diameter;
            wheels._typeTire = typeTire;
        }
    }
}
