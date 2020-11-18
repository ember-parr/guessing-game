using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------");
            EdwardSays();
            StartGame();
        }



        static void EdwardSays()
        {
            Console.WriteLine($@"
.     .       .  .   . .   .   . .    +  .
  .     .  :     .    .. :. .___---------___.
       .  .   .    .  :.:. _'.^ .^ ^.  '.. :'-_. .
    .  :       .  .  .:../:            . .^  :.:\.
        .   . :: +. :.:/: .   .    .        . . .:\
 .  :    .     . _ :::/:               .  ^ .  . .:\
  .. . .   . - : :.:./.                        .  .:\
  .      .     . :..|:                    .  .  ^. .:|
    .       . : : ..||        .                . . !:|
  .     . . . ::. ::\(                           . :)/
 .   .     : . : .:.|. ######              .#######::|
  :.. .  :-  : .:  ::|.#######           ..########:|
 .  .  .  ..  .  .. :\ ########          :######## :/
  .        .+ :: : -.:\ ########       . ########.:/
    .  .+   . . . . :.:\. #######       #######..:/
      :: . . . . ::.:..:.\           .   .   ..:/
   .   .   .  .. :  -::::.\.       | |     . .:/
      .  :  .  .  .-:.':.::.\             ..:/
 .      -.   . . . .: .:::.:.\.           .:/
.   .   .  :      : ....::_:..:\   ___.  :/    Hello Human,
   .   .  .   .:. .. .  .: :.:.:\       :/      Welcome to my guessing game...
     +   .   .   : . ::. :.:. .:.|\  .:/|           You have 4 guesses    
     .         +   .  .  ...:: ..|  --.:|
.      . . .   .  .  . ... :..:..'(  ..)'
 .   .       .      :  .   .: ::/  .  .::\ 
 

            ");
        }

        static void StartGame()
        {
            Console.Write(@"
                Please select a difficulty level:
                EASY [press 1]
                    8 tries to guess the correct number
                MEDIUM [press 2]
                    6 tries to guess the correct number
                HARD [press 3]
                    4 tries to guess the correct number
                CHEATER [press 9]
                    9999 tries to guess the correct number
                ");
            string response = Console.ReadLine();
            int difficulty = int.Parse(response);
            EdwardAsks(difficulty);
        }

        static void EdwardAsks(int difficulty)
        {
            int maxAttempts = 0;
            if (difficulty == 1)
            {
                maxAttempts = 8;
            }
            if (difficulty == 2)
            {
                maxAttempts = 6;
            }
            if (difficulty == 3)
            {
                maxAttempts = 4;
            }
            if (difficulty == 4)
            {
                maxAttempts = 9999;
            }
            int attempt = 1;
            Random r = new Random();
            int secretNumber = r.Next(1, 100);
            while (attempt <= maxAttempts)
            {

                Console.Write($"{secretNumber} Guess a number: ");
                string response = Console.ReadLine().ToLower();

                if (secretNumber == int.Parse(response))
                {
                    EdwardCelebrates();
                    break;
                }
                else if (secretNumber > int.Parse(response))
                {
                    int guessesLeft = maxAttempts - attempt;
                    Console.WriteLine($"you guessed too low!   you have {guessesLeft} attempts remaining");
                    attempt++;
                }
                else if (secretNumber < int.Parse(response))
                {
                    int guessesLeft = maxAttempts - attempt;
                    Console.WriteLine($"you guessed too high!   you have {guessesLeft} attempts remaining");
                    attempt++;
                }
            }
        }

        static void EdwardCelebrates()
        {
            Console.WriteLine(@"
     /    \ _| /
     q .. p \ /
      \--/  //
     __||__//
    /.    _/
   // \  /                 you got it!
  //   ||
  \\  /  \
   )\|    |
  / || || |
  |/\| || |
     | || |
     \ || /
   __/ || \__
  \____/\____/
            ");
        }
    }




}
