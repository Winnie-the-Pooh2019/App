using Godot;

namespace App;

public partial class Main : Control {
	private Vector2 startButtonScale { get; set; }

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		startButtonScale = GetNode<AnimatedSprite2D>("StartTexture").Scale;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) { }

	private void _on_button_pressed() => GetTree().ChangeSceneToFile("res://Second.tscn");

	private void _on_button_mouse_entered() => GetNode<AnimatedSprite2D>("StartTexture").Scale =
		new Vector2(startButtonScale.X * 1.05f, startButtonScale.Y * 1.05f);

	private void _on_start_mouse_exited() => GetNode<AnimatedSprite2D>("StartTexture").Scale = startButtonScale;
}
