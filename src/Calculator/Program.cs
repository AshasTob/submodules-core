using System;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2+2= ?");
            int x = Convert.ToInt32(Console.ReadLine());
            var r = new DefaultLocalizedMessages();
            if (x == 4)
            {
                Console.WriteLine(r.Success);
            }
            else
            {
                Console.WriteLine(r.Fail);
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
