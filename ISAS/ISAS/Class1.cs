using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAS
{
    class Class1
    {
        public static bool hai(object obj, Type t)
        {
            try
            {
                Type[] types = obj.GetType().GetInterfaces();
                foreach (Type type1 in types)
                {
                    if (type1 == t)
                    {
                        return true;
                    }
                }
                while (true)
                {
                    if ((obj.ToString()) == (t.ToString()))
                    {
                        return true;
                    }
                    object instance = Activator.CreateInstance(obj.GetType().BaseType);
                    obj = instance;
                }
            }
            catch (ArgumentNullException)
            {


                return false;
            }

            catch (MissingMethodException)
            {
                if ((obj.GetType().ToString()) == (t.ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }
    }
}
