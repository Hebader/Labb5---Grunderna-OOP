namespace Labb5___Grunderna_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Circle Result1 = new Circle(5); //Räknar ut arean av radien som är 5
           Result1.getArea(); // Kör metoden från klassen "Circle"
           Circle Result2 = new Circle(6); //Räknar ut arean av radien som är 6
           Result2.getArea();
        }
    }

    public class Circle // Skapar klassen Circle
    {
       float _pi = 3.141f;
       int _Radius =0;

        public Circle(int Radius1) // Skapar en konstruktor
        {
            _Radius =  Radius1;
        }

        public void getArea() // denna metod reutnerar värdet av arean
        {
            double area = 0; // skapar en double för att "_pi" är ett decimaltal
           
            area = _Radius * _Radius *_pi; // Beräkning av area
          
            Console.WriteLine("Arean på cirkeln är: " + area); //Utskrift
        }

    }
    

}