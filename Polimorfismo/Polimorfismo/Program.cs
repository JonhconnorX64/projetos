using Polimorfismo;

static void Main(string[] args)
{
    Animal[] animal = [new Mamiferos("leão"), new Repteis("lagarto")];
    CaracteristicasAnimal(animal[0]);
    CaracteristicasAnimal(animal[1]);
    Console.ReadKey();
}

static void CaracteristicasAnimal(Animal animal)
{
    Console.Write(animal.getTipo());
    animal.Caracteristicas();
}
