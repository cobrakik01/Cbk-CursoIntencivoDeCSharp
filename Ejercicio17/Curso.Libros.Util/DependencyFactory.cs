using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Libros.Util
{
    public sealed class DependencyFactory
    {
        private static DependencyFactory df;

        private DependencyFactory()
            : base()
        {
        }

        public static DependencyFactory GetDependencyFactory()
        {
            if (df == null)
            {
                df = new DependencyFactory();
            }
            return df;
        }

        public object InitInyection(string dao)
        {
            object obj = null;
            Type t = Type.GetType(dao);
            System.Reflection.ConstructorInfo constructor = t.GetConstructor(new Type[] { });
            obj = constructor.Invoke(new object[] { });
            return obj;
        }
    }
}
