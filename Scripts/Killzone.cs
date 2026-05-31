using Godot;
using System;

public partial class Killzone : Area2D
{
    private Timer timer;

    public override void _Ready()
    {
        timer = GetNode<Timer>("Timer");
        BodyEntered += OnBodyEntered;
        timer.Timeout += OnTimerEnd;
    }

    private void OnBodyEntered(Node body)
    {
		GD.Print("You Died!");
        timer.Start();
    }

    private void OnTimerEnd()
    {
        GetTree().ReloadCurrentScene();
    }

	protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            BodyEntered -= OnBodyEntered;
        }
        base.Dispose(disposing);
    }

}
