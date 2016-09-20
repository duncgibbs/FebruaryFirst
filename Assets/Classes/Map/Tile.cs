using System;

public class Tile {
	public Resource[] resources;
	private Random rand;

	public Tile() {
		rand = new Random ();
		resources = new Resource[rand.Next(2,6)];
		populateResources ();
	}

	private void populateResources() {
		for (int i = 0; i < resources.Length; i++) {
			string resource = Resource.RESOURCE_TYPES [rand.Next (Resource.RESOURCE_TYPES.Length)];
			resources [i] = new Resource(resource);
		}
	}
}
