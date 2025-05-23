namespace DevLabs.Api.Mappings;

public static class MapsterConfig
{
    public static void RegisterMappings()
    {
        AutorMapping.Register();
        LivroMapping.Register();
        CarMapping.Register();
    }
}