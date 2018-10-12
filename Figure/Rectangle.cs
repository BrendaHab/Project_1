namespace Classes{

    public class Rectangle : Figures {

        public Rectangle(){
        
            this.setQuant(2);
        }

        public override float Area()
        {
            float [] sides = getSides();
            
            return (sides[0] * sides[1]);
            
        }

        public override float Perimeter(){
            float add = getAdd();
            return (add*2);
        }
    }
}