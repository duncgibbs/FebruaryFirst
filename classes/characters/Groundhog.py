from classes.characters.Character import Character
from random import randint, shuffle, choice

class Groundhog(Character):
	def __init__(self):
		Character.__init__(self)
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
		resources = shuffle(['food','water','sex'])
		multipliers = [-2,-1,1,2,3]
		criteria = {}
		for i in range(randint(0,2)):
			criteria[resources[i]] = choice(multipliers)

	def countResources(self):
		results = {}
		for resource in self.resources:
			if resource.name not in results:
				results[resource.name] = 0
			results[resource.name] += 1
		return results