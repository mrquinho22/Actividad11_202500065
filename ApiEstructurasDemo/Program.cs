using ApiEstructurasDemo.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

var coleccionNodos = new List<NodoElemento>
{
    new() { Id = 10, Valor = "Raiz Inicial (ABB)" },
    new() { Id = 5, Valor = "Hijo Izquierdo" }
};

app.MapGet("/api/nodos", () => Results.Ok(coleccionNodos));

app.MapPost("/api/nodos", (NodoElemento nuevoNodo) =>
{
    if (nuevoNodo.Id <= 0 || string.IsNullOrWhiteSpace(nuevoNodo.Valor))
    {
        return Results.BadRequest("Datos del nodo invalidos.");
    }

    if (coleccionNodos.Any(nodo => nodo.Id == nuevoNodo.Id))
    {
        return Results.Conflict($"Ya existe un nodo con el id {nuevoNodo.Id}.");
    }

    coleccionNodos.Add(nuevoNodo);

    return Results.Created($"/api/nodos/{nuevoNodo.Id}", nuevoNodo);
});

app.Run();
