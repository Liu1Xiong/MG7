# MG7
## Devlog
The TreeOfBirds script basically makes the sparrows appear once we get close to them. In terms of array, it stores all the sparrow game objects apart from the sparrow_start one which lets me use Update() and foreach to check
every individual bird each frame in one swoop. Vectors are used for making the birds appear when the player gets close via Veector3.distance which takes the birds world position and the player's local position and calculates the distance
between the two positions. If the distance meets the requirements of the _interactiondistance then the script turns bird.SetActive to true, which is what makes the birds pop out of the tree. 

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
