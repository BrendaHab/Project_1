using System;
namespace Classes{

    public class Circle : Figures {

        public Circle(){
            this.setQuant(1);
        }

        public override float Area()
        {
            return (Convert.ToSingle(Math.PI) * getAdd() * getAdd());
        }

        public override float Perimeter(){
            float add = getAdd();
            return (add * 2 * Convert.ToSingle(Math.PI));
        }
    }
}