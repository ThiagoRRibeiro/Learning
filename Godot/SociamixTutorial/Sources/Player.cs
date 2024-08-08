using Godot;

public partial class Player : MeshInstance3D
{
	[Export]
	Node3D Target { get; set; }

	float time = 0;

	public override void _Ready()
	{
		GD.Print("Hello from " + Name);
	}

	public override void _Process(double delta)
	{
		time += (float)delta;

		//GD.Print("Delta time is: " + delta);

		Transform3D t = GlobalTransform;

		t.Origin = new Vector3(0, Mathf.Sin(time) + 2f, 0);
		//t = t.Rotated(t.Basis.Y, time * 0.1f);

		Godot.Quaternion newRotation = Quaternion.FromEuler(new Vector3(0, time, 0));

		t.Basis = new Basis(newRotation);
		
		GlobalTransform = t;

		//GlobalTransform = t.LookingAt(Target.GlobalTransform.Origin, Vector3.Up);

		LookAt(Target.GlobalTransform.Origin, Vector3.Up);

		//RotateY((float)delta * 10);
	}
}
