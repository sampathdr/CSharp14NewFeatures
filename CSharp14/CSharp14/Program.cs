using CSharp14.ExtensionMembers;
using CSharp14.PartialEventsAndConstructors;
using CSharp14.UserDefinedCompoundAssignmentOperators;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharp14
{
    internal class Program
    {
        private delegate bool TryParse<T>(string text, out T result);

        static void Main(string[] args)
        {
            //1) Extension Members
            Console.WriteLine($"***** 1) Extension Members *****");
            string example = "Hello World";
            Console.WriteLine($"Is the string ({example}) blank? {example.IsBlank}");
            Console.WriteLine($"Word count: {example.WordCount}");

            var list = new List<int> {};
            Console.WriteLine($"Is the list blank? {list.IsEmpty}");
            
            list.Add(1);
            Console.WriteLine($"Is the list blank? {list.IsEmpty}");
            Console.WriteLine();

            //2) Null-Conditional Assignment
            Console.WriteLine($"***** 2) Null-Conditional Assignment *****");
            User userJD = new User("John", "Doe");
            User userJS =new User("Jane", "Smith");

            Console.WriteLine($"Before null-conditional assignment: userJD: {userJD?.FirstName} {userJD?.LastName}");
            userJD ??= userJS;
            Console.WriteLine($"After null-conditional assignment: userJD: {userJD?.FirstName} {userJD?.LastName}");

            userJD = null;
            Console.WriteLine($"Before null-conditional assignment: userJD: {userJD?.FirstName} {userJD?.LastName}");
            userJD ??= userJS;
            Console.WriteLine($"After null-conditional assignment: userJD: {userJD?.FirstName} {userJD?.LastName}");

            //3) nameof Supports Unbound Generic Types
            Console.WriteLine($"***** 3) nameof Supports Unbound Generic Types *****");
            Console.WriteLine($"Name of List<>: {nameof(List<>)}");
            Console.WriteLine($"Name of List<int>: {nameof(List<int>)}");
            Console.WriteLine($"Name of Dictionary<,>: {nameof(Dictionary<,>)}");
            Console.WriteLine($"Name of Dictionary<int,int>: {nameof(Dictionary<int,int>)}");

            //4) More Implicit Conversions for Span<T> / ReadOnlySpan<T>
            Console.WriteLine($"***** 4) More Implicit Conversions for Span<T> / ReadOnlySpan<T> *****");
            ReadOnlySpan<char> span = "Hello World";
            Span<byte> buffer = stackalloc byte[128];
            int[] intArray = { 1, 2, 3, 4, 5 };
            ProcessData(intArray); // Array is implicitly convert in here.

            //5) Modifiers on Simple Lambda Parameters
            Console.WriteLine($"***** 5) Modifiers on Simple Lambda Parameters *****");
            TryParse<int> parse = (text, out result) => int.TryParse(text, out result);

            //6) Field-Backed Properties
            Console.WriteLine($"***** 6) Field-Backed Properties *****");
            var fbp = new FieldBackedProperties();
            fbp.Message = "Test";
            Console.WriteLine($"{fbp.Message}");

            //7) Partial Events and Constructors
            Console.WriteLine($"***** 7) Partial Events and Constructors *****");
            User user = new User("John", "Doe");
            Console.WriteLine($": {user?.FirstName} {user?.LastName}");

            //8) User-Defined Compound Assignment Operators
            Console.WriteLine($"***** 8) User-Defined Compound Assignment Operators *****");
            Bottle bottle = new Bottle(100);
            Console.WriteLine($":Bottle Capacity: {bottle.Capacity}, Volume: {bottle.Volume}");

            bottle += 30;
            Console.WriteLine($":Bottle Capacity: {bottle.Capacity}, Volume: {bottle.Volume}");

            Console.WriteLine("Hello, World!");
        }

        private static void ProcessData(Span<int> data)
        {
            //
        }
    }
}
