using ConsoleApp.Checker;
using ConsoleApp.Checker.Concrete;
using ConsoleApp.Logger;
using ConsoleApp.Logger.Concrete;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int type;
            Console.WriteLine("Select logger:\n1.Console logger\n2.File logger\n3.Combo logger");

            Int32.TryParse(Console.ReadLine(), out type);
            IocInit(type);

            IChecker checker = Ioc.Get<IChecker>();
            ILogger logger = Ioc.Get<ILogger>();

            logger.Log(checker.Check());

            Console.ReadKey();
        }

        private static void IocInit(int type)
        {
            Ioc.Init((kernel) =>
            {
                kernel.Bind<IChecker>().To<DOU>().InTransientScope();

                switch (type)
                {
                    default:
                    case 1:
                        kernel.Bind<ILogger>().To<ConsoleLogger>().InTransientScope();
                        break;
                    case 2:
                        kernel.Bind<ILogger>().To<FileLogger>().InTransientScope();
                        break;
                    case 3:
                        kernel.Bind<ILogger>().To<ComboLogger>().InTransientScope();
                        break;
                }
            });            
        }
    }
}
