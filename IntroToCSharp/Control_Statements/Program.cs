class ControlStatements
{

    // Control statements are generally used to control program execution flow.

    // Conditional control statements 
    // if (simple-if, if-else, else-if, nested-if).
    // switch-case.

    // Looping control statements
    // while , do-while, for.

    // Jumpting control statements
    // go-to, break, continue.

    static void Main()
    {
        // int marks = 70;
        // char studentGrade;

        // simple if statement

        // if (marks >= 35)
        // {
        //     System.Console.WriteLine("Congratulations you passed the examination");
        // }

        // if-ese statement
        // if (marks >= 35)
        // {
        //     System.Console.WriteLine("Congratulations, you passed the examination!");
        // }
        // else
        // {
        //     System.Console.WriteLine("Unfortunately you failed the exam. Please go prepeare again and retake the class!");
        // }

        // else-if statement
        // if (marks > 20)
        // {
        //     System.Console.WriteLine("Congratulations. You passed with  flying colors");
        // }
        // else if (marks == 20)
        // {
        //     Console.WriteLine("Congratulations. You passed the examination!");
        // }
        // else
        // {
        //     Console.WriteLine("Unfortunately. You failed the examination");
        // }


        // Nested If statement
        // if (marks > 35)
        // {
        //     if (marks > 85)
        //     {
        //         studentGrade = 'A';
        //         Console.WriteLine(studentGrade);
        //     }
        //     else if (marks >= 60 && marks < 85)
        //     {
        //         studentGrade = 'B';
        //         Console.WriteLine(studentGrade);
        //     }
        //     else if (marks >= 50 && marks < 60)
        //     {
        //         studentGrade = 'C';
        //         Console.WriteLine(studentGrade);
        //     }
        //     else if (marks >= 40 && marks < 50)
        //     {
        //         studentGrade = 'D';
        //         Console.WriteLine(studentGrade);
        //     }
        // }
        // else
        // {
        //     studentGrade = 'F';
        //     Console.WriteLine(studentGrade);
        // }

        // Switch-case statements
        // Console.WriteLine("Pleas enter student grade below: ");
        // char gradeLetter = Convert.ToChar(Console.ReadLine());

        // string gradeDescription;

        // switch (gradeLetter)
        // {
        //     case 'O': gradeDescription = "Outstanding"; break;
        //     case 'A': gradeDescription = "Excellent"; break;
        //     case 'B': gradeDescription = "Good"; break;
        //     case 'C': gradeDescription = "Average"; break;
        //     case 'F': gradeDescription = "Fail"; break;
        //     default: gradeDescription = "None. Student either did not take the exam or was absen. "; break;
        // }

        // Console.WriteLine(gradeDescription);

        // while loop
        // int i = 1;

        // while (i <= 10)
        // {
        //     Console.WriteLine(i);
        //     i++;

        // }

        // do while loop
        // bool gameOn = true;


        // do
        // {
        //     Console.WriteLine("Please enter your name below: ");
        //     string name = Console.ReadLine();

        //     if (name == "damilare")
        //     {
        //         gameOn = false;
        //     }

        // } while (gameOn);

        // For loop 
        for (int j = 0; j <= 10; j++)
        {
            Console.WriteLine(j);
        }
    }
}