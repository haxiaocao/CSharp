using System;

namespace xiaocao.test
{
    //theme: Dependency Injection;  -> other method is use Docker utility.
    //1.class itself  (contains interface.)
    //2.dependency interface(class)  for the constructor.[you have create the class instance.]
    //3.dependency framework.
    class DependencyInjection
    {
        static void Main(string[] args)
        {
            string decision = Console.ReadLine();
            IStrategy strategy=null;
            switch (decision)
            {
                case "1": strategy = new StrategyDay(); break;
                case "2": strategy = new StrategyMonth(); break;
                case "3": strategy = new StrategyYear(); break;
                default:
                    break;
            }

            if(strategy != null)
            {
                Trader trader = new Trader(strategy);
                trader.Trade();
            }
            else
            {
                Console.WriteLine("The validate value input is : 1,2,3");
            }
            Console.ReadKey();
        }
        
    }

    class Trader
    {
        private readonly IStrategy strategy;
        public bool Isvalidate
        {
            get { return true; }
            set { }
        }
        public Trader(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Trade()
        {
            if(Isvalidate)
            {
                strategy.Execute();
            }
        }       
    }

    interface IStrategy
    {
        void Execute();
    }
    class StrategyDay : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Stratedy Day executing....");
        }
    }

    class StrategyMonth : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Stratedy Month executing....");
        }
    }

    class StrategyYear : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Stratedy Year executing....");
        }
    }

}
