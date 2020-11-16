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
            while (attempt < 5)
            {

                Console.Write($"[try {attempt}] Guess a number: ");
                string response = Console.ReadLine().ToLower();
                int secretNumber = 42;

                if (secretNumber == int.Parse(response))
                {
                    Console.WriteLine("Nicely done!");
                    attempt = 10;
                    EdwardCelebrates();
                }
                else
                {
                    Console.WriteLine("WRONG SUCKAH!");
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
