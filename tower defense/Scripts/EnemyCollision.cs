using Godot;
using System;

public partial class EnemyCollision : CollisionShape2D
{
	float hue = 0;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Shape = new RectangleShape2D();
		Scale = new Vector2(1, 3.3F);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
}
