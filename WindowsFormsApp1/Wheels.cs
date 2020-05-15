using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Wheels 
    {
        int quantity;
        float diameter;
        string typeTire;

        public int _quantity { get { return quantity; } set { quantity = value; } }
        public float _diameter { get { return diameter; } set { diameter = value; } }
        public string _typeTire { get { return typeTire; } set { typeTire = value; } }

        public Wheels()
        {
            
        }

        public Wheels(int quantity, float diameter, string typeTire) {
            this.quantity = quantity;
            this.diameter = diameter;
            this.typeTire = typeTire;
        }



    }
}
