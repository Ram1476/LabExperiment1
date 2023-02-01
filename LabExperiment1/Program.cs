using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LabExperiment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Car car = new Car();
            car.AcceptDetails();
            car.DisplayDetails();
            Console.ReadLine();
        }
    }
}
