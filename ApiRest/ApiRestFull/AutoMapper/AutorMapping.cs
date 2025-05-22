using ApiRestFull.Entities;
using ApiRestFull.Dtos;
using Mapster;

namespace ApiRestFull.AutoMapper;

public static class AutorMapping
{
    public static void Register()
    {
        TypeAdapterConfig<Autor, AutorCriarDto>.NewConfig().TwoWays();
        TypeAdapterConfig<Autor, AutorEditarDto>.NewConfig().TwoWays();
        TypeAdapterConfig<Autor, AutorVinculoDto>.NewConfig().TwoWays();
    }
}