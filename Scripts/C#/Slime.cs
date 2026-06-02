using Godot;
using System;

public partial class Slime : Node2D
{
	private float SPEED = 60f;
	private RayCast2D ray_cast_left;
	private RayCast2D ray_cast_right;
	private int dir = 1;

    public override void _Ready()
    {
		ray_cast_left = GetNode<RayCast2D>("RayCastLeft");
		ray_cast_right = GetNode<RayCast2D>("RayCastRight");
    }

	public override void _Process(double delta)
	{
		if (ray_cast_right.IsColliding())
		{
			dir = -1;
			
		} 
		else if (ray_cast_left.IsColliding())
		{
			dir = 1;
		}


		Vector2 pos = Position;
		pos.X += dir * SPEED * ((float)delta);
		Position = pos;
	}
}
