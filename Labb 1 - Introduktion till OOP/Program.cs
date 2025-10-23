namespace Labb_1___Introduktion_till_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //i created 2 new radiuses.
            Circle radie1 = new Circle(5);
            Circle radie2 = new Circle(6);

            //Here i call for the methods to the radiuses that  i created in the Circle.cs
            //so it does the calucaltion in the console
            radie1.GetArea();
            radie1.GetCircumference();
            radie1.GetVolume();

            radie2.GetArea();
            radie2.GetCircumference();
            radie2.GetVolume();
        }
    }
}
