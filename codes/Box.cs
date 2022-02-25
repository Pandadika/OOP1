using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1Opgave1.codes
{
    public enum BoxType
    {
        lilleBox,
        mediumBox,
        storBox
    }
    public class Box : IComparable<Box>
    {
        private double H { get;}
        private double W { get;}
        private double D { get;}
        private BoxType BoxType { get;}

        public Box(double h, double w, double d) {
            H = Math.Abs(h);
            W = Math.Abs(w); 
            D = Math.Abs(d); 
            BoxType = SetBoxType();
        }
        public Box() { 
            H = 1.0;
            W = 1.0;
            D = 1.0;
            BoxType = SetBoxType();
        }
        public double GetVolume()
        {
            return H * W * D;
        }

        public override string ToString()
        {
            string type = "";
            switch (BoxType)
            {
                case BoxType.lilleBox: type = "lille box";
                    break;
                case BoxType.mediumBox: type = "mellem box";
                    break;                
                case BoxType.storBox: type = "stor box";
                    break;
            }
             
            return $"Højde = {Math.Round(H,2)}, Længde = {Math.Round(W, 2)}, Dybde = {Math.Round(D, 2)}, Type = {type}";
        }

        
        private BoxType SetBoxType()

        {
            if (this.GetVolume() <= 50 )
            {
                return BoxType.lilleBox;
            }
            else if (this.GetVolume() > 50 && this.GetVolume() <= 100 )
            {
                return BoxType.mediumBox;
            }
            return BoxType.storBox;
        }

        public int CompareTo(Box? other)
        {
            if (other.GetVolume() > this.GetVolume()) return -1;
            if (other.GetVolume() == this.GetVolume()) return 0;
            return 1;
        }

        
        public static Box operator+(Box a, Box b)
        {   
            double side = Math.Cbrt(a.GetVolume()+b.GetVolume());
            return new(side,side,side);
        }

        public static Box operator*(Box a, Box b)
        {
            return new(a.H+b.H,a.W+b.W,a.D+b.D);
        }

    }
}
