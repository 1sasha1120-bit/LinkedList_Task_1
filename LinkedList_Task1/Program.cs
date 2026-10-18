using LinkedList_Task1;

Node<int> head = new Node<int> { data = 0 };

Node<int> node1 = new Node<int> { data = 2 };
Node<int> node2 = new Node<int> { data = 42 };
Node<int> node3 = new Node<int> { data = 78 };
Node<int> node4 = new Node<int> { data = 98 };
Node<int> node5 = new Node<int> { data = 67 };

head.next = node1;
node1.next = node2;
node2.next = node3;
node3.next = node4;
node4.next = node5;

int? result = head.GetTwoThirdsNode(1);
if(result != null)
    Console.WriteLine(result);
else
    Console.WriteLine("null");