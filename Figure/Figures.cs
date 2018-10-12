using System;

namespace Classes{

    public class Figures : Operations
    {

        private float[] sides;
        private int quantSides;

        public void setQuant(int quant){
            this.quantSides = quant;
            sides = new float[quantSides];
        }
        public int getQuant(){
            return quantSides;
        }

        public bool Sides(){
            if ((sides.GetLength(quantSides)) > 0){
                return true;
            } else { 
                return false;
            }
        }

        public void setSides(){
            Console.WriteLine(string.Format("Se ingresaran {0} numeros.", quantSides));
            for(int i = 0; i < quantSides; i++){
                sides[i] = enterNumber();
            }
        }

        public float getAdd(){
            float add = 0;
            for(int i = 0; i < quantSides; i++){
                add+= sides[i];
            }
            return add;
        }
        public float[] getSides(){
            return sides;
        }

        private float enterNumber(){
            Console.WriteLine("Ingrese un numero, puede ser flotante.");
            float number = float.Parse(Console.ReadLine());
            return number;
        }
        public override float Perimeter()
        {
            throw new System.NotImplementedException();
        }

        public override float Area()
        {
            throw new System.NotImplementedException();
        }

    }
}