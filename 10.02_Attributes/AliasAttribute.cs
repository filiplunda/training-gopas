using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Training._10._02_Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    class AliasAttribute: Attribute
    {
        public string Name { get; set; }

        public AliasAttribute(string name)
        {
            this.Name = name;
        }
    }

    class AttributeHelper 
    {
        public static IEnumerable<string> GetAliases(object o)
        {
            foreach(var field in o.GetType().GetProperties())
            {
                foreach(AliasAttribute item in field.GetCustomAttributes(typeof(AliasAttribute), true))
                {
                    yield return item.Name;
                }
            }
        }

        public static void Validate(object o)
        {
            Type objType = o.GetType();
            //Loop through all properties
            foreach (PropertyInfo p in objType.GetProperties())
            {
                //for every property loop through all attributes
                foreach(Attribute a in p.GetCustomAttributes(false))
                {
                    if(a is ValidatorAttribute)
                    {
                        ValidatorAttribute c = (ValidatorAttribute)a;
                        if(c.MaxLenght < (p.GetValue(o, null) as string).Length)
                        {
                            throw new Exception("Max lenght issues");
                        }
                    }
                }
            }
        }
    
    }
}
