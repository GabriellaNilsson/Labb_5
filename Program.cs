namespace Labb_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating circle area object
            Circle myCircle = new Circle(5);
            Circle myCircle2 = new Circle(6);

            float area = myCircle.GetArea();
            float area2 = myCircle2.GetArea();

            // Create circle circumference/perimeter object
            Circle myCircumference = new Circle(5);
            float circumference = myCircumference.GetCircumference();

            // Create circle volume object
            Circle myVolume = new Circle(5);
            double volume = myVolume.GetVolume();

            // Create triangle area object
            Triangle myTriangle1 = new Triangle(5, 6);
            double areaTriangle = myTriangle1.GetAreaTriangle();

            // Create triangle circumfernece/perimeter object
            Triangle2 myTriangle2 = new Triangle2(5, 6, 7);
            int perimeter = myTriangle2.GetPerimeter();

            
            Console.WriteLine("The area of a circle with the radius of five is " + area + "!");
            Console.WriteLine("The area of a circle with the radius of six is " + area2.ToString("N3") + "!");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("The circumference of a sphere with the radius of five is " + circumference + "!");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("The volume of a sphere with the radius of five is " + volume.ToString("N3") + "!");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("The area of a triangle with a base of 5 and a height of 6 is " + areaTriangle + "!");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("The circumference of a triangle is " + perimeter + "!");

        }
    }
}