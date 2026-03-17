namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            test std1, std2;
            
            std1 = new test();
            std2 = new test(); 

            std1.Mid = 78;
            std1.SetFinal(72);

            std2.SetGrade(68,84);

            Console.WriteLine(std1.GetAvg().ToString());
            Console.WriteLine(std2.GetAvg().ToString());




        }
    }
}
