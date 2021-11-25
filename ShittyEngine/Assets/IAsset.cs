namespace ShittyEngine.Assets;

public interface IAsset
{
    string Name { get; }
    Guid Id { get; }
    string Path { get; }
    Type Type { get; }
    string Extention { get; }
}