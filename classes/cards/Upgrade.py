from classes.cards.Card import Card

class Upgrade(Card):
	def __init__(self):
		Card.__init__(self)
		self.upgrade = ''