using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List!");
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      string response = Console.ReadLine();
      if (response == "Add")
      {
        Console.WriteLine("Plese enter the description for the new item");
        string userItem = Console.ReadLine();
        Item userInput = new Item(userItem);
        Console.WriteLine("Would you like to view your list? (Yes/No)");
        string viewList = Console.ReadLine();
        if (viewList == "Yes") {
          List<Item> result = Item.GetAll();
          Console.WriteLine("Here are your To-Do's:");
          foreach (Item element in result)
          {
            Console.WriteLine(element.Description);
          }
        }
        else
        {
          Main();
        }
      }
      else if (response == "View")
      {
        List<Item> result = Item.GetAll();
          Console.WriteLine("Here are your To-Do's:");
          foreach (Item element in result)
          {
            Console.WriteLine(element.Description);
          }
      }
      else
      {
        Main();
      }
    }
  }

}