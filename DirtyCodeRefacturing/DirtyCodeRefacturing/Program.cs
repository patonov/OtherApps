using DirtyCodeRefacturing;
using System.Collections.Generic;
using System.Collections;

namespace DirtyCodeRefacturing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }        
    }

    public interface IWorker
    {
        void BeHappy();
    }



    public class Worker : IWorker
    { 
        public Worker() 
        { 
        
        }

        public string Name { get; set; }

        public string Occupation { get; set; }

        public void BeHappy()
        {
            Console.WriteLine("I am happy");
        }
    }

    public class Shop
    {
        private static Shop? instance;

        public static Shop getInstance()
        {
            if (instance == null)
            {
                instance = new Shop();
            }

            return instance;
        }

        public List<IWorker> workers = new List<IWorker>();

        public void addWorker(IWorker worker)
        {
            this.workers.Add(worker);
        }

        public double GetTurnover()
        {
            var turnOver = 0.0;
            foreach (var worker in this.workers)
            {
                if (worker.GetType().ToString() == nameof(SalesConsultant)) ;
                {
                    turnOver += ((SalesConsultant)worker).getMoney();
                }

                if (worker.GetType().ToString() == nameof(MarketingSpecialist))
                {
                    turnOver += ((MarketingSpecialist)worker).GetBudget();
                }
            }
            return turnOver;
        }
    }
}

public class SalesConsultant : IWorker
{

    private Shop workingShop;
    private double earnedMoney;

    public SalesConsultant()
    {
        this.workingShop = Shop.getInstance();
        this.workingShop.addWorker(this);
    }

    public void sellProduct(double price)
    {
        this.earnedMoney += Math.Max(price, 0);
    }

    public double getMoney()
    {
        return this.earnedMoney;
    }

    public void BeHappy()
    {
        Console.WriteLine("i AM HAppy");
    }
}

 public class MarketingSpecialist : IWorker
{
    private Shop workingShop;
    private double budget = 5000.00;

    public MarketingSpecialist()
    {
        this.workingShop = Shop.getInstance();
        this.workingShop.addWorker(this);
    }

    public void spendMoney(double marketingCampaignCost)
    {
        this.budget -= Math.Max(marketingCampaignCost, 0);
    }

    public double GetBudget()
    {
        return this.budget;
    }

    public void BeHappy()
    {
        Console.WriteLine("I am happpyyyyyy");
    }
}
