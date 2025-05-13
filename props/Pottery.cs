using ForgeOn.Entities;
using Godot;

public partial class Pottery : StaticBody2D, iBreakable
{
    [Export]
    public int str { get; set; }

    public void Break()
    {
        throw new System.NotImplementedException();
    }

    public void TestBreak()
    {
        throw new System.NotImplementedException();
    }
}