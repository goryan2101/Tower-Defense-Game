using Godot;

public partial class Unit : Sprite2D
{
	private static readonly Texture2D Pistole = GD.Load<Texture2D>("res://Assets/pistol.png");

	public Unit(Vector2 InitialPos)
	{
		Position = InitialPos;
		Texture = Pistole;
	}

	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
	}

}



