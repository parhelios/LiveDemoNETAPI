
namespace LiveDemo.Extensions;

public static class AnimalEndpointExtensions
{
    public static WebApplication MapAnimalEndpoints(this WebApplication app)
    {
        //CREATE
        app.MapPost("/", AddAnimal);

        //READ
        app.MapGet("/", GetAllAnimals);

        //UPDATE
        app.MapPut("/{id}", ReplaceAnimal);
        app.MapPatch("/{id}", UpdateAnimal);

        //DELETE
        app.MapDelete("/{id}", DeleteAnimal);

        return app;
    }

    private static void DeleteAnimal(AnimalService service, int id)
    {
        //service.Animals.RemoveAt(id);
        service.RemoveAnimal();
    }

    private static void UpdateAnimal(AnimalService service, string type, int id)
    {
        service.Animals[id].Type = type;
    }

    private static void ReplaceAnimal(AnimalService service, int id, Animal animal)
    {
        //service.Animals[id] = animal;
        service.Animals.Replace(animal);
    }

    private static List<Animal> GetAllAnimals(AnimalService service)
    {
        return service.Animals;
    }

    private static void AddAnimal(AnimalService service, Animal animal)
    {
        service.Animals.Add(animal);
    }
}