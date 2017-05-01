using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gwcDataTypes
{
    unsafe class OneLinkNode<T>
    {
        private T _data;
        private OneLinkNode<T> _next;
        public OneLinkNode(T data)
        {
            _data = data;
        }
        public T Data
        {
            get { return _data; }
            set { _data = value; }
        }
        public OneLinkNode<T> Next
        {
            get { return _next; }
            set { _next = value; }
        }

    }
    class TwoLinkNode
    {

    }
}
