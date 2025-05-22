using ApiRestFull.AutoMapper;

namespace ApiRestFull.Mappings;

public static class MapsterConfig
{
    public static void RegisterMappings()
    {
        AutorMapping.Register();
        LivroMapping.Register();
    }
}