using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stackqu
{
    public class Queau
    {
        public static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);



            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }

        }
    }
}

    

