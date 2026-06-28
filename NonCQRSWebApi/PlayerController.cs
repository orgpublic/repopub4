using NonCQRSWebApi.Models;

public static class PlayerController
{
    public static void MapPlayerEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Player").WithTags(nameof(Player));

        group.MapGet("/", () =>
        {
            return new[] { new Player() };
        })
        .WithName("GetAllPlayers")
        .WithOpenApi();

        group.MapGet("/{id}", (int id) =>
        {
            //return new Player { ID = id };
        })
        .WithName("GetPlayerById")
        .WithOpenApi();

        group.MapPut("/{id}", (int id, Player input) =>
        {
            return TypedResults.NoContent();
        })
        .WithName("UpdatePlayer")
        .WithOpenApi();

        group.MapPost("/", (Player model) =>
        {
            //return TypedResults.Created($"/api/Player/{model.ID}", model);
        })
        .WithName("CreatePlayer")
        .WithOpenApi();

        group.MapDelete("/{id}", (int id) =>
        {
            //return TypedResults.Ok(new Player { ID = id });
        })
        .WithName("DeletePlayer")
        .WithOpenApi();
    }
}
