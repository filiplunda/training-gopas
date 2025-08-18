using System;
using System.Collections.Generic;
namespace Training._02._04_AbstractClass
{
    class MemoryStream: Stream
    {
        public override void Open()
        {
            Console.WriteLine("Opening Memory Stream");
        }
    }
}
