namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Linklist list = new Linklist();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect Your Program: \n 1.CreateLinkedList");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
    }
