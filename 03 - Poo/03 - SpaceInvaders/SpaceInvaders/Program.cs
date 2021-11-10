using System;

namespace SpaceInvaders
{
    class Program
    {
        static void Main(string[] args)
        {
            Invader i = new Invader();
            Space s = new Space(15, 15);
            s.ModifGrille(i);
            Console.WriteLine(s.ToString());
        }
    }
}
