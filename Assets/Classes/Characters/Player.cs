using System.Collections.Generic;

public class Player : Character {
	public List<Action> actionCards;
	public List<Upgrade> upgradeCards;

	public Player() {
		actionCards = new List<Action> ();
		upgradeCards = new List<Upgrade> ();
	}

	override public void populateQueue() {
		return;
		//maybe TODO?
	}
}
