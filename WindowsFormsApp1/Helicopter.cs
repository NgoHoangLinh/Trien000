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
        private const string _CLASS_NAME = "Helicopter";
        public static List<Transport> helicopters = new List<Transport>();
        public static EditHelicoptersForm planeForm = new EditHelicoptersForm(Form1.instance);
        static string CLASS_NAME { get { return _CLASS_NAME; } }
        public int _numBlades { get { return numBlades; } set { numBlades = value; } }
        public string _helicopterName { get { return helicopterName; } set { helicopterName = value; } }

        public Helicopter(string helicopterName, int passengersNum, int weight, int numBlades, float height)
        {
            this.helicopterName = helicopterName;
            this.capacity = passengersNum;
            this.numBlades = numBlades;
            this.weight = weight;
            this.height = height;
            helicopters.Add(this);

            if (ProjectContainer.instance.getExistingForms(CLASS_NAME) == null)
            {
                ProjectContainer.instance.putNewForm(CLASS_NAME, planeForm);
            }
        }

        public Helicopter()
        {
            if (ProjectContainer.instance.getExistingForms(CLASS_NAME) == null)
            {
                EditHelicoptersForm editForm = new EditHelicoptersForm(Form1.instance);
                ProjectContainer.instance.putNewForm(CLASS_NAME, editForm);
            }
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
        public override string ToString()
        {
            return CLASS_NAME;
        }
    }
}
