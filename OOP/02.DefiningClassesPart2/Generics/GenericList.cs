/*05.
 * Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
 * Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. 
 * Implement methods for adding element, accessing element by index, removing element by index, 
 * inserting element at given position, clearing the list, finding element by its value and ToString(). 
 * Check all input parameters to avoid accessing elements at invalid positions.*/

/* 06
 * Implement auto-grow functionality: when the internal array is full, 
 * create a new array of double size and move all elements to it*/

namespace Generics
{
    using System;
    using System.Text;

    public class GenericList<T>
    {
        private const int MINIMUM_CAPACITY = 2;

        private T[] elements;
        private int index;

        public GenericList(int capacity)
        {
            if (capacity < MINIMUM_CAPACITY)
            {
                throw new InvalidOperationException("The minimum value of the capacity is 2");
            }
            this.elements = new T[capacity];
            this.index = 0;
        }
        public void Add(T element)
        {
            if (this.elements.Length == this.index)
            {
                this.Resize();
            }
            this.elements[index] = element;
            this.index++;
        }

        public void Insert(int insertIndex, T value)
        {

            if (insertIndex >= this.index)
            {
                throw new ArgumentOutOfRangeException("The index is outside of the bounds of the array");
            }
            this.index++;
            if (this.elements.Length == this.index)
            {
                this.Resize();
            }

            this.MoveForward(insertIndex);
            this.elements[insertIndex] = value;
        }

        //Indexer is a better solution but the task requires a method
        public T Peek(int peekIndex)
        {
            if (peekIndex >= this.index)
            {
                throw new ArgumentOutOfRangeException("The index is outside of the bounds of the array");
            }
            return this.elements[peekIndex];
        }

        public void RemoveAtIndex(int removeIndex)
        {
            if (removeIndex >= this.index)
            {
                throw new ArgumentOutOfRangeException("The index is outside of the bounds of the array");
            }
            this.MoveBackward(removeIndex + 1);
            this.index--;
        }

        public int IndexOfElement(T value)
        {
            int elementIndex = -1;
            for (int i = 0; i < this.index; i++)
            {
                if (this.elements[i].Equals(value))
                {
                    elementIndex = i;
                    break;
                }
            }
            return elementIndex;
        }

        public void ClearList()
        {
            this.elements = new T[MINIMUM_CAPACITY];
            this.index = 0;
        }

        public int Count()
        {
            return this.index;
        }

        private void Resize()
        {
            T[] copyArray = this.elements;
            this.elements = new T[copyArray.Length * 2];
            Array.Copy(copyArray, this.elements, copyArray.Length);
        }

        private void MoveBackward(int startPosition)
        {
            for (int i = startPosition; i < this.index; i++)
            {
                this.elements[i - 1] = this.elements[i];
            }
        }



        private void MoveForward(int startPosition)
        {
            for (int i = this.index; i >= startPosition; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.index; i++)
            {
                result.AppendFormat("[{0}] {1}", i, this.elements[i]);
                result.AppendLine();
            }
            return result.ToString();
        }
    }
}
