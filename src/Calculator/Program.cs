using System;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var coreTest = new DomainService(new DefaultLocalizedMessages());
            coreTest.CheckMath();
        }
    }

    //its not pure, but i dont care
    public class DomainService
    {
        private readonly ILocalizedMessages _localizer;

        public DomainService(ILocalizedMessages localizer)
        {
            _localizer = localizer;
        }

        //ooff nice side-effects
        public void CheckMath()
        {
            Console.WriteLine("2+2= ?");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 4)
            {
                Console.WriteLine(_localizer.Success);
            }
            else
            {
                Console.WriteLine(_localizer.Fail);
            }
        }
    }

    public interface ILocalizedMessages
    {
        string Success { get; }
        string Fail { get; }
    }

    public class DefaultLocalizedMessages : ILocalizedMessages
    {
        public string Success
        {
            get { return "You are right!"; }
        }

        public string Fail
        {
            get { return "You are wrong :("; }
        }
    }
}
