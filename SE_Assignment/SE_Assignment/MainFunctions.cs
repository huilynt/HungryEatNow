using System;
using System.Collections.Generic;
using System.Text;
using static SE_Assignment.HelperFunctions;

namespace SE_Assignment
{
    class MainFunctions
    {
        public static List<Account> allAccounts = new List<Account>();
        public static List<Customer> allCustomers = new List<Customer>();
        public static List<Employee> allEmployees = new List<Employee>();
        public static List<Order> allOrders = new List<Order>();
        public static List<StoreAssistant> allStoreAssistants = new List<StoreAssistant>();
        public static List<Dispatcher> allDispatchers = new List<Dispatcher>();
        public static List<FoodItem> allFoodItems = new List<FoodItem>();
        public static List<SetMenu> allSetMenus = new List<SetMenu>();
        public static Menu menu = new Menu(allSetMenus, allFoodItems);

        // Function 1 - Huilin
        // Allow a customer to create a new order (i.e., choose food items or menu, select restaurant, select express delivery, etc.) and pay by credit card or other online means


        // Function 2
        // Allow the manager to manage food items and menus, including adding/updating/deleting of food items and menus
        public static void DisplayManagerMainMenu(Manager manager)
        {
            try
            {
                bool isLoggin = true;
                while (isLoggin)
                {
                    Console.WriteLine("= Manager Main Menu =\n" +
                                      "=====================");
                    Console.WriteLine("1) Manage Food Items\n" +
                                      "2) Manage Menus\n" +
                                      "0) Log Out");
                    Console.Write("Please select an option: ");
                    
                    try
                    {
                        int option = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        switch (option)
                        {
                            case 1:
                                ManagerMenuFood(manager);
                                break;
                            case 2:
                                ManagerMenuSet(manager);
                                break;
                            case 0:
                                isLoggin = false;
                                break;
                            default:
                                isLoggin = true;
                                Console.WriteLine("Please select a valid option!");
                                Console.WriteLine("");
                                break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Please select a valid option!");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Please select a valid option!");
                Console.WriteLine("");
            }

        }

        public static void ManagerMenuFood(Manager manager)
        {

            bool isEditFood = true;
            while (isEditFood)
            {
                Console.WriteLine("= Food Item Menu =\n" +
                                  "==================");
                Console.WriteLine("1) Add new Food Item\n" +
                                  "2) Update Food Item\n" +
                                  "3) Delete Food Item\n" +
                                  "0) Return to Main Menu");
                Console.Write("Please select an option: ");
                try
                {
                    int option = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    
                    switch (option)
                    {
                        case 1:

                            manager.DisplayFoodList(allFoodItems, showHeader: true);
                            int totalCount = allFoodItems.Count;
                            Console.Write("Would you like to add a new food item (Y/N): ");
                            var input = Console.ReadLine().ToLower();
                            Console.WriteLine("");
                            if (input == "y")
                            {
                                Console.Write("Enter food item's name: ");
                                string name = Console.ReadLine();
                                Console.Write("Enter food item's description: ");
                                string description = Console.ReadLine();
                                Console.Write("Enter food item's price: ");
                                double price = double.Parse(Console.ReadLine());
                                Console.Write("Enter food item's units: ");
                                int unit = Int32.Parse(Console.ReadLine());
                                Console.Write("Enter food item's status: ");
                                string status = Console.ReadLine();
                                Console.WriteLine("");
                                Console.WriteLine("= Entered Details =\n" +
                                                  "===================");
                                Console.WriteLine("-Name: {0}\n" +
                                                  "-Description: {1}\n" +
                                                  "-Price: {2}\n" +
                                                  "-Units: {3}\n" +
                                                  "-Status: {4}\n", name, description, price, unit, status);
                                FoodItem temp = new FoodItem(totalCount + 1, name, description, price, unit, status);
                                Console.Write("Are the details correct? (Y/N): ");

                                var reply = Console.ReadLine().ToLower();
                                if (reply == "y")
                                {
                                    Console.WriteLine("== Validating Addition ==");
                                    bool isExist = allFoodItems.Exists(fi => fi.name.ToLower() == temp.name.ToLower());
                                    if (isExist == true)
                                    {
                                        Console.WriteLine("The food item added already exist.");
                                        Console.Write("Would you like to update food item instead? (Y/N): ");
                                        var reply1 = Console.ReadLine().ToLower();
                                        if (reply1 == "y")
                                        {
                                            goto case 2;
                                        }
                                        else if (reply1 == "n")
                                        {
                                            Console.Write("Continue with adding food items? (Y/N): ");
                                            var continuationReply = Console.ReadLine().ToLower();
                                            if (continuationReply == "y")
                                            {
                                                goto case 1;
                                            }
                                            else { break; }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input");
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        // Food item does not exist, can add to list
                                        allFoodItems.Add(temp);
                                        Console.WriteLine("{0} added to list", temp.name);
                                        Console.Write("Continue with adding food items? (Y/N): ");
                                        var continuationReply = Console.ReadLine().ToLower();
                                        if (continuationReply == "y")
                                        {
                                            goto case 1;
                                        }
                                        else if (continuationReply == "n") { break; }
                                        else
                                        {
                                            Console.WriteLine("Invalid input");
                                            break;
                                        }
                                    }
                                }
                                else if (reply == "n")
                                {
                                    temp = loopUpdate(temp);
                                    Console.WriteLine("== Validating Addition ==");
                                    bool isExist = allFoodItems.Exists(fi => fi.name.ToLower() == temp.name.ToLower());
                                    if (isExist == true)
                                    {
                                        Console.WriteLine("The food item added already exist.");
                                        Console.Write("Would you like to update food item instead? (Y/N): ");
                                        var reply1 = Console.ReadLine().ToLower();
                                        if (reply1 == "y")
                                        {
                                            goto case 2;
                                        }
                                        else if (reply1 == "n")
                                        {
                                            Console.Write("Continue with adding food items? (Y/N): ");
                                            var continuationReply = Console.ReadLine().ToLower();
                                            if (continuationReply == "y")
                                            {
                                                goto case 1;
                                            }
                                            else { break; }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input");

                                        }
                                    }
                                    else
                                    {
                                        // Food item does not exist, can add to list
                                        allFoodItems.Add(temp);
                                        Console.WriteLine("Food item added to list");
                                        Console.Write("Continue with adding food items? (Y/N): ");
                                        var continuationReply = Console.ReadLine().ToLower();
                                        if (continuationReply == "y")
                                        {
                                            goto case 1;
                                        }
                                        else if (continuationReply == "n") { break; }
                                        else
                                        {
                                            Console.WriteLine("Invalid input");
                                            Console.WriteLine("");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid reply. Please try again");
                                    Console.WriteLine("");

                                    break;
                                }

                            }
                            else if (input == "n") { break; }
                            else if (input == "exit" || input == "Exit")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid reply. Please try again");
                                Console.WriteLine("");
                                goto case 1;

                            }
                            break;
                        case 2:

                            manager.DisplayFoodList(allFoodItems, showHeader: true);
                            Console.Write("Select a food item to update: ");
                            var selection = Console.ReadLine();
                            Console.WriteLine("");
                            try
                            {
                                if (selection == "exit" || selection == "Exit")
                                {
                                    break;
                                }
                                FoodItem selected = allFoodItems[int.Parse(selection) - 1];
                                //Disply details of selected food item
                                manager.DisplayFoodItem(selected, showHeader: true);

                                selected = loopUpdate(selected);


                                Console.Write("Continue editing food items? (Y/N): ");
                                var reply2 = Console.ReadLine().ToLower();
                                Console.WriteLine("");
                                if (reply2 == "y")
                                {
                                    goto case 2;

                                }
                                else if (reply2 == "n")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input");
                                    Console.WriteLine("");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Invalid input");
                                Console.WriteLine("");
                            }
                            break;
                        case 3:

                            manager.DisplayFoodList(allFoodItems, showHeader: true);
                            Console.Write("Select a food item to be deleted: ");
                            selection = Console.ReadLine();
                            try
                            {
                                
                                if (selection == "exit" || selection == "Exit")
                                {
                                    break;
                                }
                                manager.DisplayFoodItem(allFoodItems[int.Parse(selection) - 1], showHeader: false);

                                Console.Write("Confirm deletion of selected food item (Y/N): ");
                                var response = Console.ReadLine().ToLower();

                                if (response == "y")
                                {
                                    allFoodItems.RemoveAt(int.Parse(selection) - 1);
                                    Console.Write("Continue deleting food item? (Y/N): ");
                                    string reply1 = Console.ReadLine().ToLower();
                                    if (reply1 == "y")
                                    {
                                        goto case 3;
                                    }
                                    else if (reply1 == "n")
                                    {
                                        Console.WriteLine("");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input");
                                        Console.WriteLine("");
                                        break;
                                    }
                                }
                                else if (response == "n")
                                {
                                    goto case 3;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input");
                                    Console.WriteLine("");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Invalid selection");
                                Console.WriteLine("");
                                goto case 3;
                            }
                            break;
                        case 0:
                            DisplayManagerMainMenu(manager);
                            isEditFood = false;
                            break;
                        default:
                            Console.WriteLine("Please select a valid option");
                            Console.WriteLine("");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("");
                }
            }



        }

        public static FoodItem loopUpdate(FoodItem selected_temp)
        {
            bool conflict = false;
            bool isEditing = true;
            while (isEditing)
            {
                Console.Write("What information do you want to edit: ");
                string reply1 = Console.ReadLine().ToLower();

                switch (reply1)
                {
                    case "name":
                        //Console.WriteLine(selected.name);
                        Console.Write("Enter new name: ");
                        string name = Console.ReadLine();
                        conflict = allFoodItems.Exists(fi => fi.name.ToLower() == name.ToLower());
                        if (conflict == true)
                        {
                            Console.WriteLine("Name conflict with existing food items");
                            goto case "name";
                        }
                        selected_temp.name = name;
                        break;
                    case "description":
                        //Console.WriteLine(selected.description);
                        Console.Write("Enter new description: ");
                        string description = Console.ReadLine();
                        selected_temp.description = description;
                        break;
                    case "price":
                        //Console.WriteLine(selected.price);
                        Console.Write("Enter new price: ");
                        double price = double.Parse(Console.ReadLine());
                        selected_temp.price = price;
                        break;
                    case "unit":
                        //Console.WriteLine(selected.unit);
                        Console.Write("Enter new units: ");
                        int unit = Int32.Parse(Console.ReadLine());
                        selected_temp.unit = unit;
                        break;
                    case "status":
                        //Console.WriteLine(selected.status);
                        Console.Write("Enter new status: ");
                        string status = Console.ReadLine();
                        selected_temp.status = status;
                        break;
                    case "done":
                        isEditing = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input, try again");
                        break;
                }
            }
            return selected_temp;
        }

        public static void ManagerMenuSet(Manager manager)
        {
            int totatSetMenuCount = allSetMenus.Count;
            bool isEditSet = true;

            while (isEditSet)
            {
                Console.WriteLine("===Set Menu Menu===");
                Console.WriteLine("1) Add new Set Menu\n" +
                                  "2) Update Set Menu\n" +
                                  "3) Delete Set Menu\n" +
                                  "0) Return to Main Menu");
                Console.Write("Please select an option: ");
                int option = Int32.Parse(Console.ReadLine());
                Console.WriteLine("");


                switch (option)
                {
                    case 1:
                        manager.DisplaySetMenuList(allSetMenus);
                        Console.Write("Would you like to add new set menu? (Y/N): ");
                        string reply = Console.ReadLine().ToLower();

                        if (reply == "y")
                        {
                            Console.Write("Enter set Menu Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter set Menu Description: ");
                            string description = Console.ReadLine();
                            Console.Write("Enter set Menu Price: ");
                            double price = double.Parse(Console.ReadLine());
                            Console.Write("Enter set Menu Unit: ");
                            int unit = Int32.Parse(Console.ReadLine());
                            Console.Write("Enter set Menu Status: ");
                            string status = Console.ReadLine();

                            SetMenu temp = new SetMenu(totatSetMenuCount + 1, name, description, price, unit, status);

                            //check se menu exists
                            bool isExist = allSetMenus.Exists(sm => sm.name.ToLower() == temp.name.ToLower());

                            if (isExist == true)
                            {
                                Console.WriteLine("Set Menu already exists.");
                                Console.Write("Do you want to update exisitng Set Menu(s) instead? (Y/N): ");
                                string input = Console.ReadLine().ToLower();
                                if (input == "y")
                                {
                                    goto case 2;
                                }
                                else if (input == "n")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Input");
                                    Console.WriteLine("");
                                }
                            }
                            else
                            {
                                temp = AddItemtoSetMenu(manager, temp, allFoodItems);
                                //Unique set menu ==> add to set menu list
                                allSetMenus.Add(temp);
                            }

                        }
                        else if (reply == "n")
                        {
                            break;
                        }
                        else if (reply == "exit" || reply == "Exit")
                        {
                            break;
                        } 
                        else
                        {
                            Console.WriteLine("Invalid input");
                            Console.WriteLine("");
                            goto case 1;
                        }

                        break;
                    case 2:
                        manager.DisplaySetMenuList(allSetMenus);
                        Console.Write("Select a set menu to update: ");
                        var selection = Console.ReadLine();
                        Console.WriteLine("");
                        try
                        {
                            if (selection == "exit" || selection == "Exit")
                            {
                                break;
                            }

                            SetMenu currentSelected = allSetMenus[int.Parse(selection) - 1];
                            manager.DisplaySetMenuItem(currentSelected, showHeader: true);
                            Console.WriteLine("");
                            Console.Write("Do you want to 'add' or 'remove' item from set menu: ");
                            string o = Console.ReadLine().ToLower();
                            if (o == "add")
                            {
                                currentSelected = AddItemtoSetMenu(manager, currentSelected, allFoodItems);
                            }
                            else if (o == "remove")
                            {
                                currentSelected = RemoveItemFromSetMenu(manager, currentSelected);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                Console.WriteLine("");
                                break;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input");
                            Console.WriteLine("");
                            break;
                        }
                        break;
                    case 3:
                        manager.DisplaySetMenuList(allSetMenus, showHeader: true);

                        Console.Write("Select a set menu to be deleted: ");
                        var selectDelete = Console.ReadLine();
                        try
                        {
                            if (selectDelete == "exit" || selectDelete == "Exit")
                            {
                                break;
                            }
                            SetMenu currentSelected = allSetMenus[int.Parse(selectDelete) - 1];
                            Console.Write("Confirm deletion of {0}? (Y/N): ", currentSelected.name);

                            string response = Console.ReadLine().ToLower();
                            if (response == "y")
                            {
                                allSetMenus.Remove(currentSelected);
                                Console.Write("Continuation of set menu deletion? (Y/N): ");
                                string response1 = Console.ReadLine().ToLower();
                                if (response1 == "y")
                                {
                                    goto case 3;
                                }
                                else if (response1 == "n")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input");
                                    Console.WriteLine("");
                                    goto case 3;
                                }

                            }
                            else if (response == "n")
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                Console.WriteLine("");

                            }

                        }
                        catch
                        {
                            Console.WriteLine("Invalid input");
                            Console.WriteLine("");
                        }

                        break;
                    case 0:
                        DisplayManagerMainMenu(manager);
                        isEditSet = false;
                        break;
                    default:
                        Console.WriteLine("Please select a valid option");
                        Console.WriteLine("");
                        break;
                }

            }
        }

        public static SetMenu AddItemtoSetMenu(Manager manager, SetMenu menu, List<FoodItem> foodItemList)
        {
            bool done = false;
            List<FoodItem> tempList = new List<FoodItem>();
            if (menu.foodItemList is null)
            {
                tempList = menu.foodItemList;
            }
            else
            {
                tempList = menu.foodItemList;
            }

            int totalFoodItemCount = foodItemList.Count;
            while (done == false)
            {

                manager.DisplayFoodList(foodItemList, showHeader: true);
                Console.Write("Select a food item to be added: ");
                try
                {
                    var selection = Console.ReadLine();
                    if (selection == "Exit" || selection == "exit")
                    {
                        break;
                    }
                    FoodItem selected = foodItemList[int.Parse(selection) - 1];
                    Console.Write("Confirm the addition of {0}? (Y/N): ", selected.name);
                    string response = Console.ReadLine().ToLower();
                    if (response == "y")
                    {
                        if (tempList is null)
                        {
                            tempList.Add(selected);
                            Console.WriteLine("Added {0}", selected.name);
                        }
                        else
                        {
                            bool isExist = tempList.Exists(fi => fi.name == selected.name);

                            if (isExist == true)
                            {
                                Console.WriteLine("Selected item already added in Set Menu. \n" +
                                    "Please choose another option.");
                                Console.WriteLine("");
                            }
                            else
                            {
                                tempList.Add(selected);
                                Console.WriteLine("Added {0}", selected.name);
                            }
                            Console.Write("Continue adding food item to set menu? (Y/N): ");
                            var response1 = Console.ReadLine().ToLower();
                            if (response1 == "y")
                            {
                                continue;
                            }
                            else if (response1 == "n")
                            {
                                done = true;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input");
                            }
                        }
                    }
                    else if (response == "n")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                }
            }
            menu.foodItemList = tempList;
            return menu;
        }

        public static SetMenu RemoveItemFromSetMenu(Manager manager, SetMenu menu)
        {
            //set menu's food item list is not null
            bool done = false;
            while (done == false)
            {
                Console.WriteLine("= Current Set Menu Items =\n" +
                  "==========================");
                manager.DisplayFoodList(menu.foodItemList, showHeader: false);

                Console.Write("Selet a food item to be removed: ");

                try
                {
                    var selection = Console.ReadLine();
                    if (selection == "exit" || selection == "Exit")
                    {
                        break;
                    }
                    FoodItem selected = menu.foodItemList[int.Parse(selection) - 1];

                    Console.Write("Confirm deletion of {0}? (Y/N): ", selected.name);
                    string reply = Console.ReadLine().ToLower();
                    if (reply == "y")
                    {
                        menu.foodItemList.Remove(selected);
                        Console.Write("Cotinuation of deleting food item? (Y/N): ");
                        string reply1 = Console.ReadLine().ToLower();
                        if (reply1 == "y")
                        {
                            continue;
                        }
                        else if (reply1 == "n")
                        {
                            done = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please select a valid option");
                        }
                    }
                    else if (reply == "n")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Please select a valid option");
                    }
                }
                catch
                {
                    Console.WriteLine("Please select a valid option");
                }
            }
            return menu;
        }

        // Function 3 - Huilin
        // Allow a chef to select the order he wishes to prepare and update the order for dispatch once the order is ready
        public static void DisplayChefMenu(Chef chef)
        {
            while (true)
            {
                Console.WriteLine("Chef Menu");
                Console.WriteLine("=========");
                Console.WriteLine("1 Prepare Order");
                Console.WriteLine("2 Ready Order");
                Console.WriteLine("0 Logout");
                Console.Write("Please select an option: ");

                try
                {
                    int option = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    // 1. Chef chooses Prepare Order
                    if (option == 1)
                    {
                        // 2. System displays New Order(s)
                        Console.WriteLine("Showing all New orders");
                        List<Order> orderByStateList = GetOrdersByState(new NewOrderState());
                        // 5. System displays Order information
                        DisplayOrders(orderByStateList, new NewOrderState());
                        Console.Write("Select an order: ");

                        int orderOption = -1;
                        try
                        {
                            // 3. Chef selects an Order
                            orderOption = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            // 4. System retrieves selected Order
                            Order chosenOrder = GetOrderById(orderOption);

                            if (chosenOrder == null)
                            {
                                Console.WriteLine("Invalid Order.");
                            }
                            else
                            {
                                // 5. System prompts to Confirm or Cancel changing Order Status to Preparing
                                Console.WriteLine($"Change Order {orderOption} to Preparing?");
                                Console.WriteLine("1 Confirm");
                                Console.WriteLine("2 Cancel");
                                Console.Write("Select an option: ");

                                int confirmOption = Int32.Parse(Console.ReadLine());

                                Console.WriteLine("");

                                // 6. Chef selects Confirm
                                if (confirmOption == 1)
                                {
                                    // 7. System updates Order Status to Preparing
                                    // 8. System displays ‘Order Status changed to Preparing’
                                    // 9. Use case ends
                                    chef.prepareOrder(chosenOrder);
                                }
                                // 6.1 Chef selects Cancel
                                // 6.2 Use case ends
                                else if (confirmOption == 2)
                                {
                                    Console.WriteLine($"Cancelled changing Order {orderOption} to Preparing");
                                }
                                else
                                {
                                    Console.WriteLine("Please select a valid option!\n");
                                }
                            }
                        }
                        // 3.1 System prompts to enter a valid Order
                        // 3.2 System returns to Step 2
                        catch
                        {
                            Console.WriteLine("Please select a valid Order!\n");
                        }
                    }
                    // 1. Chef chooses Dispatch Order
                    else if (option == 2)
                    {
                        // 2. System displays Order(s) with ‘Preparing’ Status
                        Console.WriteLine("Showing all Preparing orders");
                        List<Order> orderByStateList = GetOrdersByState(new PreparingOrderState());
                        DisplayOrders(orderByStateList, new PreparingOrderState());
                        Console.Write("Select an order: ");

                        try
                        {
                            // 3. Chef selects an Order
                            int orderOption = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            // 4. System retrieves selected Order
                            Order chosenOrder = GetOrderById(orderOption);

                            if (chosenOrder == null)
                            {
                                Console.WriteLine("Invalid Order.");
                            }
                            else
                            {
                                // 5. System prompts to Confirm or Cancel changing Order Status to ‘Ready’
                                Console.WriteLine($"Change Order {orderOption} to Ready?");
                                Console.WriteLine("1 Confirm");
                                Console.WriteLine("2 Cancel");
                                Console.Write("Select an option: ");

                                int confirmOption = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("");

                                // 6. Chef selects Confirm
                                if (confirmOption == 1)
                                {
                                    // 7. System updates Order Status to ‘Ready’
                                    // 8. System displays ‘Order Status changed to Ready’
                                    // 9. Use case ends
                                    chef.readyOrder(chosenOrder);
                                }
                                // 7.1 Chef chooses to cancel Status change
                                // 7.2 Use case ends
                                else if (confirmOption == 2)
                                {
                                    Console.WriteLine($"Cancel changing Order {orderOption} to Ready");
                                }
                                else
                                {
                                    Console.WriteLine("Please select a valid option!");
                                }
                            }
                        }
                        // 3.1 System prompts to enter a valid Order
                        // 3.2 System returns to Step 2
                        catch { Console.WriteLine("Please select a valid order!"); }
                    }
                    // Logout
                    else if (option == 0) { break; }
                    // Invalid option
                    else { Console.WriteLine("Please select a valid option!"); }
                }
                catch { Console.WriteLine("Please select a valid option!"); }
            }
        }


        // Function 5
        // Allow the manager to view orders using various filters such as new, cancelled, delivered, delivering, archived, ready, preparing.

    }
}
