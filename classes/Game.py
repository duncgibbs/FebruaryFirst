from classes.characters.Player import Player
from classes.map.Map import Map

class Game:
	def __init__(self, playerCount):
		self.playerList = [Player() for i in range(playerCount)]
		self.gameMap = Map(playerCount)

