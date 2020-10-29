using System;
using System.Collections.Generic;

namespace Blockbuster_Lab
{
    class Blockbuster
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public Blockbuster()
        {
            List<string> fbScenes = new List<string>();
            fbScenes.Add("~~Previews~~ ***FBI WARNING***");
            fbScenes.Add("I'm too sick to go to school - fooling parents and getting ready");
            fbScenes.Add("People notice Ferris is not there, his sister gets jealous and the principal starts gettig suspicious");
            fbScenes.Add("Running around town having an awesome time **being super cool**");
            fbScenes.Add("Racing to get back home before everyone notices");
            VHS v1 = new VHS("Ferris Bueller's Day Off", Genre.Comedy , 103, fbScenes, 0);

            Movies.Add(v1);

            List<string> pgScenes = new List<string>();
            pgScenes.Add("~~Previews~~ ***FBI WARNING***");
            pgScenes.Add("Carol Ann starts talking to the TV.... They're Heeereee");
            pgScenes.Add("Everything starts getting sucked into the closet");
            pgScenes.Add("The team of ghost whisperers show up and try to pull Carol Ann from the upside down");
            pgScenes.Add("Pack up to move from the house and they get one last visit before they go");
            VHS v2 = new VHS("Poltergeist", Genre.Horror, 114, pgScenes, 0);

            Movies.Add(v2);

            List<string> obScenes = new List<string>();
            obScenes.Add("~~Previews~~ ***FBI WARNING***");
            obScenes.Add("Joanna falls off the yacht, gets amnesia");
            obScenes.Add("Annie is stressed in the house with the unruly boys and mess");
            obScenes.Add("Annie starts to like her life, they build a mini gold range");
            obScenes.Add("Joanna's mom makes her husband go get her, but she's now in love with Dean *smooches*");
            VHS v3 = new VHS("Overboard", Genre.Romance, 112, obScenes, 0);

            Movies.Add(v3);



            List<string> fvScenes = new List<string>();
            fvScenes.Add("Picking up the family truckster");
            fvScenes.Add("Driving and mishaps, Clark notices the woman driving flashy car");
            fvScenes.Add("Stop at Cousin Eddie's to pick up Aunt Edna");
            fvScenes.Add("Crash and lose everything");
            fvScenes.Add("Arrive at WallyWorld");
            DVD d1 = new DVD("National Lampoon's Family Vacation", Genre.Comedy , 98, fvScenes);

            Movies.Add(d1);

            List<string> twScenes = new List<string>();
            twScenes.Add("Young Jo and family hide out in cellar when tornado rips through their property");
            twScenes.Add("Jo builds a few machines to launch into a tornado to gather weather info");
            twScenes.Add("Big tornado, DORORTHY breaks");
            twScenes.Add("Another tornado, another broken DOROTHY");
            twScenes.Add("Last tornado!! DOROTHY takes flight!!");
            DVD d2 = new DVD("Twister", Genre.Action, 113, twScenes);

            Movies.Add(d2);

            List<string> ciScenes = new List<string>();
            ciScenes.Add("Catherine meets young Cecille, who she is going to take under her wing");
            ciScenes.Add("Catherine and Sebastian make a bet");
            ciScenes.Add("Backstabbing and romance");
            ciScenes.Add("Catherine tries to settle up with a now unavailable Sebastian");
            ciScenes.Add("Funeral, finding journal, driving off in the car");
            DVD d3 = new DVD("Cruel Intentions", Genre.Drama, 97, twScenes);

            Movies.Add(d3);


        }
        public void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];
                Console.WriteLine($"{i+1}: {m.Title}");
            }
        }

        public Movie Checkout()
        {

            Console.WriteLine("Please select a movie from the following list: ");
            PrintMovies();
            string input = Console.ReadLine();
            int index = int.Parse(input) -1;
            return Movies[index];
        }

    }
}
