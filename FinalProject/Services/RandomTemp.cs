using FinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services
{
    public class RandomTemp : IRetrieveMeasurement
    {
        private Random randomNumber = new Random();
        public float RetrieveMeasurement()
        {
            return randomNumber.Next(30, 50);
        }
    }
}
