using System;
using System.Collections;
using static Inputs.NumbersInput;

namespace Online_store
{
    public class MainMenu
    {
        public static void Menu(ArrayList products)
        {
            do
            {
                int choice;
                ChooseMenuPoint(out choice);

                if (choice == 6) break;
 
                switch ((MenuPoints)choice)
                {
                    case MenuPoints.Add:
                        {
                            StoreManager product = new StoreManager();
                            product.InputItem();
                            products.Add(product);
                            break;
                        }
                    case MenuPoints.Show:
                        {
                            if (IsEmpty(products)) break;
                            ShowProducts(products);
                            break;
                        }
                    case MenuPoints.CountAndCost:
                        {
                            if (IsEmpty(products)) break;
                            CountAllProductPrice(products);
                            break;
                        }
                    case MenuPoints.DeleteOne:
                        {
                            if (IsEmpty(products)) break;
                            DeleteOneProduct(products);
                            break;
                        }
                    case MenuPoints.DeleteAll:
                        {
                            if (IsEmpty(products)) break;
                            DeleteAllProducts(products);
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

        static void ChooseMenuPoint(out int choice)
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1 - Add item");
            Console.WriteLine("2 - Show items");
            Console.WriteLine("3 - All items count and cost");
            Console.WriteLine("4 - Delete item");
            Console.WriteLine("5 - Delete all items");
            Console.WriteLine("6 - Exit");
            Console.Write("Command: ");
            choice = Integer("Command");
            Console.Clear();
        }

        public enum MenuPoints
        {
            Add = 1,
            Show,
            CountAndCost,
            DeleteOne,
            DeleteAll,
            Exit,
        }
        
        static bool IsEmpty(ArrayList products)
        {
            if(products.Count == 0)
            {
                Console.WriteLine("List is empty!");
                return true;
            }
            else
            {
                return false;
            }
        }

        static void ShowProducts(ArrayList products)
        {   
            foreach (StoreManager item in products)
            {
                    item.ShowItem();
            }
        }

        static void CountAllProductPrice(ArrayList products)
        {
            int count = 0;
            int cost = 0;
            for (int i = 0; i < products.Count; i++)
            {
                StoreManager product = (StoreManager)products[i];
                count += product.ReturnCount();
                cost += product.CalculateCost();
            }
            Console.WriteLine($"Total: {count}");
            Console.WriteLine($"Total cost: {cost}$");
        }

        static void DeleteOneProduct(ArrayList products)
        {
            Console.WriteLine("Please input product ID which you want to delete ");
            Console.Write("ID: ");
            int deleteItemIndex = Integer("ID");
            products.RemoveAt(deleteItemIndex - 1);

            for (int i = deleteItemIndex - 1; i < products.Count; i++)
            {
                StoreManager product = (StoreManager)products[i];

                if (i == deleteItemIndex - 1)
                {
                    product.Assigne_ID(deleteItemIndex);
                }
                else
                {
                    product.Assigne_ID();
                }
            }
        }

        static void DeleteAllProducts(ArrayList products)
        {
            StoreManager product = (StoreManager)products[0];
            product.Drop_ID();
            products.Clear();
            Console.WriteLine("Operation complete!");
        }
    }
}