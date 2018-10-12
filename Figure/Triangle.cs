using System;

namespace Classes{

    public class Triangle : Figures {

        public Triangle(){
            this.setQuant(3);
        }

        public override float Area()
        {
            float s = (getAdd() / 2);
            float [] sides = getSides();
            return Convert.ToSingle((Math.Sqrt(s * (s - sides[0]) * (s - sides[1]) * (s - sides[2]))));
        }

        public override float Perimeter(){
            float add = getAdd();
            return add;
        }
    }
}