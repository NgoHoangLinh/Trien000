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
        private const string _CLASS_NAME = "Plane";
        static string CLASS_NAME { get { return _CLASS_NAME; } }
        public static List<Transport> planes = new List<Transport>();
        public static EditPlanesForm planeForm = new EditPlanesForm(Form1.instance);
        public int _numWings { get { return numWings; } set { numWings = value; } }
        public string _planeName { get { return planeName; } set { planeName = value; } }

        public Plane(string planeName, int passengersNum, int weight, int numWings, float height)
        {
            this.planeName = planeName;
            this.capacity = passengersNum;
            this.numWings = numWings;
            this.weight = weight;
            this.height = height;
            planes.Add(this);

            if (ProjectContainer.instance.getExistingForms(CLASS_NAME) == null)
            {
                ProjectContainer.instance.putNewForm(CLASS_NAME, planeForm);
            }
        }

        public Plane()
        {
            if (ProjectContainer.instance.getExistingForms(CLASS_NAME) == null)
            {
                EditPlanesForm editForm = new EditPlanesForm(Form1.instance);
                ProjectContainer.instance.putNewForm(CLASS_NAME, editForm);
            }
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
        public override string ToString()
        {
            return CLASS_NAME;
        }

    }
}
