// See https://aka.ms/new-console-template for more information
using Collection;

Item item = new Item();
item.practice();

UserLists users = new UserLists();
users.userLists();

ArrayBuilder<string> names = new ArrayBuilder<string>(10);

names.Add("Alice");
names.Add("Bob");
names.Add("Charlie");
names.Add("David");
names.Add("Eve");
names.Print();

Console.WriteLine("Hello, World!");

