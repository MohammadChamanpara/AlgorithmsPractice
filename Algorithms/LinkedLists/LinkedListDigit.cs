namespace Algorithms.LinkedLists
{
    public class Node
    {
        public Node(int value)
        {
            Value = value;
        }

        public Node? Next;
        public int Value;
    }

    public class LinkedListDigit
    {
        private Node? _head;

        public LinkedListDigit(int number = 0)
        {
            while (number > 0)
            {
                AddDigit(number % 10);
                number /= 10;
            }
        }

        private void AddDigit(int digit)
        {
            if (_head == null)
            {
                _head = new Node(digit);
                return;
            }

            Node? runner = _head;
            while (runner.Next != null) runner = runner.Next;

            runner.Next = new Node(digit);
        }

        public static LinkedListDigit operator +(LinkedListDigit a, LinkedListDigit b)
        {
            LinkedListDigit result = new();

            var aRunner = a._head;
            var bRunner = b._head;
            int carry = 0;

            while (aRunner != null || bRunner != null)
            {
                int aDigit = aRunner?.Value ?? 0;
                int bDigit = bRunner?.Value ?? 0;

                int sum = aDigit + bDigit + carry;
                int sumDigit = sum % 10;
                carry = sum / 10;

                result.AddDigit(sumDigit);

                aRunner = aRunner?.Next;
                bRunner = bRunner?.Next;
            }

            if (carry != 0)
                result.AddDigit(carry);

            return result;
        }

        public int ToInt()
        {
            Node? runner = _head;
            int number = 0;
            int power = 1;
            while (runner != null)
            {
                number = runner.Value * power + number;
                runner = runner.Next;
                power *= 10;
            }
            return number;
        }

        public override string ToString()
        {
            string s = "";
            Node? runner = _head;
            while (runner != null)
            {
                s = $"{runner.Value}{s}";
                runner = runner.Next;
            }
            return s;
        }
    }
}