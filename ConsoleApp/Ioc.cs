using Ninject;
using System;

namespace ConsoleApp
{
    class Ioc
    {
        private static Lazy<IKernel> _kernel = new Lazy<IKernel>(() => new StandardKernel());

        private static IKernel Kernel
        {
            get { return _kernel.Value; }
        }

        public static object Get(Type obj)
        {
            return Kernel.Get(obj);
        }

        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }

        public static void Init(Action<IKernel> initLogic)
        {
            initLogic?.Invoke(Kernel);
        }        
    }
}
