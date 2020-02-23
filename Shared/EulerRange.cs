using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Shared
{
    public class EulerRange : ICollection<int>
    {
        private List<int> lst;

        public int Count => lst.Count();

        public bool IsReadOnly => false;

        public EulerRange()
        {
            lst = new List<int>();
        }

        public EulerRange(int start, int end)
        {
            lst = new List<int>(end - start);
            lst.AddRange(Enumerable.Range(start, end - start + 1));
        }

        public EulerRange(IEnumerable<int> collection)
        {
            lst = collection.ToList();
        }

        public EulerRange(int capacity)
        {
            lst = new List<int>(capacity);
        }

        public void Add(int item)
        {
            lst.Add(item);
        }

        public void Clear()
        {
            lst.Clear();
        }

        public bool Contains(int item)
        {
            return lst.Contains(item);
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            lst.CopyTo(array, arrayIndex);
        }

        public bool Remove(int item)
        {
            return lst.Remove(item);
        }

        public IEnumerator<int> GetEnumerator()
        {
            return lst.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return lst.GetEnumerator();
        }
    }
}
