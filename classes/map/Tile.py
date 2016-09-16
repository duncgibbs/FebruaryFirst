from random import randint, choice
from classes.map.Resource import Resource

class Tile:
	def __init__(self):
		self.resources = []
		self.__populateResources()

	def __populateResources(self):
		for index in range(randint(2,6)):
			self.resources.append(Resource(choice(['food', 'water', 'sex'])))