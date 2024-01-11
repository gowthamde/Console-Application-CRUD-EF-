namespace FoodStop_Db
{
    public class Program
    {
        static void Main(string[] args)
        {
            Branch branch = new Branch();
            branch.Name = "Tharamani 4";
            branch.Location = "Tharamani 4";
            branch.PhoneNo = 1234567890;
            using(var context = new FoodStopContext())
            {
                context.Add(branch);
                context.SaveChanges();
            }
        }
    }
}