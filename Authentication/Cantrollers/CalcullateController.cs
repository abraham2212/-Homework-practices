using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Cantrollers
{
    public class CalcullateController
    {
        private readonly ICalculateService _service;
        public CalcullateController()
        {
            _service = new CalculateService();
        }

        public void MultyArrayItem() => Console.WriteLine(_service.MultyArrayItem(GetArr()));


        public void SquaredSumArrayItem() => Console.WriteLine(_service.SquaredSumArrayItem(GetArr()));


        private int[] GetArr() => new int[] { 1, 2, 3, 4, 6, 12 };








        //public void MultyArrayItem()
        //{
        //    int[] arr = { 1, 2, 3, 4, 6, 12 };

        //    ICalculateService calculateService = new CalculateService();
        //    var result = calculateService.MultyArrayItem(arr);
        //    Console.WriteLine(result);
        //}

        //public void SquaredSumArrayItem()
        //{
        //    int[] arr = { 1, 2, 3, 4, 6, 12 };
        //    ICalculateService calculateService = new CalculateService();
        //    var result = calculateService.SquaredSumArrayItem(arr);


        //    Console.WriteLine(result);
        //}
    }



}
