using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Train : GroundTr
    {
        public string route;
        public int numCarriage;
        public static List<Transport> trains = new List<Transport>();
        public static EditTrainsForm trainForm = new EditTrainsForm(Form1.instance);

        private const string _CLASS_NAME = "Train";
        static string CLASS_NAME { get { return _CLASS_NAME; } }

        public string _route { get { return route; } set { route = value; } }
        public int _numCarriage { get { return numCarriage; } set { numCarriage = value; } }

        public Train(string route, int passengersNum, int weight, int numCarriage, Wheels wheels)
        {
            this.route = route;
            this.capacity = passengersNum;
            this.wheels = wheels;
            this.weight = weight;
            this.numCarriage = numCarriage;
            trains.Add(this);

            if (ProjectContainer.instance.getExistingForms(CLASS_NAME) == null)
            {
                ProjectContainer.instance.putNewForm(CLASS_NAME, trainForm);
            }
        }

        public Train()
        {
            if (ProjectContainer.instance.getExistingForms(CLASS_NAME) == null)
            {
                EditTrainsForm editForm = new EditTrainsForm(Form1.instance);
                ProjectContainer.instance.putNewForm(CLASS_NAME, editForm);
            }
        }

        public override List<Transport> getList()
        {
            return trains;
        }
        public override string getTransportName()
        {
            return route;
        }

        public override Bitmap getTransportBitmap()
        {
            return transportBitmap;
        }

        public override void removeTransportFromList(string transportName)
        {
            List<Transport> tr = new List<Transport>();
            foreach (Transport tran in trains)
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
            trains = tr;
        }

        public override List<string> getAllFieldsAsStringList()
        {
            List<string> a = new List<string>();
            a.Add("Capacity: " + capacity);
            a.Add("Weight: " + weight);
            a.Add("Number of carriages: " + numCarriage);
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

        public override string ToString()
        {
            return CLASS_NAME;
        }
    }
}
