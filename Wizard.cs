class Wizard : Human
{
    public Wizard(string name) : base(name){
        Health = 50;
        Intelligence = 25;
    }

    public Wizard(string name, int strength, int intelligence, int dexterity, int health) 
    : base(name, strength, intelligence, dexterity, health ){
    }

    public override int Attack(Human target)
    {
        // variables without target in front of them, like Intelligence and Health, will be the values given to the Wizard that is not being passed in as the target wizard.
        // taking away health from the target wizard.
        int damage= Intelligence * 5; 
        target.Health -= damage;
        // Add the damage back to the attacking wizard
        Health += damage;
        Console.WriteLine("wizard target health " + target.Health);
        Console.WriteLine("wizard attack health " + Health);
        return target.Health;
    }

    public int Heal(Human target)
    {
        // variables without target in front of them, like Intelligence, will be the values given to the Wizard that is not being passed in as the target wizard.
        // taking away health from the target wizard.
        int addedHealth= Intelligence * 10; 
        target.Health += addedHealth;
        // Console.WriteLine("wizard target heal health " + target.Health);
        return target.Health;
    }
}