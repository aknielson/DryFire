using DryFire.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryFire.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DryFireContext db = new DryFireContext();
            var wtf = db.Drills.ToList();

            Console.ReadLine();

            
        }
    }
}
