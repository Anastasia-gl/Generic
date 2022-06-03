using System.Collections;
namespace Generics
{
    internal class MyList : IEnumerable
    {
        private List<string> newCollection = new List<string>() { "E", "A", "B" };

        public void AddRange()
        {
            string[] letters = new string[3] { "L", "J", "Y" };
            newCollection.AddRange(letters);
        }

        public void Add(string add)
        {
            if (!newCollection.Contains(add))
            {
                newCollection.Add(add);
                Console.WriteLine("Added: " + add);
            }
            else
            {
                Console.WriteLine("You already have it!");
            }
        }

        public void Remove(string remove)
        {
            if (newCollection.Contains(remove))
            {
                newCollection.Remove(remove);
                Console.WriteLine("Removed: " + remove);
            }
            else
            {
                Console.WriteLine("There is no such letter");
            }
        }

        public void RemoveAt()
        {
            int index = 0;
            foreach (string s in newCollection)
            {
                index++;
                if (index == 3)
                {
                    newCollection.RemoveAt(index);
                    Console.WriteLine("Removed a letter because of index " + index);
                    break;
                }
            }     
        }

        public void Sort()
        {
            for (int i = 0; i < newCollection.Count; i++)
            {
                if (!newCollection[i].StartsWith("A"))
                {
                    newCollection.Sort();
                    Console.WriteLine("Sorted:");
                    break;
                }
                else
                {
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
