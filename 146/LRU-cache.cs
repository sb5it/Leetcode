public class LRUCache {
        public int Size { get; }
        public DoubleLinkedList List { get; }
        public Dictionary<int, Node> Cache { get; }

        public LRUCache(int capacity) {
            Size = capacity;
            List = new DoubleLinkedList();
            Cache = new Dictionary<int, Node>();
        }
    
        public int Get(int key) {
            if (Cache.ContainsKey(key))
            {
                var node = Cache[key];
                List.Remove(node);
                Cache[key] = List.Append(key, node.Value);
                return node.Value;
            }
            return -1;
        }
    
        public void Put(int key, int value) {
            if (Cache.ContainsKey(key))
            {
                List.Remove(Cache[key]);
            }

            var node = List.Append(key, value);
            Cache[key] = node;

            if (List.Size > Size)
            {
                var removedNode = List.RemoveLRU();
                Cache.Remove(removedNode.Key);
            }
        }

    public class DoubleLinkedList
    {
        public Node Head { get; }
        public Node Tail { get; }
        public int Size { get; set; }

        public DoubleLinkedList()
        {
            Head = new Node();
            Tail = new Node();
            Head.Next = Tail;
            Tail.Prev = Head;
        }

        public Node Append(int key, int value)
        {
            var node = new Node { Key = key, Value = value };

            var p = Tail.Prev;
            p.Next = node;
            Tail.Prev = node;
            node.Prev = p;
            node.Next = Tail;

            Size += 1;
            return node;
        }

        public Node RemoveLRU()
        {
            return Remove(Head.Next);
        }

        public Node Remove(Node node)
        {
            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;
            Size -= 1;
            return node;
        }
    }

    public class Node {
        public int Value { get; set; }
        public int Key { get; set; }
        public Node Prev { get; set; }
        public Node Next { get; set; }
    }
}
