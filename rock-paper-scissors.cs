using static System.Console;

namespace first
{
    class program
    {
        static void Main(string[] args)
        {
            bool gamestate = true;

            int computerpoint = 0;
            int playerpoint = 0;
            Random random = new Random();


            WriteLine("Welcome to my rock paper scissors game!");
            WriteLine("Its first to 3, you have " + playerpoint + " points and the computer has " + computerpoint + " points");

            while (gamestate == true)
            {
                
                WriteLine("Pick between rock paper or scissors");
                WriteLine();
                string playerinput = ReadLine(); 

                int computer = random.Next(1, 4);

                if (playerinput == "paper")
                {
                    if (computer == 1)
                    {
                        WriteLine("The computer chose rock");
                        WriteLine("Congrats you win!");
                        playerpoint += 1;
                    }
                    else if (computer == 2)
                    {
                        WriteLine("The computer chose paper");
                        WriteLine("It was a tie");
                    }
                    else if (computer == 3)
                    {
                        WriteLine("The computer chose scissors");
                        WriteLine("You lost");

                        computerpoint += 1;
                    }
                }
                else if (playerinput == "rock")
                {
                    if (computer == 1)
                    {
                        WriteLine("The computer chose rock");
                        WriteLine("It was a tie");
                    }
                    else if (computer == 2)
                    {
                        WriteLine("The computer chose paper");
                        WriteLine("You lost");
                        computerpoint += 1;
                    }
                    else if (computer == 3)
                    {
                        WriteLine("The computer chose scissors");
                        WriteLine("Congrats you win!");
                        playerpoint += 1;
                    }
                }
                else if (playerinput == "scissors")
                {
                    if (computer == 1)
                    {
                        WriteLine("The computer chose rock");
                        WriteLine("You lost");
                        computerpoint += 1;
                    }
                    else if (computer == 2)
                    {
                        WriteLine("The computer chose paper");
                        WriteLine("Congrats you win!");
                        playerpoint += 1;
                    }
                    else if (computer == 3)
                    {
                        WriteLine("The computer chose scissors");
                        WriteLine("It was a tie");
                    }
                }


                WriteLine("you: " + playerpoint + " computer: " + computerpoint);


                if (playerpoint == 3 || computerpoint == 3)
                {
                    gamestate = false;
                    if (computerpoint == 3)
                    {
                        WriteLine("The computer won, the score was, computer: " + computerpoint + " points. You: " + playerpoint + " points");

                    }
                    else if (playerpoint == 3)
                    {
                        WriteLine("You won! The score was, computer: " + computerpoint + " points. You: " + playerpoint + " points");

                    }
                    WriteLine("Type 'again' to play again or anything else to quit");
                    string answer = ReadLine();
                    if (answer == "again")
                    {
                        Clear();
                        gamestate = true;
                        computerpoint = 0;
                        playerpoint = 0;
                    }
                }
            }
        }
    }
}
