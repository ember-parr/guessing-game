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
     +   .   .   : . ::. :.:. .:.|\  .:/|
     .         +   .  .  ...:: ..|  --.:|
.      . . .   .  .  . ... :..:..'(  ..)'
 .   .       .      :  .   .: ::/  .  .::\ 
 

            ");
        }

        static void EdwardAsks()
        {
            Console.Write("Guess a number: ");
            string response = Console.ReadLine().ToLower();
            int secretNumber = 42;

            if (secretNumber == int.Parse(response))
            {
                Console.WriteLine("Nicely done!");
            }
            else
            {
                Console.WriteLine("WRONG SUCKAH!");
            }






        }
    }




}
