from classes.cards.Card import Card

class Action(Card):
	def __init__(self):
		Card.__init__(self)
		self.action = ''