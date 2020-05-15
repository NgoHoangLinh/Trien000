using System;
using System.Collections.Generic;
using System.Drawing;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    [Serializable]
    public abstract class Transport
    {
        public int capacity = 0;
        protected int weight = 0;
        string bitmapPath = "";
        public int _weight { get { return weight; } set { weight = value; } }
        public string _bitmapPath { get { return bitmapPath; } set { bitmapPath = value; } }

        public int _capasity { get { return capacity; } set { capacity = value; } }

        [JsonIgnore, NonSerialized]
        public Bitmap transportBitmap;
        public Transport()
        {

        }

        public Transport(int weight, string bitmapPath, int capacity)
        {
            this.weight = weight;
            this.bitmapPath = bitmapPath;
            this.capacity = capacity;
        }

        public abstract List<Transport> getList();
        public abstract string getTransportName();
        public abstract Bitmap getTransportBitmap();
        public abstract void removeTransportFromList(string transportName);
        public abstract List<string> getAllFieldsAsStringList();
    }
}
