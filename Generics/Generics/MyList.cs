using System.Collections;
namespace Generics
{
    internal class MyList<T> : IEnumerable
       
    {
        public List<T> newCollection = new List<T>();

        private string[] a = new string[] { "k", "b", "c", "d", "e"};

        public void AddRange(List<string> letters)
        {
            letters.AddRange(a);
        }

        public void Add(List<string> letters, string add)
        {
            if (!letters.Contains(add))
            {
                letters.Add(add);
                Console.WriteLine("Added: " + add);
            }
            else
            {
                Console.WriteLine("You already have it!");
            }
        }

        public void Remove(List<string> letters, string remove)
        {
            if (letters.Contains(remove))
            {
                letters.Remove(remove);
                Console.WriteLine("Removed: " + remove);
            }
            else
            {
                Console.WriteLine("There is no such letter");
            }
        }

        public void RemoveAt(List<string> letters)
        {
            int index = 0;
            foreach (string s in letters)
            {
                index++;
                if (index == 3)
                {
                    letters.RemoveAt(index);
                    Console.WriteLine("Removed a letter because of index " + index);
                    break;
                }
            }     
        }

        public void Sort(List<string> letters)
        {
            for (int i = 0; i < letters.Count; i++)
            {
                if (!letters[i].StartsWith("A"))
                {
                    newCollection.Sort();
                    Console.WriteLine("Sorted:");
                    break;
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return newCollection.GetEnumerator();
        }
    }
}
