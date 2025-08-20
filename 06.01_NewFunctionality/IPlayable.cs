using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._06._01_NewFunctionality
{
    partial interface IPlayable
    {
        void Play();
    }

    partial interface IPlayable
    {
        void Stop();
    }

    partial class Player: GenericPlayer
    {
        public void Play()
        {
            onPlayBegin();

            onPlayEnd();
        }
    }

    partial class Player : IPlayable
    {
        public void Stop()
        {

        }

        partial void onPlayBegin();
        partial void onPlayEnd();

    }

    class GenericPlayer
    {
        public string Manufacturer;
    }

    partial class Player
    {
        partial void onPlayBegin()
        {
            Console.WriteLine("Play begin");
        }

        partial void onPlayEnd()
        {
            Console.WriteLine("Play end");
        }
    }
}
