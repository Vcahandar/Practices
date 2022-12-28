using ServiceLayer.Services;
using ServiceLayer.Services.Interface;


namespace Homework_Practice.Controllers
{
    public class CostumerController
    {
        private readonly ICostumerService _service;
        public CostumerController()
        {
            _service = new CostumerService();
        }


        public void GetCostumerCountByFiltered()
        {
            Console.WriteLine(_service.GetCostumerCountByFiltered()); 
        }

        public void GetCostumersAverageByAges()
        {
            Console.WriteLine(_service.GetCostumersAverageByAges());
        }


        public void GetCostumersByFiltered()
        {
            int startAge = 20;
            int endAge = 30;

            var result=_service.GetCostumerByFiltered(startAge,endAge);

            foreach (var item in result)
            {
                if (item!=null)
                {
                    Console.WriteLine($"{item.Id}--{item.Name}--{item.Surname}--{item.Age}--{item.Position}");

                }
            }

        }
    }

}
