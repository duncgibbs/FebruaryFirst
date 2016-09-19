from classes.characters.Player import Player
from classes.characters.Groundhog import Groundhog
from classes.map.Map import Map

class Game:
	def __init__(self, playerCount):
		self.playerList = [Player() for i in range(playerCount)]
		self.groundhogList = [Groundhog() for i in range(4*playerCount)]
		self.gameMap = Map(playerCount)

