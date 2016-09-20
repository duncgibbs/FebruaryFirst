using System.Collections.Generic;

public class MovementQueue {
	public List<Movement> moveList;
	private int index;

	public MovementQueue() {
		moveList = new List<Movement> ();
		index = 0;
	}

	public Movement next() {
		Movement move = moveList [index];
		incrementIndex ();
		return move;
	}

	private void incrementIndex() {
		if (index + 1 == moveList.Count) {
			index = 0;
		} else {
			index++;
		}
	}

	public void addToQueue(Movement move) {
		insertIntoQueue (move, moveList.Count);
	}

	public void insertIntoQueue(Movement move, int position) {
		moveList.Insert (position, move);
		if (position < index) {
			index++;
		}
	}
}
