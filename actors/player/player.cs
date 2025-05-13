using ForgeOn.Entities;
using Godot;
using System;

public partial class Player : CharacterBody2D, iActor
{

    AnimationPlayer animationPlayer;
    Sprite2D sprite;
    

    public void animate(string animationName)
    {
        throw new NotImplementedException();
    }

    public void emote(string emoteName)
    {
        throw new NotImplementedException();
    }

    public void execute()
    {
        throw new NotImplementedException();
    }

    public void jump(double heightUnits, Vector2 direction)
    {
        throw new NotImplementedException();
    }

    public void move(double speed, Vector2 direction, bool isRunning, bool isFloating)
    {
        throw new NotImplementedException();
    }

    public void stop()
    {
        throw new NotImplementedException();
    }
}