using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections
{
    class customUtils
    {
        public static bool Equals(object first, object second)
        {
            if (first == second)
                return true;
            else if (first == null || second == null)
                return false;
            else if (!Object.ReferenceEquals(first.GetType(), second.GetType()))
                return false;
            Type type = first.GetType();
            var firstArgument = Convert.ChangeType(first, type);
            var secondArgument = Convert.ChangeType(second, type);
            return firstArgument.Equals(secondArgument);
        }
        public static LinkedList middlePointOfList(LinkedList head)
        {
            if (head == null)
                return null;
            LinkedList slowPointer; LinkedList fastPointer;
            slowPointer = head;
            fastPointer = head.next;
            while (fastPointer != null && fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
            }
            return slowPointer;
        }
        public static LinkedList mergeSort(LinkedList head)
        {
            if (Object.Equals(head,null))
                return head;
            if (Object.Equals(head.next,null))
                return head;
            LinkedList middle = middlePointOfList(head);
            LinkedList firstList = head;
            LinkedList secondList = middle.next;
            middle.next = null;
            firstList=mergeSort(firstList);
            secondList=mergeSort(secondList);
            return mergeList(firstList,secondList);
        }
        public  static LinkedList mergeList(LinkedList firstList, LinkedList secondList)
        {

            LinkedList head = new LinkedList(new object());
            LinkedList iterator = head;
            while (firstList != null && secondList != null)
            {
                if (firstList.CompareTo(secondList) > 0)
                {
                    iterator.next = new LinkedList(secondList.data);
                    iterator = iterator.next;
                    secondList = secondList.next;
                }
                else
                {
                    iterator.next = new LinkedList(firstList.data);
                    iterator = iterator.next;
                    firstList = firstList.next;
                }
            }
            while (firstList != null)
            {
                iterator.next = new LinkedList(firstList.data);
                iterator = iterator.next;
                firstList = firstList.next;
            }
            while (secondList != null)
            {
                iterator.next = new LinkedList(secondList.data);
                iterator = iterator.next;
                secondList = secondList.next;
            }
            return head.next;
        }
    }
}
