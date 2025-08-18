using System;
using System.Collections.Generic;
namespace Training._02._04_AbstractClass
{
    class FileStream: Stream
    {
        public override void Open()
        {
            Console.WriteLine("Opening File Stream");
        }
    }
}
