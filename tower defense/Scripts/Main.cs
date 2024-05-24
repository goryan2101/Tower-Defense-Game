using System.Threading;
using Godot;
using static Godot.GD;

public partial class Main : Node2D
{

	public static readonly int Width = 1152;
	public static readonly int Height = 648;
	public static readonly int[] Center = new int[2] { Width / 2, Height / 2 };
	public static int Money = 0;
	public static bool GameOver = false;
	private double TimeInterval = 0;
	public override void _Ready()
	{


	}

	public override void _Process(double delta)
	{
		if (!GameOver)
		{
			TimeInterval += delta;
			if (TimeInterval >= 2)
			{
				TimeInterval = 0;
				AddChild(new Enemy());
			}
		}
	}

	public override void _Input(InputEvent @event)
	{
		if (!GameOver)
		{
			if (
				@event is InputEventMouseButton input &&
				input.Pressed &&
				input.Position.X >= 1026
				)
			{
				Print("Unit postavlen))) vse ok");
				AddChild(new Unit(input.Position));
				// Money -= 1;
			}
		}
	}
}
