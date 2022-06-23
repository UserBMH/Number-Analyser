
//Do while loop
int loop = 0;
Console.WriteLine("What is your name?");
string name = Console.ReadLine();


do
{
    //user enters int 1-100
    Console.WriteLine("Please enter number 1 - 100.");
    Console.WriteLine();
    int userNumber = int.Parse(Console.ReadLine());
    int userNumberModulus = userNumber % 2;
    


    //display result based on number

    Console.WriteLine(name + ", your choice is " + userNumber + "!");
   
    {
        
        if (userNumber < 1 || userNumber > 100)
        {
            Console.WriteLine("You know how to read??? Try again.");
            
            
        }

        //int is odd and < 60
        else if (userNumber < 60 && userNumberModulus == 1)
        {
            Console.WriteLine("Odd and less than 60!");
        }

        //int is even 2 < x 24
        else if (userNumber >= 2 && userNumber <= 24 && userNumberModulus == 0)
        {
            Console.WriteLine("Even and less than 25!");
        }

        //int is even 26 < x < 60
        else if (userNumber >= 26 && userNumber <= 60 && userNumberModulus == 0)
        {
            Console.WriteLine("Even and between 26 and 60 inclusive!");
        }

        //it is even and > 60
        else if (userNumber > 60 && userNumberModulus == 0)
        {
            Console.WriteLine("Even and greater than 60!");
        }

        //int is odd and > 60
        else if (userNumber > 60 && userNumberModulus == 1)
        {
            Console.WriteLine("Odd and greater than 60!");
        }

    }

    Console.WriteLine();
    Console.WriteLine("Press 1 to continue, or any other key to end.");
    int loopChoice = int.Parse(Console.ReadLine());
    if (loopChoice == 1)
    {

    }
    else
    {
        loop++;
    }


} while (loop == 0);


