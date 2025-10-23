namespace Labb_1___OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Console.WriteLine($"Arean med radien 5: {circle1.GetArea()}\n");
            Console.WriteLine($"Omkrets med radien 5: {circle1.Circumference()}\n");
            Console.WriteLine($"Volymen med radien 5: {circle1.Volume()}\n");

            Circle circle2 = new Circle(6);
            Console.WriteLine($"Arean med radien 6: {circle2.GetArea()}\n");
            Console.WriteLine($"Omkrets med radien 6: {circle2.Circumference()}\n");
            Console.WriteLine($"Volymen med radien 6:{circle2.Volume()}");


        }
    }
}
