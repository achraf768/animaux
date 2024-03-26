using System;

public abstract class Animal
{
    // Propriété pour stocker le nom de l'animal
    public string Name { get; set; }

    // Constructeur par défaut (peut être utilisé pour créer un animal sans nom)
    public Animal()
    {
        // Le constructeur par défaut peut rester vide, 
        // le nom de l'animal sera initialisé à null ou à une chaîne vide.
    }

    // Constructeur prenant le nom de l'animal en paramètre
    public Animal(string name)
    {
        // Initialise le nom de l'animal avec la valeur passée en paramètre
        this.Name = name;
    }

    // Méthode abstraite pour faire bouger l'animal
    public abstract void Move();

    // Méthode abstraite pour faire dormir l'animal
    public abstract void Sleep();
}

// Classe dérivée Cat
public class Cat : Animal
{
    // Constructeur utilisant le constructeur de la classe de base pour initialiser le nom
    public Cat(string name) : base(name)
    {
    }

    // Implémentation de la méthode Move pour un chat
    public override void Move()
    {
        // Affiche un message spécifique pour le déplacement d'un chat
        Console.WriteLine("Cat moves quietly");
    }

    // Implémentation de la méthode Sleep pour un chat
    public override void Sleep()
    {
        // Affiche un message spécifique pour le sommeil d'un chat
        Console.WriteLine("Cat sleeps soundly");
    }
}

// Classe dérivée Griffin
public class Griffin : Animal
{
    // Constructeur utilisant le constructeur de la classe de base pour initialiser le nom
    public Griffin(string name) : base(name)
    {
    }

    // Implémentation de la méthode Move pour un griffin
    public override void Move()
    {
        // Affiche un message spécifique pour le déplacement d'un griffin
        Console.WriteLine("Griffin flies swiftly");
    }

    // Implémentation de la méthode Sleep pour un griffin
    public override void Sleep()
    {
        // Affiche un message spécifique pour le sommeil d'un griffin
        Console.WriteLine("Griffin rests on its perch");
    }
}

// Classe dérivée Dragon
public class Dragon : Animal
{
    // Constructeur utilisant le constructeur de la classe de base pour initialiser le nom
    public Dragon(string name) : base(name)
    {
    }

    // Implémentation de la méthode Move pour un dragon
    public override void Move()
    {
        // Affiche un message spécifique pour le déplacement d'un dragon
        Console.WriteLine("Dragon soars through the skies");
    }

    // Implémentation de la méthode Sleep pour un dragon
    public override void Sleep()
    {
        // Affiche un message spécifique pour le sommeil d'un dragon
        Console.WriteLine("Dragon rests in its lair");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Création d'une instance de la classe Cat
        Cat cat = new Cat("Simba");
        Console.WriteLine($"{cat.Name} is:");
        cat.Move();
        cat.Sleep();

        // Création d'une instance de la classe Griffin
        Griffin griffin = new Griffin("Thunder");
        Console.WriteLine($"{griffin.Name} is:");
        griffin.Move();
        griffin.Sleep();

        // Création d'une instance de la classe Dragon
        Dragon dragon = new Dragon("Smaug");
        Console.WriteLine($"{dragon.Name} is:");
        dragon.Move();
        dragon.Sleep();
    }
}
