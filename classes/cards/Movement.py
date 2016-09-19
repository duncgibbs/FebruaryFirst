from classes.cards.Card import Card

class Movement(Card):
	def __init__(self):
		self.__init__(self,'')

	def __init__(self, direction):
		Card.__init__(self)
		self.direction = direction