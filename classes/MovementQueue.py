class MovementQueue:
	def __init__(self):
		self.moveList = []
		self.index = 0

	def next(self):
		move = self.moveList[self.index]
		if self.index + 1 == len(self.moveList):
			self.index = 0
		else:
			self.index += 1
		return move

	def insertIntoQueue(self, newMove, position):
		self.moveList = self.moveList[:position] + [newMove] + self.moveList[position:]
		if position < self.index:
			self.index += 1
