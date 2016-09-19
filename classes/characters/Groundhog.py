from classes.characters.Character import Character
from random import randint, choice

class Groundhog(Character):
	def __init__(self):
		Character.__init__(self)
		self.__populateMovementQueue()
		self.resources = []
		self.criteria = self.buildRandomCriteria()

	def calculateScore(self):
		score = 0
		resourceCount = self.countResources()
		for (resource, amount) in resourceCount.items():
			if resource in self.criteria:
				score += (amount * self.criteria[resource])
			else:
				score += amount
		return score


	def buildRandomCriteria(self):
		resources = ['food','water','sex']
		multipliers = [-2,-1,2,3]
		criteria = {}
		for i in range(randint(0,2)): 
			criteria[choice(resources)] = choice(multipliers)
		return criteria

	def countResources(self):
		results = {}
		for resource in self.resources:
			if resource.name not in results:
				results[resource.name] = 0
			results[resource.name] += 1
		return results

	def __populateMovementQueue(self):
		for i in range(4):
			direction = choice(['up','down','left','right'])
			self.movementQueue.addToQueue(direction)