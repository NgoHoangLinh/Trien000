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
        public static EditMotorBoatsForm motorBoatForm = new EditMotorBoatsForm(Form1.instance);
        private const string _CLASS_NAME = "MotorBoat";
        static string CLASS_NAME { get { return _CLASS_NAME; } }
        public int _motorPower { get { return motorPower; } set { motorPower = value; } }

        public MotorBoat()
        {
            if (ProjectContainer.instance.getExistingForms(CLASS_NAME) == null)
            {
                EditMotorBoatsForm editForm = new EditMotorBoatsForm(Form1.instance);
                ProjectContainer.instance.putNewForm(CLASS_NAME, editForm);
            }
        }

        public MotorBoat(string boatName, int motorPower, int passengersNum, int weight, float waterline)
        {
            this._motorPower = motorPower;
            this.boatName = boatName;
            this.capacity = passengersNum;
            this.weight = weight;
            this.waterline = waterline;
            motorBoats.Add(this);

            if (ProjectContainer.instance.getExistingForms(CLASS_NAME) == null)
            {
                ProjectContainer.instance.putNewForm(CLASS_NAME, motorBoatForm);
            }
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
        public override string ToString()
        {
            return CLASS_NAME;
        }
    }
}
