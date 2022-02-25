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
        public double H { get;}
        public double W { get;}
        public double D { get;}
        public BoxType BoxType { get;}

        public Box(double h, double w, double d, BoxType boxType) {
            H = Math.Abs(h);
            W = Math.Abs(w); 
            D = Math.Abs(d); 
            BoxType = boxType;
        }
        public Box() { 
            H = 1.0;
            W = 1.0;
            D = 1.0;
            BoxType = BoxType.lilleBox;
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
             
            return $"Højde = {H}, Længde = {W}, Dybde = {D}, Type = {type}";
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
            return new Box(side,side,side,(a*b).BoxType);
        }

        public static Box operator*(Box a, Box b)
        {
            BoxType boxType;
            if (a.BoxType==BoxType.lilleBox && b.BoxType == BoxType.lilleBox)
            {
                boxType = BoxType.mediumBox;
            }
            else boxType = BoxType.storBox;
            Box result = new(a.H+b.H,a.W+b.W,a.D+b.D, boxType);
            return result;
        }



    }
}
