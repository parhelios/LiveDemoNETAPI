namespace LiveDemo.Extensions;

public static class AnimalEndpointExtensions
{
    public static WebApplication MapAnimalEndpoints(this WebApplication app)
    {
        //CREATE
        app.MapPost("/", (AnimalService service, Animal animal) =>
        {
            service.Animals.Add(animal);
        });

        //READ
        app.MapGet("/", (AnimalService service) => service.Animals);

        //UPDATE
        app.MapPut("/{id}", (AnimalService service, int id, Animal animal) =>
        {
            //service.Animals[id] = animal;
            service.Animals.Replace(animal);
        });

        app.MapPatch("/{id}", (AnimalService service, string type, int id) =>
        {
            service.Animals[id].Type = type;
        });

        //DELETE
        app.MapDelete("/{id}", (AnimalService service, int id) =>
        {
            //service.Animals.RemoveAt(id);
            service.RemoveAnimal();
        });

        return app;
    }
}