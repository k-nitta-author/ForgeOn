using Godot;
using System;

public partial class Stage : Node2D
{
	CanvasLayer EffectsLayer;
	CanvasLayer Hud;
	AnimationPlayer anim;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        EffectsLayer = GetNode<CanvasLayer>("Effects");
        Hud = GetNode<CanvasLayer>("Hud");
        anim = GetNode<AnimationPlayer>("AnimationPlayer");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
