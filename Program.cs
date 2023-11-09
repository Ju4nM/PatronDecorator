
using PatronDecorator.Component;
using PatronDecorator.ConcreteComponent;
using PatronDecorator.ConcreteDecorator;

ISteve steve = new Steve();
steve = new HelmetDecorator(steve);
steve = new ChestplateDecorator(steve);
steve = new LegginsDecorator(steve);
steve = new BootsDecorator(steve);

int damageTaken = steve.TakeDamage(11);

Console.WriteLine($"Vida restante: {damageTaken}");
