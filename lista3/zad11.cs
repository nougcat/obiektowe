using System;


namespace mojaLista
{
    public class Lista<T>
    {
        private class Node
        {
            // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties
            public T Value { get; set; }
            public Node NextNode { get; set; }
            public Node PrevNode { get; set; }

            public Node(T data)
            {
                Value = data;
            }
        }

        private Node head;
        private Node tail;

        public void PushFront(T elem)
        {
            Node newNode = new Node(elem);

            if (this.head == null)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                newNode.NextNode = this.head;
                this.head.PrevNode = newNode;
                this.head = newNode;
            }
        }

        public void PushBack(T elem)
        {
            Node newNode = new Node(elem);

            if (this.tail == null)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                newNode.PrevNode = this.tail;
                this.tail.NextNode = newNode;
                this.tail = newNode;
            }
        }

        public T PopFront()
        {
            if (this.head == null)
            {
                Console.WriteLine("Błąd, lista jest pusta");
                T tmp_data = default(T);
                return tmp_data;
            }

            T data = this.head.Value;
            this.head = this.head.NextNode; // new head

            if (this.head == null)
            {
                this.tail = null;
            }
            else
            {
                this.head.PrevNode = null;
            }

            return data;
        }

        public T PopBack()
        {
            if (this.tail == null)
            {
                Console.WriteLine("Błąd, lista jest pusta");
                T tmp_data = default(T);
                return tmp_data;
            }

            T data = this.tail.Value;
            tail = this.tail.PrevNode; // we set new tail

            if (this.tail == null)
            {
                this.head = null;
            }
            else
            {
                this.tail.NextNode = null;
            }

            return data;
        }

        public bool IsEmpty()
        {
            return this.head == null;
        }
    }

}