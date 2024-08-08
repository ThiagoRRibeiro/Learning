using Godot;

public partial class Target : Node3D
{
	Vector3 direction = Vector3.Zero;

	[Export]
	float speed = 5;

	//public override void _Input(InputEvent e)
	//{

	//	if (e is InputEventKey inputEvent)
	//	{
	//		if (inputEvent.IsPressed())
	//		{
	//			GD.Print("KeyPressed");

	//			if (inputEvent.Keycode == Key.Up)
	//			{
	//				GD.Print("Up arrow");
	//				direction.Z -= 1;
	//			}
	//			if (inputEvent.Keycode == Key.Down)
	//			{
	//				GD.Print("Down arrow");
	//				direction.Z += 1;
	//			}
	//			if (inputEvent.Keycode == Key.Left)
	//			{
	//				GD.Print("Left arrow");
	//				direction.X -= 1;
	//			}
	//			if (inputEvent.Keycode == Key.Right)
	//			{
	//				GD.Print("Right arrow");
	//				direction.X += 1;
	//			}
	//		}
	//		if (inputEvent.IsReleased())
	//		{
	//			GD.Print("KeyReleased");
	//		}
	//	}

	//	base._Input(e);
	//}

	public override void _Process(double delta)
	{
		base._Process(delta);

		//GD.Print($"MoveUp {Input.GetActionStrength("MoveUp")}");
		//GD.Print($"MoveDown {Input.GetActionStrength("MoveDown")}");
		//GD.Print($"MoveLeft {Input.GetActionStrength("MoveLeft")}");
		//GD.Print($"MoveRight {Input.GetActionStrength("MoveRight")}");

		float vertical = Input.GetActionStrength("MoveDown") - Input.GetActionStrength("MoveUp");
		float horizontal = Input.GetActionStrength("MoveRight") - Input.GetActionStrength("MoveLeft");

		direction = new Vector3(horizontal, 0, vertical);

		//GD.Print($"vertical {vertical}");
		//GD.Print($"horizontal {horizontal}");

		Transform3D t = GlobalTransform;
		t.Origin += direction * (float)delta * speed;

		GlobalTransform = t;

		//direction = Vector3.Zero;
	}
}
