class Samplebank
{
    static void Main()
    {
        // Declaring variables
        string userName = null;
        string passWord = null;
        int userChoice = 0;


        // Display titles 
        System.Console.WriteLine("********** Sample Bank **********");
        System.Console.WriteLine(":: Login Page ::");

        // Collect creds
        System.Console.WriteLine("Please enter your username below");
        userName = System.Console.ReadLine();

        if (userName != "")
        {
            System.Console.WriteLine("Please enter your password below");
            passWord = System.Console.ReadLine();
        }
        else
        {
            System.Console.WriteLine("Username is empty!");
        }

        // validate creds
        if (userName == "admin" && passWord == "admin")
        {
            do
            {
                System.Console.WriteLine("\n ::: Main Menu :::");
                System.Console.WriteLine("1: Customers");
                System.Console.WriteLine("2: Accounts");
                System.Console.WriteLine("3: Transfers");
                System.Console.WriteLine("4: Account stements");
                System.Console.WriteLine("0: Exit");

                System.Console.WriteLine("Please enter your choice below: ");
                userChoice = Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case 1: CustomersMenu(); break;
                    case 2: AccountMenu(); break;
                    case 3: System.Console.WriteLine("Transferring $50 to deposit account"); break;
                    case 4: System.Console.WriteLine("Your last transfer was yesterday"); break;
                    case 0: System.Console.WriteLine("Exsiting banking options"); break;
                    default: System.Console.WriteLine("You entered the wrong choice. Please try again!"); break;
                }

            } while (userChoice != 0);
        }
        else
        {
            System.Console.WriteLine("You've entered either a Wrong username or password!");
        }

        System.Console.WriteLine("Thank you for using the Sample bank. Please do visit again!");
    }

    static void CustomersMenu()
    {
        int menuChoice = 0;
        do
        {
            System.Console.WriteLine("\n ::: Customer Menus :::");
            System.Console.WriteLine("1: Add customers");
            System.Console.WriteLine("2: Delete customers");
            System.Console.WriteLine("3: update customers");
            System.Console.WriteLine("4: view customers");
            System.Console.WriteLine("0: Back to main menu");

            System.Console.WriteLine("Please enter your choice below: ");
            menuChoice = Convert.ToInt32(System.Console.ReadLine());
        } while (menuChoice != 0);

    }

    static void AccountMenu()
    {
        int accountChoice = 0;

        do
        {
            System.Console.WriteLine("\n ::: Account menus :::");
            System.Console.WriteLine("1: Add account");
            System.Console.WriteLine("2: Delete account");
            System.Console.WriteLine("3: update account");
            System.Console.WriteLine("4: view account");
            System.Console.WriteLine("0: Back to main menu");

            System.Console.WriteLine("Please enter your choice below: ");
            accountChoice = Convert.ToInt32(System.Console.ReadLine());
        } while (accountChoice != 0);
    }
}