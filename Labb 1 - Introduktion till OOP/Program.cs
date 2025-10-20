namespace Labb_1___Introduktion_till_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle radie1 = new Circle(5);
            Circle radie2 = new Circle(6);

            radie1.GetArea();
            radie1.GetCircumference();
            radie1.GetVolume();

            radie2.GetArea();
            radie2.GetCircumference();
            radie2.GetVolume();
        }
    }
}
