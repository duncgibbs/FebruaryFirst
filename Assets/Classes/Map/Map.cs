public class Map {
	public Tile[,] board;

	public Map(int playerCount) {
		int initialBoardSize = 3;
		initializeBoard (initialBoardSize * playerCount);
	}

	private void initializeBoard(int size) {
		board = new Tile[size, size];
		for (int i = 0; i < size; i++) {
			for (int j = 0; j < size; j++) {
				board [i,j] = new Tile ();
			}
		}
	}
}
