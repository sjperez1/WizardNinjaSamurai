class Samurai : Human
{
    public Samurai(string name) : base(name){
        Health = 200;
    }

    public Samurai(string name, int strength, int intelligence, int dexterity, int health) 
    : base(name, strength, intelligence, dexterity, health ){
    }

    public override int Attack(Human target)
    {
        // calling the attack function from the parent, which is the Human class
        base.Attack(target);
        if(target.Health < 50){
            target.Health = 0;
        }
        // Console.WriteLine("Samurai target health " + target.Health);
        return target.Health;
    }

    public void Meditate()
    {
        Health = 200;
        // Console.WriteLine("Health of healed samurai " + Health);
    }
}