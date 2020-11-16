using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------");
            EdwardSays();
            EdwardAsks();
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

        static void EdwardAsks()
        {
            int attempt = 1;
            Random r = new Random();
            int secretNumber = r.Next(1, 100);
            while (attempt < 5)
            {

                Console.Write($"Guess a number: ");
                string response = Console.ReadLine().ToLower();

                if (secretNumber == int.Parse(response))
                {
                    attempt = 10;
                    EdwardCelebrates();
                }
                else
                {
                    int guessesLeft = 4 - attempt;
                    Console.WriteLine($"WRONG SUCKAH!   you have {guessesLeft} attempts remaining");
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
