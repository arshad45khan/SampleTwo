using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.BLL
{
    public class Factory <K, T> where T: class, K, new()
    {
        public static K CreateModule()
        {
            K mymodule;
            mymodule = new T();
            return mymodule;
        }
    }
}
