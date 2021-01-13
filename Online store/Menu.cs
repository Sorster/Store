using System;
using System.Collections;
using Inputs;

namespace Online_store
{
    public class MainMenu
    {
        public static void Menu(ArrayList products)
        {
            //a variable for assigning item ID
            int idAssignment = 0;
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
                            idAssignment++;
                            StoreManager product = new StoreManager(idAssignment);
                            product.InputItem();
                            products.Add(product);
                            break;
                        }
                    case MenuPoints.Show:
                        {
                            if (products.Count == 0)
                            {
                                Console.WriteLine("List is empty!");
                            }
                            else foreach (StoreManager item in products)
                            {
                                item.ShowItem();
                            }
                            break;
                        }
                    case MenuPoints.Cost:
                        {
                            if (products.Count == 0)
                            {
                                Console.WriteLine("List is empty!");
                            }
                            else 
                            {
                                int cost = 0;
                                for (int i = 0; i < products.Count; i++)
                                {
                                    StoreManager product = (StoreManager)products[i];
                                    cost += product.CalculateCost();
                                }
                                Console.WriteLine($"Total cost: {cost}$");
                            }
                            break;
                        }
                    case MenuPoints.DeleteOne:
                        {
                            if (products.Count == 0)
                            {
                                Console.WriteLine("List is empty!");
                            }
                            else
                            {
                                Console.WriteLine("Input an element number that you want to delete");
                                int delIndex = Input.Integer() - 1;
                                products.RemoveAt(delIndex);
                                
                                //Aftere deletion we move left all remaining ID
                                for (int i = delIndex; i < products.Count; i++)
                                {
                                    StoreManager product = (StoreManager)products[i];
                                    product._ID = i + 1;
                                }
                                idAssignment--;
                            }
                            break;
                        }
                    case MenuPoints.DeleteAll:
                        {
                            if (products.Count == 0)
                            {
                                Console.WriteLine("List is empty!");
                            }
                            else
                            {
                                products.Clear();
                                idAssignment = 0;
                            }
                            Console.WriteLine("Operation complete!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Error! Please input a point from menu!");
                            break;
                        }
                }
                Pause.ContinueAndClear();
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
