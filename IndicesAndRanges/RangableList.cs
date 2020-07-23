using System;
using System.Collections.Generic;
using System.Linq;

namespace IndicesAndRanges
{
    public class RangableList<T>
    {
        private readonly List<T> _list;

        public RangableList()
        {
            _list = new List<T>();
        }

        public RangableList(IEnumerable<T> collection)
        {
            _list = collection?.ToList();
        }

        public T this[Index index] => _list[index];
        
        public RangableList<T> this[Range range]
        {
            get
            {
                int startOffset = range.Start.GetOffset(_list.Count);
                int endOffset = range.End.GetOffset(_list.Count);

                var resultList = new List<T>();

                if (startOffset < endOffset)
                {
                    for (int index = startOffset; index < endOffset; index++)
                    {
                        resultList.Add(_list[index]);
                    }
                }
                else
                {
                    for (int index = startOffset; index > endOffset; index--)
                    {
                        resultList.Add(_list[index]);
                    }
                }

                return new RangableList<T>(resultList);
            }
        }

        public RangableList<T> Add(T item)
        {
            _list.Add(item);
            return this;
        }


        public RangableList<T> Add(params T[] items)
        {
            foreach (T item in items)
            {
                Add(item);
            }

            return this;
        }

        public override string ToString()
        {
            return string.Join(",", _list);
        }
    }
}