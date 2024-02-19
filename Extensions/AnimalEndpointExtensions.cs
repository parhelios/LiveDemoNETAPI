
namespace LiveDemo.Extensions;

public static class AnimalEndpointExtensions
{
    public static IEndpointRouteBuilder MapAnimalEndpoints(this IEndpointRouteBuilder app)
    {

        var endpointGrp = app.MapGroup("api/animal");

        //CREATE
        endpointGrp.MapPost("/", AddAnimal);

        //READ
        endpointGrp.MapGet("/", GetAllAnimals);

        //UPDATE
        endpointGrp.MapPut("/{id}", ReplaceAnimal);
        endpointGrp.MapPatch("/{id}", UpdateAnimal);

        //DELETE
        endpointGrp.MapDelete("/{id}", DeleteAnimal);

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