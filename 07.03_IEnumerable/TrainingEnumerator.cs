using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._07._03_IEnumerable
{
    class TrainingEnumerator: IEnumerator<EnumerableTraining>
    {
        private int index; //Tracks the current index for iteration
        private List<EnumerableTraining> trainings; //Holds the list of trainings

        public TrainingEnumerator(List<EnumerableTraining> trainings)
        {
            this.index = -1;
            this.trainings = trainings;
        }

        public EnumerableTraining Current
        {
            get { return this.trainings[this.index]; }
        }

        object IEnumerator.Current
        {
            get
            {
                return ((IEnumerator<EnumerableTraining>) this).Current;
            }
        }

        public void Dispose()
        {
            //Not needed for now
        }

        public bool MoveNext()
        {
            this.index++;
            if(this.index >= this.trainings.Count)
            {
                return false;
            }

            return true;
        }

        public void Reset()
        {
            this.index = -1;
        }
    }
}
