using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab
{
    class DVD : Movie
    {
        private bool watchAgain = true;

        public DVD(string Title, Genre Genre, int RunTime, List<string> Scenes)
            : base(Title, Genre, RunTime, Scenes )
        {

        }


        public override void Play()
        {
            while (watchAgain)
            {
                Console.WriteLine("What scene would you like to watch? Select 1-5 or type 9 to watch the whole movie: ");
                int input = int.Parse(Console.ReadLine()) - 1;
                if (input < 5 && input >= 0)
                {
                    Console.WriteLine($"Scene {input +1} -  {Scenes[input]}");
                }
                else
                {
                    PrintScenes();
                }
                Console.WriteLine();
                watchAgain = StartAgain("Do you want to enter another scene? y/n: "); 
            }
        }
        public bool StartAgain(string message)
        {
            Console.WriteLine(message);
            String userReply = Console.ReadLine().ToLower();

            if (userReply == "y")
            {
                return true;
            }

            else if (userReply == "n")
            {
                Console.WriteLine("Ok, Lets go back to Blockbuster and return this movie");
                return false;
            }
            return false;
        }
    }
}
