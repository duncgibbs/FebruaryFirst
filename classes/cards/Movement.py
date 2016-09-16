from classes.cards.Card import Card

class Movement(Card):
	def __init__(self):
		Card.__init__(self)
		self.direction = ''