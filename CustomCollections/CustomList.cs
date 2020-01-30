using System;
using System.Collections;
using System.Linq;
using System.Text;


namespace CustomCollections
{
    public class CustomList
    {
        public int length;
        public int capacity;
        private LinkedList head;
        private LinkedList iterator;
        public CustomList(int capacity)
        {
            head = new LinkedList(new object());
            this.capacity = capacity;
            this.length = 0;
        }
        public bool add(Object data)
        {
            head = head.add(data, head.length);
            this.length = head.length;
            return true;
        }
        public bool add(object data, int index)
        {
            if (data == null)
                return false;
            if (index < 0 || head.length < index)
                throw new IndexOutOfRangeException();
            head = head.add(data, index);
            this.length = head.length;
            return true;
        }
        public Object get(int index)
        {
            if (index < 0 || index >head.length)
                throw new IndexOutOfRangeException();
            return head.get(index);
        }
        public bool set(int index, Object data)
        {
            if (index < 0 || index > head.length)
                throw new IndexOutOfRangeException();
            return head.set(index,data);
        }
        public String ToString()
        {
            return head.ToString();
        }
        public bool contains(object data)
        {
            if (data == null)
                return false;
            return head.contains(data);
        }
        public bool clear()
        {
            head = new LinkedList(new object());
            length = head.length;
            GC.Collect();
            return true;
        }
        public  bool Equals(object first,object second)
        {
            if (first==second)
                return true;
            else if (first == null||second==null)
                return false;
            else if (!Object.ReferenceEquals(first.GetType(), second.GetType()))
                return false;
            Type type = first.GetType();
            var firstArgument = Convert.ChangeType(first,type);
            var secondArgument = Convert.ChangeType(second, type);
            return firstArgument.Equals(secondArgument);
        }

    }
    public class LinkedList
    {
        public object data;
        public LinkedList next;
        private LinkedList iterator;
        public int length;
        public LinkedList(object data)
        {
            length = 0;
            this.data = data;
            next = null;
        }
        public LinkedList add(object data, int index)
        {
            iterator = this;
            if (index == 0)
            {
                LinkedList start = new LinkedList(data);
                start.next = iterator.next;
                iterator.next = start;
                length++;
                return this;
            }
            else if (index == length)
            {
                while (iterator.next != null)
                {
                    iterator = iterator.next;
                }
                iterator.next = new LinkedList(data);
                iterator = null;
                length++;
                return this;
            }
            else
            {
                LinkedList tempIterator = null;
                int hops = 0;
                while (!(hops == index))
                {
                    tempIterator = iterator;
                    iterator = iterator.next;
                    hops++;
                }
                tempIterator.next = new LinkedList(data);
                tempIterator.next.next = iterator;
                iterator = null;
                length++;
                return this;
            }
        }

        //changes required.
        public bool contains(Object data)
        {
            iterator = this;
            while (iterator.next != null)
            {
                if (iterator.data.Equals(data))
                    return true;
                iterator = iterator.next;
            }
            return false;
        }

        public Object get(int index)
        {
            iterator = this;
            int hops = 0;
            while (!(hops == index))
            {
                iterator = iterator.next;
                hops++;
            }
            return iterator.data;
        }
        public bool set(int index, Object data)
        {
            iterator = this;
            int hops = 0;
            while (!(hops == index))
            {
                iterator = iterator.next;
                hops++;
            }
            iterator.data = data;
            return true;
        }
        public override String ToString()
        {
            String answer = "";
            iterator = this;
            while (iterator != null)
            {
                answer += "->" + iterator.data.ToString();
                iterator = iterator.next;
            }
            return answer;
        }

    }
    
}
