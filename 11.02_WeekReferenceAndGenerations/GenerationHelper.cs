using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._11._02_WeekReferenceAndGenerations
{
    class GenerationHelper
    {
        StringBuilder sb;
        WeakReference<StringBuilder> wr;

        public void UseObject()
        {
            if (wr == null || !wr.TryGetTarget(out sb))
            {
                sb = new StringBuilder("Hello world");
                wr = new WeakReference<StringBuilder>(sb);
                Console.WriteLine("Created new");
            }

            Console.WriteLine($"Used: {sb.ToString()}");
        }

        public void AllowObjectToBeGarbaged()
        {
            sb = null;
            Console.WriteLine("Allowed to be garbaged");
        }

        public bool IsAllive()
        {
            return wr.TryGetTarget(out _);
        }

        public void ShowGenInfo()
        {
            if (IsAllive())
            {
                if (sb != null)
                {
                    Console.WriteLine($"MaxGeneration: {GC.MaxGeneration}, " + $"ObjectGeneration: {GC.GetGeneration(sb)}");
                }
                else
                {
                    Console.WriteLine($"Still Alive");
                }
            }
            else
            {
                Console.WriteLine("Not Alive");
            }
        }
    }
}
