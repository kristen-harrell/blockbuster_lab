using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0; //<-- you can do this to give this property an initial value and you can do this anywhere
        

        public VHS(string Title, Genre Genre, int RunTime, List<string> Scenes, int CurrentTime)
            :base(Title, Genre, RunTime, Scenes)
        {
            this.CurrentTime = CurrentTime;
        }
        public override void Play()
        {
            while (CurrentTime < Scenes.Count)
            {
                string scene = Scenes[CurrentTime];
                Console.WriteLine($"Scene {CurrentTime}: {scene}");
                CurrentTime++;
            }
            if(CurrentTime > Scenes.Count - 1)
            {
                Console.WriteLine();
                Console.WriteLine("Please be kind, and press any key to rewind: ");
                Console.ReadLine();
                Rewind();


            }

        }

        public void Rewind()
        {
            CurrentTime = 0;
        }

        
       
    }
}
