namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyList list = new MyList();

            Console.WriteLine("Enter a letter which you want to implement");
            string add = Console.ReadLine();
            list.Add(add);

            list.AddRange();

            Console.WriteLine("Enter a letter which you want to delete");
            string remove = Console.ReadLine();
            list.Remove(remove);

            list.RemoveAt();
            list.Sort();

            foreach (var letter in list)
            {
                Console.Write(letter + " ");
            }
        }
    }
}