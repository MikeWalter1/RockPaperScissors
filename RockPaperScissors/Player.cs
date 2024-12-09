using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Player
    {
        public string Name;
        public int Points;

        public Player()
        {
            Console.WriteLine("Enter your name: ");
            Name = Console.ReadLine();
        }
    }

}
