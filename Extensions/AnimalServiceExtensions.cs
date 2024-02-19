namespace LiveDemo.Extensions;

public static class AnimalServiceExtensions
{
    public static AnimalService RemoveAnimal(this AnimalService service)
    {
        return service;
    }

    public static void Replace<T>(this List<T> myList, T item)
    {
        
    }
}