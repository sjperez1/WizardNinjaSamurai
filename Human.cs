class Human
{
    // Properties for Human
    public string Name {get; set;}
    public int Strength {get; set;}
    public int Intelligence {get; set;}
    public int Dexterity {get; set;}
    public int Health {get; set;}
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    // Add a constructor method that takes a string to initialize Name - and that will initialize Strength, Intelligence, and Dexterity to a default value of 3, and health to default value of 100
    public Human (string name) {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }
    // Add a constructor to assign custom values to all fields
    // Let's create an additional constructor that accepts 5 parameters, so we can set custom values for every field.
    public Human (string name, int strength, int intelligence, int dexterity, int health) {
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
        Health = health;
    }
    // Build Attack method
    // Now add a new method called Attack, which when invoked, should reduce the health of a Human object that is passed as a parameter. The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker). This method should return the remaining health of the target object.
    public virtual int Attack(Human target)
    {
        target.Health -= Strength * 5;
        // Console.WriteLine("target health from base " + target.Health);
        return target.Health;
    }
}

