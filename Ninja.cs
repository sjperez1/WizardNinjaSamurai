class Ninja : Human
{
    public Ninja(string name) : base(name){
        Dexterity = 175;
    }

    public Ninja(string name, int strength, int intelligence, int dexterity, int health) 
    : base(name, strength, intelligence, dexterity, health ){
    }

    public override int Attack(Human target)
    {
        Random rand = new Random();
        int min = rand.Next(1, 6);
        int damage= Dexterity * 5; 
        target.Health -= damage;
        if ( min == 2){
            target.Health -= 10;
        }
        Console.WriteLine("Ninja attack target health " + target.Health);
        return target.Health;
    }

    public void Steal(Human target)
    {
        target.Health -= -5;
        Health = Health + 5;
        // Console.WriteLine("Ninja steal target health " + target.Health);
        // Console.WriteLine("Ninja steal attacker health " + Health);
    }
}