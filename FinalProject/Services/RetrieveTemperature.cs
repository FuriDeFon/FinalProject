using FinalProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services
{
    public class RetrieveTemperature : IRetrieveMeasurement
    {
        private Random randomNumber = new Random();
        public float RetrieveMeasurement(int min, int max)
        {
            return randomNumber.Next(min, max);
        }
    }
}
