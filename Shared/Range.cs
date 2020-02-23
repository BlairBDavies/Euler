using System;
using System.Collections.Generic;
using System.Linq;

namespace Shared
{
    public class Range : List<int>
    {
        public Range()
        {
        }

        public Range(int start, int end) : base(end - start) {
            this.AddRange(Enumerable.Range(start, end));
        }

        public Range(IEnumerable<int> collection) : base(collection)
        {
        }

        public Range(int capacity) : base(capacity)
        {
        }
    }
}
