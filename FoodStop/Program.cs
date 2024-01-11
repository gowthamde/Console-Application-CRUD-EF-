using FoodStop.Data;
using FoodStop.Models;

namespace FoodStop
{
    class Program
    {
        static void Main(string[] args)
        {
            Branch branch = new Branch();
            branch.Id = 2;
            branch.Name = "Tharamani 3";
            branch.Location = "Tharamani 3";
            branch.PhoneNo = 1234567890;
            using(var context = new ApplicationDbContext())
            {
                // Create
                context.Branch.Add(branch);
                context.SaveChanges();
                Console.WriteLine("Record Added...");

                //Read
                var branches = context.Branch.ToList();
                foreach (var b in branches)
                {
                    Console.WriteLine($"Name:{b.Name}, Location{b.Location}, Phone no{b.PhoneNo}");
                }

                //Single Read
                var b1 = context.Branch.Where(x => x.Name == "Tharamani").FirstOrDefault();
                Console.WriteLine($"Name:{b1.Name}, Location{b1.Location}, Phone no{b1.PhoneNo}");

                //Update
                context.Branch.Update(branch);
                context.SaveChanges();

                //Delete
                context.Branch.Remove(branch);
                context.SaveChanges();
            }
            Console.ReadLine();
        }
    }
}