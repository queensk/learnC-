using System;
using System.Collections.Generic; // You also need this directive to use List<T>

public class UserLists
{
    List<string> userList = new List<string>() { "user1", "user2", "user3" };

    public void userLists()
    {

        Console.WriteLine("Enter the user name");
        string userName = Console.ReadLine();

        // Check if the user input is in the list and write the result to the console
        
        if (userList.Contains(userName))
        {
            Console.WriteLine("User is present");
        }
        else
        {
            Console.WriteLine("User is not present");
        }
    }

}
