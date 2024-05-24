using Godot;
using System;

public partial class City : Area2D
{
	public static int Hp = 100;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void _on_area_entered(Area2D area)
	{
		if (area is Enemy enemy) {
			enemy.QueueFree();
			Hp--;
			if (Hp == 0) {
				Main.GameOver = true;
			}
		}
	}
}



