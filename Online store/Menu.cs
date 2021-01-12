using System;
using System.Collections;
using Inputs;

namespace Online_store
{
    public class MainMenu
    {
        public static void Menu(ArrayList items)
        {
            //a variable for assigning item ID
            int ID = 0;
            do
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1 - Add item");
                Console.WriteLine("2 - Show items");
                Console.WriteLine("3 - All items cost");
                Console.WriteLine("4 - Delete item");
                Console.WriteLine("5 - Delete all items");
                Console.WriteLine("6 - Exit");
                Console.Write("Command: ");
                int choice = Input.Integer();
                Console.Clear();

                if (choice == 6) break;
 
                switch ((MenuPoints)choice)
                {
                    case MenuPoints.Add:
                        {
                            ID++;
                            Store item = new Store(ID);
                            item.InputItem(item);
                            items.Add(item);
                            Continue.Clear();
                            break;
                        }
                    case MenuPoints.Show:
                        {
                            if (items.Count == 0)
                            {
                                Console.WriteLine("List is empty!");
                            }
                            else foreach (Store item in items)
                            {
                                item.ShowItem(item);
                            }
                            Continue.Clear();
                            break;
                        }
                    case MenuPoints.Cost:
                        {
                            if (items.Count == 0)
                            {
                                Console.WriteLine("List is empty!");
                            }
                            else 
                            {
                                int cost = 0;
                                for (int i = 0; i < items.Count; i++)
                                {
                                    Store item = (Store)items[i];
                                    cost += item.ItemCost(item);
                                }
                                Console.WriteLine($"Total cost: {cost}$");
                            }
                            Continue.Clear();
                            break;
                        }
                    case MenuPoints.DeleteOne:
                        {
                            if (items.Count == 0)
                            {
                                Console.WriteLine("List is empty!");
                            }
                            else
                            {
                                Console.WriteLine("Input an element number that you want to delete");
                                int delIndex = Input.Integer() - 1;
                                items.RemoveAt(delIndex);
                                
                                //Aftere deletion we move left all remaining ID
                                for (int i = delIndex; i < items.Count; i++)
                                {
                                    Store temp = (Store)items[i];
                                    temp._ID = i + 1;
                                }
                                ID--;
                            }
                            Continue.Clear();
                            break;
                        }
                    case MenuPoints.DeleteAll:
                        {
                            if (items.Count == 0)
                            {
                                Console.WriteLine("List is empty!");
                            }
                            else
                            {
                                items.Clear();
                                ID = 0;
                            }
                            Console.WriteLine("Operation complete!");
                            Continue.Clear();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Error! Please input a point from menu!");
                            break;
                        }
                }
            } while (true);
        }

        public enum MenuPoints
        {
            Add = 1,
            Show,
            Cost,
            DeleteOne,
            DeleteAll,
            Exit,
        }
    }
}
