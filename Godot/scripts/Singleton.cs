using Godot;

public class Singleton : Node
{
	public static Singleton instance;

	public override void _Ready()
	{
		// C# singleton instance initializer for strong typing support
		if (instance != null)
		{
			GD.Print($"Singleton instance was already set, overriding.");
		}
		instance = this;
	}
}
