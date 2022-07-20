using SolutionLiskovSubstitution.Models;

FlyingBird eagle = new Eagle(5, 0.90);
eagle.Eat();
eagle.Fly();

Bird penguin = new Penguin(60, 1.50);
penguin.Eat();