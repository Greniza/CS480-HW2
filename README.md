# Homework 2 Features

I (Petraea) created a single feature-set that combined all four of the project requirements together (Aren't I clever?).

I found that, when I first played the game, I was a hair confused about where to go. As such, I added a set of particles and checkpoints to show you the way!

When you start, you will find a beam of particles pointing you towards checkpoint one. (Uses linear interpolation to point in that direction).

As you get very close to checkpoint one, you will find that the particle beam shrinks; the distance to the next checkpoint is calculated using a dot product.

As you touch checkpoint one, a trigger changes the direction of the particle beam, and a small synth sound effect plays to signify that you're on the correct track!
