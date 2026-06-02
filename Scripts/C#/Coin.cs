using Godot;
using System;

public partial class Coin : Area2D
{
    public override void _Ready()
    {
        // Subscribe to the C# event tracking body entry
        BodyEntered += OnBodyEntered;
    }

    private void OnBodyEntered(Node body)
    {
		GD.Print("+1 coin!");
		QueueFree();
    }

    public override void _ExitTree()
    {
        BodyEntered -= OnBodyEntered;
    }

}
