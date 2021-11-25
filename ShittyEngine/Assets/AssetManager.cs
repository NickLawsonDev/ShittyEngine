using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

namespace ShittyEngine.Assets;

public class AssetManager : IManager
{
    private static ContentManager _contentManager { get; set; }
    public List<IAsset> Assets { get; set; } = new List<IAsset>();

    public AssetManager(ContentManager contentManager)
    {
        _contentManager = contentManager;
    }

    public void LoadContent(IAsset asset) {
        if (asset is null) throw new NullReferenceException();

        Assets.Add(asset);

        switch(asset.Type)
        {
            case Type _ when asset.Type == typeof(Texture2D):
                _contentManager.Load<Texture2D>(asset.Name);
                break;
            case Type _ when asset.Type == typeof(Effect):
                _contentManager.Load<Effect>(asset.Name);
                break;
            case Type _ when asset.Type == typeof(SpriteFont):
                _contentManager.Load<SpriteFont>(asset.Name);
                break;
            case Type _ when asset.Type == typeof(SoundEffect):
                _contentManager.Load<SoundEffect>(asset.Name);
                break;
            default:
                throw new ContentLoadException("Could not load " + asset.Name + " asset!");
        }
    }

    public void UnloadContent() {
        _contentManager.Unload();
    }
}