using ProblemInterfaceSegregation.Models;
using ProblemInterfaceSegregation.Models.Interface;

IFlyingBird eagle = new Eagle(5, 0.90);
eagle.Eat();
eagle.Fly();
eagle.Glide();
eagle.Jump();
eagle.Run();

ISwimmingBird penguin = new Penguin(60, 1.50);
penguin.Eat();
penguin.Jump();
penguin.Run();
penguin.Swim();