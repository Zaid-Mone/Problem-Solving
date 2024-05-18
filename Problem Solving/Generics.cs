using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    public static class Generics<T> where T : class, new()
    {
        public static T GetInstance()
        {
            T instance;
            instance = new T();
            return instance;
        }
    }
}
