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
        public static EditAutosForm autoForm = new EditAutosForm(Form1.instance);
        public string _brand { get { return brand; } set { brand = value; } }
        private const string _CLASS_NAME = "Auto";
        static string CLASS_NAME { get { return _CLASS_NAME; } }

        public Auto(string brand, int passengersNum, int weight, Wheels wheels)
        {
            this.brand = brand;
            this.capacity = passengersNum;
            this.wheels = wheels;
            this.weight = weight;
            autos.Add(this);

            if (ProjectContainer.instance.getExistingForms(CLASS_NAME) == null)
            {
                ProjectContainer.instance.putNewForm(CLASS_NAME, autoForm);
            }
        }

        public Auto()
        {
            if (ProjectContainer.instance.getExistingForms(CLASS_NAME) == null)
            {
                EditAutosForm editForm = new EditAutosForm(Form1.instance);
                ProjectContainer.instance.putNewForm(CLASS_NAME, editForm);
            }
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
        public override string ToString()
        {
            return CLASS_NAME;
        }
    }
}
