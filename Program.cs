namespace Labb5___Grunderna_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Circle Result1 = new Circle(5);
           Result1.getArea();
           Circle Result2 = new Circle(6);
           Result2.getArea();


        }
    }

    public class Circle
    {
       float _pi = 3.141f;
       int _Radius =0;

        public Circle(int Radius1)
        {
            _Radius =  Radius1;
        }

        public void getArea()
        {
            double area = 0;
           
            area = _pi* _Radius * _Radius;
          
            Console.WriteLine("Arean på cirkeln är: " + area);
        }

    }
    

}