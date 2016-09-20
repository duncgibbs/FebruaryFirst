public class Board {
	public Player[] players;
	public Groundhog[] groundhogs;
	public Map map;

	public Board(int playerCount) {
		players = new Player[playerCount];
		generatePlayers ();
		groundhogs = new Groundhog[playerCount * 4];
		generateGroundhogs ();
		map = new Map (playerCount);
	}

	private void generatePlayers() {
		for (int i = 0; i < players.Length; i++) {
			players [i] = new Player ();
		}
	}

	private void generateGroundhogs() {
		for (int i = 0; i < groundhogs.Length; i++) {
			groundhogs [i] = new Groundhog ();
		}
	}
}
