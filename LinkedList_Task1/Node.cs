namespace LinkedList_Task1;

public class Node<T>
{
    public T data;
    public Node<T> next;

    public T this[int index]
    {
        get
        {

            if (index < 0)
                throw new IndexOutOfRangeException("Index is out of range");

            Node<T> current = this;

            for (int i = 0; i < index; i++)
            {
                current = current.next;
                if (current == null)
                    throw new IndexOutOfRangeException("Index is out of range");
            }

            return current.data;
        }
    }
}
