using System.Collections.Generic;
using System;

public class Groundhog : Character {
	public List<Resource> resources;
	public Dictionary<string, int> criteria;
	private Random rand;

	public Groundhog() {
		rand = new Random ();
		resources = new List<Resource> ();
		criteria = new Dictionary<string, int> ();
		generateRandomCriteria ();
	}

	override public void populateQueue() {
		for (int i = 0; i < 4; i++) {
			string direction = Movement.POSSIBLE_DIRECTIONS [rand.Next (Movement.POSSIBLE_DIRECTIONS.Length)];
			movementQueue.addToQueue (new Movement (0, direction));
		}
	}

	public void generateRandomCriteria() {
		int[] multipliers = { -2, -2, 2, 3 };
		int numMultipliers = rand.Next (0, 2);
		for (int i = 0; i < numMultipliers; i++) {
			string resource = Resource.RESOURCE_TYPES [rand.Next (Resource.RESOURCE_TYPES.Length)];
			int multiplier = multipliers [rand.Next (multipliers.Length)];
			criteria.Add (resource, multiplier);
		}
	}
}
	
/*
# def calculateScore(self):
# 	score = 0
# 	resourceCount = self.countResources()
# 	for (resource, amount) in resourceCount.items():
# 		if resource in self.criteria:
# 			score += (amount * self.criteria[resource])
# 		else:
# 			score += amount
# 	return score

# def countResources(self):
# 	results = {}
# 	for resource in self.resources:
# 		if resource.name not in results:
# 			results[resource.name] = 0
# 		results[resource.name] += 1
# 	return results
*/