using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._05._04_UsingEvents
{
    delegate void ChangedEventHandler(object sender, ChangedEventArgs e);

    class ChangedEventArgs : EventArgs
    {
        public ChangedEventState ChagedState { get; set; }

        public ChangedEventArgs(ChangedEventState chagedState)
        {
            ChagedState = chagedState;
        }
    }
}
