using gameStoreAPI.DTO;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
const string GetGameRouteName = "GetGame";

List<GameDTO> games = new List<GameDTO>
            {
                new GameDTO(1, "The Witcher 3: Wild Hunt", "RPG", 59.99m, new DateOnly(2015, 5, 19)),
                new GameDTO(2, "Cyberpunk 2077", "RPG", 49.99m, new DateOnly(2020, 12, 10)),
                new GameDTO(3, "Red Dead Redemption 2", "Action-Adventure", 39.99m, new DateOnly(2018, 10, 26)),
                new GameDTO(4, "The Legend of Zelda: Breath of the Wild", "Action-Adventure", 59.99m, new DateOnly(2017, 3, 3)),
                new GameDTO(5, "Dark Souls III", "Action RPG", 29.99m, new DateOnly(2016, 3, 24))
            };

//GET all games
app.MapGet("/games", () => games);

//GET game by id
app.MapGet("/games/{id}", (int id) =>
{
    var game = games.Find(game => game.Id == id);
    return game is not null ? Results.Ok(game) : Results.NotFound();
}
).WithName(GetGameRouteName);

//POST a new game
app.MapPost("/games", (CreateGameDTO newGame) =>
{
    GameDTO game = new(
        games.Count + 1,
        newGame.Name,
        newGame.Genre,
        newGame.Price,
        newGame.ReleaseDate
        );
    games.Add(game);

    return Results.CreatedAtRoute(GetGameRouteName, new { id = game.Id }, game);
});

//PUT a game
app.MapPut("/games/{id}", (int id, UpdateGameDTO updatedGame) =>
{
    var game = games.Find(game => game.Id == id);
    if (game is null) {
        return Results.NotFound();
    }
    GameDTO updated = game with
    {
        Name = updatedGame.Name,
        Genre = updatedGame.Genre,
        Price = updatedGame.Price,
        ReleaseDate = updatedGame.ReleaseDate
    };
    games[games.IndexOf(game)] = updated;
    return Results.NoContent();
});

//DELETE a game
app.MapDelete("/games/{id}", (int id) =>
{
    var game = games.Find(game => game.Id == id);
    if (game is null) {
        return Results.NotFound();
    }
    games.Remove(game);
    return Results.NoContent();
});

app.Run();