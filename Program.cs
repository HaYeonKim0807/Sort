using System;
using System.Collections.Generic;

namespace Sort
{
    class Program
    {
        class Monster
        {
            public int id;

            public Monster(int id) { this.id = id; }    
        }


        static void Main(string[] args)
        {
            List<int> list = new List<int>();



            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();
           for ( int i = 0; i < 10000; i++)
            {
                dic.Add(i, new Monster(i));
            }
            Monster mon;

            bool F = dic.TryGetValue(7777, out mon);

            dic.Remove(7777);
            dic.Clear();
        
        }
    }
}
