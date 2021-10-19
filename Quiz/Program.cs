using System;



Console.Title = "Quiz";

Console.WriteLine("Welcome to my quiz!!!");
Console.WriteLine("You will have three choices!");
Console.WriteLine("Choose between a, b or c\n");

int s = Questions();
Bonus(s);
Restart();

Console.ReadLine();



static void Bonus(int score)    
{

    string answer;

    if (score == 5)
    {
        Console.WriteLine("Well done now you get a bonus question\n");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Using only addition, how do you add eight 8’s and get the number 1000?");
        Console.WriteLine("Tip! You can merge the 8's together");
        Console.ResetColor();

        answer = Console.ReadLine();
        if (answer == "888+88+8+8+8")
        {
            score++;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Correct \n");
            Console.ResetColor();
            Console.WriteLine($"Your score is {score} out of 6");
            Restart();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Wrong \n");
            Console.ResetColor();
            Console.WriteLine("The correct answer is 888+88+8+8+8");
            Console.WriteLine($"Your score is {score} out of 6");
            Restart();
        }
    }
}

static int Questions()
{
    string answer = "";
    int score = 0;


    while (answer != "a" && answer != "b" && answer != "c")
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("What is 2+5?");
        Console.ResetColor();
        Console.WriteLine("a) 1\nb) 100\nc) 7");

        answer = Console.ReadLine();
        Console.Clear();
    }

    if (answer == "c")
    {
        score++;
    }
    else { }

    answer = "";

    while (answer != "a" && answer != "b" && answer != "c")
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("What is 3+5?");
        Console.ResetColor();
        Console.WriteLine("a) 1\nb) 8\nc) 100");

        answer = Console.ReadLine();
        Console.Clear();
    }

    if (answer == "b")
    {
        score++;
    }
    else { }

    answer = "";

    while (answer != "a" && answer != "b" && answer != "c")
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("If 1=3, 2=3, 3=5, 4=4, 5=4, then what is 6=?");
        Console.ResetColor();
        Console.WriteLine("a) 3\nb) 4\nc) 5");

        answer = Console.ReadLine();
        Console.Clear();
    }

    if (answer == "a")
    {
        score++;
    }
    else { }

    answer = "";

    while (answer != "a" && answer != "b" && answer != "c")
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("What is the first 6 decimals of PI");
        Console.ResetColor();
        Console.WriteLine("a) 3.142592\nb) 3.141592\nc) 3.141591");

        answer = Console.ReadLine();
        Console.Clear();
    }
    if (answer == "b")
    {
        score++;
    }
    else { }


    answer = "";

    while (answer != "a" && answer != "b" && answer != "c")
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("What is 9 squared?");
        Console.ResetColor();
        Console.WriteLine("a) 72\nb) 3\nc) 81");

        answer = Console.ReadLine();
        Console.Clear();
    }
    if (answer == "c")
    {
        score++;
    }
    else { }

    if (score <= 2)
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else if (score > 2 && score <= 4)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
    }
    else { Console.ForegroundColor = ConsoleColor.Green; }

    Console.WriteLine("You have completed the quiz!");
    Console.WriteLine($"Your score is {score} out of 5");
    if (score < 5)
    {
        Restart();
    }

    return score;
}


static void Restart()
{

    string answer;

    Console.WriteLine("If you want to play again press 'R'");

    answer = Console.ReadLine();
    answer = answer.ToLower();
    if (answer == "r")
    {
        Console.Clear();
        int s = Questions();
        Bonus(s);
        Restart();
    }
}


