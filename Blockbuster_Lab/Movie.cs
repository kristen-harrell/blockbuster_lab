using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab
{
    abstract class Movie
    {
        public string Title {get; set;}
        public Genre Genre {get; set;}
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string Title, Genre Genre, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Genre = Genre;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }

       // public GetScenes(string)
       // {
            //get the scenes here
      //  }


        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Runtime: {RunTime}");
            //PrintScenes();    
        }

        public void PrintScenes()
        {
                Console.WriteLine();
            for (int i = 0; i < Scenes.Count; i++)
            {
                string scene = Scenes[i];
                Console.WriteLine($"Scene {i+1}: {scene}");
            }
        }
        public abstract void Play();
    



    }
}
