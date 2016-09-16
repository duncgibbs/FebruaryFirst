from classes.characters.Character import Character
from classes.cards.Upgrade import Upgrade
from classes.cards.Action import Action

class Player(Character):
	def __init__(self):
		Character.__init__(self)
		self.upgradeCards = []
		self.actionCards = []