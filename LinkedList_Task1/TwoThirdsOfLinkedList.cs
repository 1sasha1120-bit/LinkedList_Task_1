namespace LinkedList_Task1;

static class TwoThirdsOfLinkedList
{
    public static int? GetTwoThirdsNode(this Node<int> head, int n)
    {
        if (head == null || n <= 1)
            return null;

        int index = ((2 * n) / 3) - 1;
        return head[index];
    }
}
