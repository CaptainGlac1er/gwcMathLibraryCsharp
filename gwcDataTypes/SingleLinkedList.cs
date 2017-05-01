using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gwcDataTypes
{
    public class SingleLinkedList<T> : IEnumerable<T>
    {
        private OneLinkNode<T> _start, _head;
        private int _length = 0;
        public SingleLinkedList()
        {

        }
        public void Add(T data)
        {
            if(_start == null)
            {
                _start = new OneLinkNode<T>(data);
                _head = _start;
                _length++;
            }
            else
            {
                OneLinkNode<T> newNode = new OneLinkNode<T>(data);
                _head.Next = newNode;
                _head = newNode;
                _length++;
            }
        }

        public T[] toArray()
        {
            T[] output = new T[_length];
            OneLinkNode<T> copy = _start;
            for(int i = 0; copy != null; i++)
            {
                output[i] = copy.Data;
                copy = copy.Next;
            }
            return output;
        }
        public T getHeadData()
        {
            return _head.Data;
        }


        public IEnumerator<T> GetEnumerator()
        {
            OneLinkNode<T> copy = _start;
            for (int i = 0; copy != null; i++)
            {
                T data = copy.Data;
                copy = copy.Next;
                yield return data;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
