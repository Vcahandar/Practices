using DomainLayer.Models;
using ServiceLayer.Services.Interface;


namespace ServiceLayer.Services
{
    public class CostumerService : ICostumerService
    {
        public int GetCostumerCountByFiltered()
        {
            var costumers = GetAll();
            int count = 0;

            foreach (var item in costumers)
            {
                if (item.Age>25 && item.Age<30)
                {
                    count++;
                }

            }
            return count;
        }



        public double GetCostumersAverageByAges()
        {
            var costumers = GetAll();
            double average = 0;
            double sumAge = 0;

            foreach (var item in costumers)
            {
                sumAge += item.Age;     
            }
            average = sumAge / costumers.Length;
            return average;
        }


        private Costumer[] GetAll()
        {
            Costumer c1 = new Costumer()
            {
                Id = 1,
                Name = "Shaiq",
                Surname = "Kazimov",
                Age = 26,
                Position = "Backed Developer"
            };

            Costumer c2 = new Costumer()
            {
                Id = 2,
                Name = "Pervin",
                Surname = "Kazimov",
                Age = 25,
                Position = "Backed Developer"
            };

            Costumer c3 = new Costumer()
            {
                Id = 3,
                Name = "Ismayil",
                Surname = "Yusifov",
                Age = 27,
                Position = "Backed Developer"
            };

            Costumer c4 = new Costumer()
            {
                Id = 4,
                Name = "Ceyhun",
                Surname = "Kazimov",
                Age = 18,
                Position = "Backed Developer"
            };

            Costumer[] costumers = { c1, c2, c3, c4, }; 
            return costumers;
        }

        Costumer[] ICostumerService.GetCostumerByFiltered(int starAge, int endAge)
        {
            var costumers = GetAll();

            Costumer[] result = new Costumer[costumers.Length];

            int count = 0;


            foreach (var item in costumers)
            {
                if (item.Age > starAge && item.Age < endAge)
                {
                    result[count] = item;
                    count++;
                }

            }
            return result;

        }
    }
}
