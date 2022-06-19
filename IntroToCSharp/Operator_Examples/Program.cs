class OperatorsExamples
{
    static void Main()
    {
        //  Arithmetocal Operators
        decimal a = 10M;
        decimal b = 3M;
        decimal c = a + b; // output = 13
        decimal d = a - b; // output = 7
        decimal e = a * b; // output = 30
        decimal f = a / b; // output = 3.33333
        decimal g = a % b; // output = 1

        // Assignment operators
        a += 20M; // output = 30
        a -= 20M; // output = 10
        a *= 3M;  // output = 30
        a /= 3M;  // output = 10
        a %= 3M;  // output = 1

        // Increment, decrement operators
        a = 10M;
        ++a; // output = 11. Preincrement
        a++; // output = 12. Postincrement
        --a; // output = 11. Predecrement
        a--; // output = 10. Postdecrement

        // Comparison operatores
        bool b1 = a == 10; // output = true
        bool b2 = a == 11; // output = false
        bool b3 = a != 10; // output = false
        bool b4 = a < 10;  // output = false
        bool b5 = a > 5;   // output = true
        bool b6 = a <= 10; // output = true
        bool b7 = a >= 10; // output = true

        // Logical operators
        bool b8 = a == 10 & b == 10;  // output = false
        bool b9 = a == 10 && b == 10; // output = false
        bool b10 = a == 10 | b == 10; // output = true
        bool b11 = a == 10 || b == 10; // output = true
        bool b12 = !(a == 10); // output = false
        bool b13 = a == 10 ^ b == 10; // output = true

        // Concatenation Operator
        string name = "Damilare";
        string age = "20";
        string message = "Hey " + name + " you are " + age + " years old.";
        System.Console.WriteLine(message);

        // Tenary Operators
        int StudentAge = 20;
        string title = (StudentAge < 13) ? "Child" : (StudentAge >= 13 && StudentAge <= 19) ? "Tennager" : "Adult";
        // System.Console.WriteLine(title);

        System.Console.WriteLine("Please enter feet amount below: ");
        double feet = Convert.ToDouble(System.Console.ReadLine());

        System.Console.WriteLine("Please enter inches amout below: ");
        double inches = Convert.ToDouble(System.Console.ReadLine());

        double ConvertedFeet = feet * 12;
        double convertedInches = inches * 2.54;

        System.Console.WriteLine(Convert.ToString(ConvertedFeet + convertedInches));
    }
}