using System;
using System.Collections;
using System.Collections.Generic;

namespace OddOneOutTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] animal = { "Cat", "Dog", "Mouse" };
            Random rand = new Random();
               
            int x = rand.Next(0, 3);


            List<Player> players = new List<Player>();
            Boolean a = true;
            while(a == true)
            {
                Console.WriteLine("enter name");
                string name = Console.ReadLine();
                if(name != " ")
                {
                    Player player = new Player(name);
                    players.Add(player);
                }
                else
                {
                    a = false;
                }
            }


            int y = rand.Next(0, 5);

            for (int i = 0; i < players.Count; i++)
            {
                if (i != y)
                    Console.WriteLine(players[i].Name.ToString() + animal[x]);
                else
                    Console.WriteLine(players[i].Name + " Guess the animal");
            }


            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine(players[i].Name + " Vote for a player");
                string guess = Console.ReadLine();
                for (int j = 0; j < players.Count; j++)
                {
                    if (guess == players[j].Name.ToString())
                    {
                        if (players[i].Name == players[j].Name || guess == null)
                        {
                            Console.WriteLine("cant vote for yourself");
                            i -= 1;
                            
                        }
                        else
                        {
                            players[j].addVote();
                        }

                    }

                }
            }

            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine(players[i].Name.ToString() + " votes: " + players[i].getVote);

            }

            int max = players[0].getVote;
            
            for(int i =0; i<players.Count; i++)
            {
                int value = players[i].getVote;
                if (value > max)
                    max = value; 
                
            }
            Console.WriteLine(max);

        }
    }
}
