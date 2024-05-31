namespace ConsoleApp1;

public class Trash
{
    private IList<object> objects = new List<object>();
    private static List<object> _objects;

    public void AddprojectToTrash(object item)
    {
        _objects.Add(item);
    }

    public static void ClearTrash()
    {
        _objects = new List<object>();
    }


    public static void AddObjectToTrash(string item)
    {
        throw new NotImplementedException();
    }
}