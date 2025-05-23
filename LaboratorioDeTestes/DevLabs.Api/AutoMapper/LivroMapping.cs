using DevLabs.Api.Dtos;
using DevLabs.Api.Entities;
using Mapster;

namespace DevLabs.Api.Mappings;

public static class LivroMapping
{
    public static void Register()
    {
        TypeAdapterConfig<Livro, LivroCriarDto>.NewConfig().TwoWays();
        TypeAdapterConfig<Livro, LivroEditarDto>.NewConfig().TwoWays();
    }
}