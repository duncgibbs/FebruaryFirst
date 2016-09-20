public abstract class Character {
	public MovementQueue movementQueue;
	//public string name;

	public Character() {
		movementQueue = new MovementQueue ();
	}

	abstract public void populateQueue();
}