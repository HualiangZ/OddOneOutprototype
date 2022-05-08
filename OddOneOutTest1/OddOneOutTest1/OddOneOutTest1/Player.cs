using System;
using System.Collections.Generic;
using System.Text;

namespace OddOneOutTest1
{
    class Player
    {
        String name;
        int votes;
        public Player(String name)
        {
            this.name = name;
            votes = 0;
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }


        public void addVote()
        {
            votes += 1;
        }

        public int getVote
        {
            get { return votes; }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
