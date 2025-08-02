using ApplicationServicesTp;
using DomainModelTp;
using DTOsTp;
using Microsoft.AspNetCore.OpenApi;
using Swashbuckle.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //Falta configurar de manera correcta        
    app.UseHttpLogging();
}

app.UseHttpsRedirection();

app.MapGet("/clientes/{CodPostal}", (string CodPostal) =>
{
    LocalidadService localidadService = new LocalidadService();

    LocalidadDTO dto = localidadService.Get(CodPostal);

    if (dto == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(dto);
})
.WithName("GetCliente")
.Produces<LocalidadDTO>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

app.MapGet("/clientes", () =>
{
    LocalidadService localidadService = new LocalidadService();

    var dtos = localidadService.GetAll();

    return Results.Ok(dtos);
})
.WithName("GetAllClientes")
.Produces<List<LocalidadDTO>>(StatusCodes.Status200OK)
.WithOpenApi();

app.MapPost("/clientes", (LocalidadDTO dto) =>
{
    try
    {
        LocalidadService localidadService = new LocalidadService();

        LocalidadDTO localidadDTO = localidadService.Add(dto);

        return Results.Created($"/clientes/{localidadDTO.CodPostal}", localidadDTO);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddCliente")
.Produces<LocalidadDTO>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapPut("/clientes", (LocalidadDTO dto) =>
{
    try
    {
        LocalidadService localidadService = new LocalidadService();

        var found = localidadService.Update(dto);

        if (!found)
        {
            return Results.NotFound();
        }

        return Results.NoContent();
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("UpdateCliente")
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/localidades/{codPostal}", (string codPostal) =>
{
    LocalidadService localidadService = new LocalidadService();

    var deleted = localidadService.Delete(codPostal);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();

})
.WithName("DeleteCliente")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();

app.Run();
