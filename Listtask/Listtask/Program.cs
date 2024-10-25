namespace Listtask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new CustomList<int>();
             array.AddRange(1,2,5,7,12,23,45,87);
            Console.WriteLine(array.Contains(87));
            Console.WriteLine(array._count);


            array.RemoveRange(7,12,23);
            Console.WriteLine(array.ToString());

        }
    }
}