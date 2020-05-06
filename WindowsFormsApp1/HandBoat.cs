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
        public static EditHandBoatsForm handBoatForm = new EditHandBoatsForm(Form1.instance);
        int paddles;
        private const string _CLASS_NAME = "HandBoat";
        static string CLASS_NAME { get { return _CLASS_NAME; } }
        public int _paddles { get { return paddles; } set { paddles = value; } }


        public HandBoat()
        {
            if (ProjectContainer.instance.getExistingForms(CLASS_NAME) == null)
            {
                EditHandBoatsForm editForm = new EditHandBoatsForm(Form1.instance);
                ProjectContainer.instance.putNewForm(CLASS_NAME, editForm);
            }
        }

        public HandBoat(string boatName, int paddles, int passengersNum, int weight, float waterline) {
            this.paddles = paddles;
            this.boatName = boatName;
            this.capacity = passengersNum;
            this.weight = weight;
            this.waterline = waterline;
            handBoats.Add(this);

            if (ProjectContainer.instance.getExistingForms(CLASS_NAME) == null)
            {
                ProjectContainer.instance.putNewForm(CLASS_NAME, handBoatForm);
            }
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
        public override string ToString()
        {
            return CLASS_NAME;
        }
    }
}
