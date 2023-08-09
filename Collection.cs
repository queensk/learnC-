namespace Collection
{
    public class Item
    {
        public void practice()
        {
            String[] names = new String[5] {"A", "B", "C", "D", "E"};
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            // foreach(String name in names)
            // {
            //     Console.WriteLine(name);
            // }
        }
    }
}