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
        public bool removeLast()
        {
            head.remove(head.length-1);
            return true;
        }
        public bool remove(int index)
        {
            head = head.remove(index);
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
            if (index < 0 || index >=head.length)
                throw new IndexOutOfRangeException();
            return head.get(index);
        }
        public bool set(int index, Object data)
        {
            if (index < 0 || index >= head.length)
                throw new IndexOutOfRangeException();
            return head.set(index,data);
        }
        public bool sort()
        {
            LinkedList virtualHead = head.next;
            head.next = customUtils.mergeSort(virtualHead);
            return true;
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
        public int indexOf(Object data)
        {
            return head.indexOf(data);
        }
        public bool clear()
        {
            head = new LinkedList(new object());
            length = head.length;
            GC.Collect();
            return true;
        }
    }
    public class LinkedList:IComparable<LinkedList>
    {
        public Object data;
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
                LinkedList tempIterator = iterator;
                iterator = iterator.next;
                int hops = 0;
                while (hops != index)
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
        public LinkedList remove(int index)
        {
            if (index < 0 || index >= length)
                throw new IndexOutOfRangeException();
            int hops = 0;
            iterator = this;
            if (index == 0)
            {
                this.next = this.next.next;
                return this;
            }
            while (hops != index)
            {
                iterator = iterator.next;
                hops++;
            }
            iterator.next = iterator.next.next;
            return this;
        }
        public int indexOf(Object data)
        {
            int index = -1;
            iterator = this;
            while (iterator != null)
            {
                if (CustomList.Equals(iterator.data, data))
                    return index;
                iterator = iterator.next;
                index++;
            }
            return -1;
        }
        public bool contains(Object data)
        {
            iterator = this;
            while (iterator != null)
            {
                if (customUtils.Equals(iterator.data, data))
                    return true;
                iterator = iterator.next;
            }
            return false;
        }
        public Object get(int index)
        {
            iterator = this;
            int hops = 0;
            if (index == 0)
                return iterator.next.data;
            while (hops != index+1)
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
            if (index == 0)
            {
                iterator.next.data = data;
                return true;
            }
            while (hops != index+1)
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
            iterator = this.next;
            while (iterator != null)
            {
                answer += "->" + iterator.data.ToString();
                iterator = iterator.next;
            }
            iterator = null;
            return answer;
        }
        public int CompareTo(LinkedList obj)
        {
            if (obj == null)
                return 1;
            Type thisType = this.data.GetType();
            Type argumentType = obj.data.GetType();
            dynamic thisObject = Convert.ChangeType(this.data,thisType);
            dynamic argumentObject = Convert.ChangeType(obj.data,argumentType);
            if (!thisType.Equals(argumentType))
            {
                throw new Exception("customList contains multiple data types, It can't be sorted");
            }
            return thisObject.CompareTo(argumentObject);
        }
    }
    
}
