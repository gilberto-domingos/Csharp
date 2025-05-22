using ApiRestFull.Dtos;
using ApiRestFull.Entities;
using Mapster;

namespace ApiRestFull.Mappings;

public static class LivroMapping
{
    public static void Register()
    {
        TypeAdapterConfig<Livro, LivroCriarDto>.NewConfig().TwoWays();
        TypeAdapterConfig<Livro, LivroEditarDto>.NewConfig().TwoWays();
    }
}