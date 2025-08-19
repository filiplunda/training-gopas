using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._05._04_UsingEvents
{
    class IntListWithChangedEvent : List<int>
    {
        public event ChangedEventHandler Changed;

        new public void Add(int value)
        {
            base.Add(value);
            //OnChanged(EventArgs.Empty);
            OnChanged(new ChangedEventArgs(ChangedEventState.Added));
        }

        new public void Clear()
        {
            base.Clear();
            //OnChanged(EventArgs.Empty);
            OnChanged(new ChangedEventArgs(ChangedEventState.Cleared));

        }

        new public int this[int index]
        {
            set 
            {
                base[index] = value;
                //OnChanged(EventArgs.Empty);
                OnChanged(new ChangedEventArgs(ChangedEventState.Changed));

            }
        }

        void OnChanged(ChangedEventArgs e)
        {
            if(Changed != null)
            {
                Changed(this, e);
            }
        }
    }
}
