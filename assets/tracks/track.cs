using Godot;
using System;

public class track : Spatial
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    private void _onDetectionZoneEntered(Node body)
    {
        GD.Print(body.Name);
        if(body is KinematicVehicle)
        {
            ((KinematicVehicle)body).LapTimerStart();
        }
        else if(body.GetParent() is SpatialVehicle)
        {
            ((SpatialVehicle)body.GetParent()).LapTimerStart();
        }
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
