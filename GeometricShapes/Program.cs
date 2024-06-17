namespace GeometricShapes;

internal class Program {
    static void Main(string[] args) {

        sqr s1 = new sqr(6);
        Console.WriteLine($"Perimeter is {s1.Perimeter()} and area is {s1.Area()}");


        Rect r1 = new Rect(5, 10);
        Console.WriteLine($"Perimeter is {r1.Perimeter()} and area is {r1.Area()}");


        Quads q1 = new Quads(3, 4, 5, 6);

        Console.WriteLine($"Perimeter is {q1.Perimeter()}");

        Quads q2 = new Quads(11, 12, 13, 14);

        Console.WriteLine($"Perimeter is {q2.Perimeter()}");

    }
}
