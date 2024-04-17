namespace ArrayList.Models
{
    internal class IntArrayList
    {
        int[] _arr;
        public int Capacity { get; set; }
        public int Count { get; private set; }
        public IntArrayList()
        {
            Capacity = 5;
            _arr = new int[Capacity];
        }
        public IntArrayList(int capasity)
        {
            Capacity = capasity;
            _arr = new int[Capacity];
        }
        public int this[int num]
        {
            get
            {
                return _arr[num];
            }
            set { _arr[Count] = value; }
        }
        public void Add(int item)
        {
            if (_arr.Length == Count)
            {
                Array.Resize(ref _arr, Count + Capacity);

            }
            _arr[Count] = item;
            Count++;
        }
        public void GetElements()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }


        public void IndexOff(int value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_arr[i] == value)
                {
                    Console.WriteLine(i);
                    break;
                    
                }
            }
        }




        public void LastIndexOff(int value)
        {
            for (int i = Count; i >= 0; i--)
            {
                if (_arr[i] == value)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }




        public void Remove(int value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (i == value)
                {
                    _arr[i] = 0;
                }
            }
        }



        public override string ToString()
        {
            string outcome = "{";
            for (int i = 0; i < Count; i++)
            {
                if (i > 0)
                {
                    outcome += ",";
                }
                outcome += _arr[i].ToString();

            }
            outcome += "}";
            return outcome;
        }
    }
}
