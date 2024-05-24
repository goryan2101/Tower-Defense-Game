using Godot;
using System;
using System.Net;

public partial class Enemy : Area2D
{
	enum GoingState
	{
		Down,
		Right,
		Up,
	};

	public static readonly Texture2D EnemyTexture1 = GD.Load<Texture2D>("res://Assets/Enemys/enemy1.png");
	private float speed = 1;
	private GoingState state = GoingState.Down;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Position = new Vector2(192, 100);
		AddChild(new EnemySprite());
		AddChild(new EnemyCollision());
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (!Main.GameOver)
		{
			speed = 60 * (float)delta;

			switch (state)
			{
				case GoingState.Down:
					Position += new Vector2(0, speed);
					break;
				case GoingState.Right:
					Position += new Vector2(speed, 0);
					break;
				case GoingState.Up:
					Position += new Vector2(0, -speed);
					break;
			}

			if (Position.Y > 448 && state == GoingState.Down)
			{
				Rotation = (float)Math.PI * 3 / 2;
				state = GoingState.Right;
			}
			else if (Position.X > 800 && state == GoingState.Right)
			{
				Rotation = (float)Math.PI;
				state = GoingState.Up;
			}
		}
	}
}
