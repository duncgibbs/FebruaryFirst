public class Action : Card {
	public string action;

	public Action(int cost, string action) : base(cost) {
		this.cost = cost;
		this.action = action;
	}
}
