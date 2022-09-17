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
                Console.WriteLine("\nSelect Your Program: \n 1.CreateLinkedList\n 2.Reverse\n 3.Append\n 4.InsertAtParticularPosition;");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        break;
                    case 2:
                        list.AddInReverseOrder(56);
                        list.AddInReverseOrder(30);
                        list.AddInReverseOrder(70);
                        list.Display();
                        break;
                    case 3:
                        list.Append(56);
                        list.Append(30);
                        list.Append(70);
                        list.Display();
                        break;
                    case 4:
                        list.Add(56);
                        list.Add(70);
                        list.InsertAtParticularPosition(1, 30);
                        list.Display();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
    }
