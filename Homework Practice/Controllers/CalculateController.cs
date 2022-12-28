using ServiceLayer.Services;
using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Practice.Controllers
{
    public class CalculateController
    {
        //public void MultiplyArrayItmes()
        //{
        //    int[] arr = { 1, 2, 3, 4, 5, 6, 12 };
        //    ICalculateService calculateService = new CalculateService();
        //   var result= calculateService.MultiplyArrayItems(arr);
        //    Console.WriteLine(result);
        //}

        // public void SquareOfSumArrayItems()
        //{
        //    int[] arr = { 1, 2, 3, 4, 5, 6, 12 };
        //    ICalculateService calculateService= new CalculateService();
        //    var result=calculateService.SquareOfSumArrayItems(arr);
        //    Console.WriteLine(result);
        //}

        private readonly ICalculateService _service;
        public CalculateController()
        {
            _service= new CalculateService();
        }

        public void MultiplyArrayItmes()=> Console.WriteLine(_service.MultiplyArrayItems(GetArr()));

        public void SquareOfSumArrayItems() => Console.WriteLine(_service.SquareOfSumArrayItems(GetArr()));

        private int[]GetArr()=> new[] { 1, 2, 3, 4, 5, 6, 12 };
        

            
            
        

    }
}
