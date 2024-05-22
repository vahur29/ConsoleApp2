namespace ConsoleApp2
{
    using System;

    namespace CSharpConcepts
    {
        public enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        public interface IMovable
        {
            void Move();
        }

        public class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Eating...");
            }
        }

        public class Dog : Animal, IMovable
        {
            public void Bark()
            {
                Console.WriteLine("Barking...");
            }

            public void Move()
            {
                Console.WriteLine("Dog is moving...");
            }
        }

        public struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        public static class Utility
        {
            public static void PrintMessage(string message)
            {
                Console.WriteLine(message);
            }
        }

        public class Program
        {
            public int PublicProperty { get; set; }
            private int PrivateProperty { get; set; }
            protected int ProtectedProperty { get; set; }
            internal int InternalProperty { get; set; }

            public abstract class Example
            {
                public abstract void AbstractMethod();
            }

            public class ConcreteExample : Example
            {
                public override void AbstractMethod()
                {
                    Console.WriteLine("Abstract method implemented.");
                }
            }

            public sealed class SealedExample
            {
                public void Method()
                {
                    Console.WriteLine("Sealed class method.");
                }
            }

            static void Main(string[] args)
            {
                Car myCar = new Car { Make = "Toyota", Model = "Camry", Year = 2021 };
                myCar.Drive();
                Console.WriteLine($"Car Make: {myCar.Make}, Model: {myCar.Model}, Year: {myCar.Year}");

                Point p = new Point { X = 10, Y = 20 };
                Console.WriteLine($"Point coordinates: X = {p.X}, Y = {p.Y}");

                Dog myDog = new Dog();
                myDog.Eat();
                myDog.Bark();
                myDog.Move();

                DaysOfWeek today = DaysOfWeek.Monday;
                Console.WriteLine($"Today is: {today}");

                int? nullableInt = null;
                if (nullableInt.HasValue)
                {
                    Console.WriteLine(nullableInt.Value);
                }
                else
                {
                    Console.WriteLine("No value");
                }

                var person = (Name: "John", Age: 30);
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

                Utility.PrintMessage("Hello from the Utility class!");

                Program program = new Program();
                program.PublicProperty = 100;
                program.InternalProperty = 400;

                Console.WriteLine($"PublicProperty: {program.PublicProperty}");
                Console.WriteLine($"InternalProperty: {program.InternalProperty}");

                ConcreteExample concreteExample = new ConcreteExample();
                concreteExample.AbstractMethod();

                SealedExample sealedExample = new SealedExample();
                sealedExample.Method();
            }
        }

        public class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }

            public void Drive()
            {
                Console.WriteLine("Driving the car...");
            }
        }
    }
}
