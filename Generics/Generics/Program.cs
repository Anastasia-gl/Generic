namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();

            Console.WriteLine("Enter a letter which you want to implement");
            string add = Console.ReadLine();
            list.newCollection.Add(add);

            list.AddRange(list.newCollection);

            Console.WriteLine("Enter a letter which you want to delete");
            string remove = Console.ReadLine();
            list.Remove(list.newCollection, remove);

            list.RemoveAt(list.newCollection);
            list.Sort(list.newCollection);

            foreach (var letter in list)
            {
                Console.Write(letter + " ");
            }
        }
    }
}