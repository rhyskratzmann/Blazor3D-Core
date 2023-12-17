using HomagGroup.Blazor3D.Core;

namespace HomagGroup.Blazor3D.Objects;

public class Sprite : Object3D
{
    public Sprite() : base("Sprite")
    {

    }
    
    protected Sprite(string type) : base(type)
    {
    }
}