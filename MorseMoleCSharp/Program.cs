using System;


static class MorseMoleCSharp
{
    public static void Main()
    {
        // Make sure the random numbers are really random
        Random rnd = new Random();

        Console.Clear();
        Console.Title = "Morse Mole";

        // Draw the compass
        Console.SetCursorPosition(60, 1);
        Console.Write("N");
        Console.SetCursorPosition(60, 2);
        Console.Write("|");
        Console.SetCursorPosition(57, 3);
        Console.Write("W--+--E");
        Console.SetCursorPosition(60, 4);
        Console.Write("|");
        Console.SetCursorPosition(60, 5);
        Console.Write("S");

        Console.SetCursorPosition(51, 7);
        Console.Write("M O R S E   M O L E");

        // Make a 20x20 screen
        Console.BackgroundColor = (ConsoleColor)7; // White
        for (var z = 1; z <= 21; z++) // This is 20 lines
        {
            Console.SetCursorPosition(2, z);
            Console.WriteLine("                                          "); // This is 42 spaces (21x2)
        }

        // Set the position of mole
        int molex = rnd.Next(21);
        int moley = rnd.Next(21);

        // Uncomment these lines if you wish to cheat
        // Console.SetCursorPosition((molex * 2) + 2, (moley + 1))
        // Console.BackgroundColor = 4 'Red
        // Console.Write("  ") ' 2 spaces

        // Set your position
        int playerx = rnd.Next(21);
        int playery = 20;

        Console.SetCursorPosition((playerx * 2) + 2, (playery + 1));
        Console.BackgroundColor = (ConsoleColor)10; // Bright Green
        Console.Write("  "); // 2 spaces

        string direction;
        int steps;

        // Your Move
        for (var m = 1; m <= 10; m++) // You get 10 goes
        {
            Console.BackgroundColor = 0; // Set this back to black

            Console.SetCursorPosition(2, 24);
            Console.WriteLine("Direction? (N,S,E or W)                    ");
            Console.WriteLine("                                           "); // Blank out the line underneath
            Console.SetCursorPosition(26, 24);
            direction = Console.ReadLine().ToUpper(); // Get a direction (in capitals)

            Console.SetCursorPosition(2, 25);
            Console.Write("How many steps?               ");
            Console.SetCursorPosition(18, 25);
            steps = System.Convert.ToInt32(Console.ReadLine());

            // Leave a trail where you've been
            Console.SetCursorPosition((playerx * 2) + 2, (playery + 1));
            Console.BackgroundColor = (ConsoleColor)2; // Dark Green
            Console.Write("  "); // 2 spaces

            // Work out your new position
            if (direction == "N")
                playery = playery - steps;
            if (direction == "S")
                playery = playery + steps;
            if (direction == "E")
                playerx = playerx + steps;
            if (direction == "W")
                playerx = playerx - steps;

            // Check to see if you are still in the square
            if (playerx < 0)
                playerx = 0;
            if (playerx > 20)
                playerx = 20;
            if (playery < 0)
                playery = 0;
            if (playery > 20)
                playery = 20;

            // Show your new position
            Console.SetCursorPosition((playerx * 2) + 2, (playery + 1));
            Console.BackgroundColor = (ConsoleColor)10; // Light Green
            Console.Write("  "); // 2 spaces

            // Have you found the mole?
            if (moley == playery & molex == playerx)
            {
                // Show the mole
                Console.SetCursorPosition((molex * 2) + 2, (moley + 1));
                Console.BackgroundColor = (ConsoleColor)4; // Red
                Console.Write("><"); // 2 spaces

                Console.BackgroundColor = 0; // Set this back to black
                Console.SetCursorPosition(2, 24);
                Console.WriteLine("You found the mole! Well done!             ");
                Console.WriteLine("  Press ENTER to quit                      ");

                // Victory
                Console.Beep(130, 100);
                Console.Beep(262, 100);
                Console.Beep(330, 100);
                Console.Beep(392, 100);
                Console.Beep(523, 100);
                Console.Beep(660, 100);
                Console.Beep(784, 300);
                Console.Beep(660, 300);
                Console.Beep(146, 100);
                Console.Beep(262, 100);
                Console.Beep(311, 100);
                Console.Beep(415, 100);
                Console.Beep(523, 100);
                Console.Beep(622, 100);
                Console.Beep(831, 300);
                Console.Beep(622, 300);
                Console.Beep(155, 100);
                Console.Beep(294, 100);
                Console.Beep(349, 100);
                Console.Beep(466, 100);
                Console.Beep(588, 100);
                Console.Beep(699, 100);
                Console.Beep(933, 300);
                Console.Beep(933, 100);
                Console.Beep(933, 100);
                Console.Beep(933, 100);
                Console.Beep(1047, 400);

                Console.ReadLine();
                System.Environment.Exit(0);
            }
            else
            {
                // Mole's response
                if (moley > playery)
                {
                    Console.Beep(261, 200);
                    Console.Beep(261, 200);
                    Console.Beep(261, 200);
                }
                if (moley < playery)
                {
                    Console.Beep(261, 500);
                    Console.Beep(261, 200);
                }
                if (molex > playerx)
                    Console.Beep(329, 200);
                if (molex < playerx)
                {
                    Console.Beep(329, 200);
                    Console.Beep(329, 500);
                    Console.Beep(329, 500);
                }
            }
        }
        // No more moves = you lost

        // Show the mole
        Console.SetCursorPosition((molex * 2) + 2, (moley + 1));
        Console.BackgroundColor = (ConsoleColor)4; // Red
        Console.Write("><"); // 2 spaces

        Console.BackgroundColor = 0; // Set this back to black
        Console.SetCursorPosition(2, 24);
        Console.WriteLine("You didn't find the mole.                  ");
        Console.WriteLine("  Press ENTER to quit                      ");

        // Play sad trombone
        Console.Beep(131, 500);
        Console.Beep(261, 500);
        Console.Beep(247, 500);
        Console.Beep(233, 500);
        Console.Beep(220, 1000);

        Console.ReadLine();
        System.Environment.Exit(0);
    }
}
