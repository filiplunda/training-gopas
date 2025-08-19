using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._03._02_ArrayAndCollections
{
    class TrainingId
    {
        public string Prefix;
        public int Code;
        
        public TrainingId(string prefix, int code)
        {
            Prefix = prefix;
            Code = code;
        }

        public override string ToString()
        {
            return$"{this.Prefix}{this.Code}";
        }

        public override bool Equals(object obj)
        {
            TrainingId? t = obj as TrainingId;
            if (t == null) return false;

            if ((t.Prefix == this.Prefix) && (t.Code == this.Code))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }

}
