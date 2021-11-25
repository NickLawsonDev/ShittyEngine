namespace ShittyEngine.Assets;

public class Asset : IAsset
{
    public string Name { get; }
    public Guid Id { get; } = Guid.NewGuid();
    public string Path { get; }
    public Type Type { get; }
    public string Extention { get; }

    public Asset(string name, string path, Type type, string extension)
    {
        Name = name;
        Path = path;
        Type = type;
        Extention = extension;
    }
}