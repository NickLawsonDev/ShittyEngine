using Microsoft.Xna.Framework.Content;

namespace ShittyEngine.Render;

public class SceneManager : IManager
{
    private ContentManager _contentManager;

    public List<Scene> Scenes { get; set; } = new List<Scene>();

    public SceneManager(ContentManager contentManager)
    {
        _contentManager = contentManager;
    }

    public void AddScene(string name)
    {
        if (string.IsNullOrEmpty(name)) throw new Exception("Name cannot be null");

        var scene = new Scene(name, _contentManager);

        Scenes.Add(scene);
    }
    
    public void AddScene(Scene scene)
    {
        if (scene == null) throw new NullReferenceException();

        Scenes.Add(scene);
    }

    public void RemoveScene(Scene scene)
    {
        Scenes.Remove(scene);
    }

    public void LoadContent()
    {
        foreach(var scene in Scenes)
        {
            scene.LoadContent();
        }
    }

    public void UnloadContent()
    {
        foreach(var scene in Scenes)
        {
            scene.UnloadContent();
        }
        Scenes.Clear();
    }

    public void Update(GameTime gameTime)
    {
        foreach(var scene in Scenes)
        {
            scene.Update(gameTime);
        }
    }

    public void Draw(GameTime gameTime)
    {
        foreach (var scene in Scenes)
        {
            scene.Draw(gameTime);
        }
    }
}