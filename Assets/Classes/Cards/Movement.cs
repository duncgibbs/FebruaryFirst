public class Movement : Card {
	public static string[] POSSIBLE_DIRECTIONS = { "up", "down", "left", "right" };

	public string direction;

	public Movement(int cost, string direction) : base(cost) {
		this.cost = cost;
		this.direction = direction;
	}
}
