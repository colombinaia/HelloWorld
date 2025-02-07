using System;

namespace DIKUCanteen
{
    class Program
    {
        static void Main(string[] args)
        {
            var canteen = new Canteen("DIKU Canteen", 10);
            var student = new Student("Alice", "Student", 22);
            var boardMember = new CanteenBoardMember("Bob", "Board Member", 25);

            Console.WriteLine(canteen);

            student.TakeCup(canteen);
            Console.WriteLine($"{student.Name} took a cup. {canteen}");

            student.ReturnCup(canteen);
            Console.WriteLine($"{student.Name} returned a cup. {canteen}");

            boardMember.BuyCup(canteen);
            Console.WriteLine($"{boardMember.Name} bought a cup. {canteen}");
        }
    }
}
