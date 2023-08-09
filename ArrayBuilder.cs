// Array builder
public class ArrayBuilder<T>
{
    private List<T> list;

    public ArrayBuilder(int capacity = 0)
    {
        list = new List<T>(capacity);
    }
    public void Add(T element)
    {
        list.Add(element);
    }

    public void Insert(int index, T element)
    {
        list.Insert(index, element);
    }

    public void RemoveAt(int index)
    {
        list.RemoveAt(index);
    }

    public void Clear()
    {
        list.Clear();
    }

    public T this[int index]
    {
        get { return list[index]; } 

        set { list[index] = value; }
    }

    public T[] ToArray()
    {
        return list.ToArray();
    }

    public int Count()
    {
        return list.Count();
    }
    // print array
    public void Print()
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    
    }
}

