from classes.map.Tile import Tile

class Map:
	def __init__(self, playerCount):
		initialBoardSize = 3
		self.board = [[Tile() for i in range(initialBoardSize+playerCount)] for j in range(initialBoardSize+playerCount)]
		
	def getTile(self, x, y):
		return self.board[x][y]