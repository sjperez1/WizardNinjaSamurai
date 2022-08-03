Human someHuman = new Human("someHuman");
Human anotherHuman = new Human("anotherHuman", 10, 10, 20, 200);
someHuman.Attack(anotherHuman);

Ninja ninja1 = new Ninja("ninja1");
Ninja ninja2 = new Ninja("ninja2", 10, 5, 20, 1000);
ninja1.Attack(ninja2);
ninja1.Steal(ninja2);

Wizard wizardAttack = new Wizard("wizardAttack");
Wizard wizardTarget = new Wizard("wizardTarget", 10, 10, 20, 500);
wizardAttack.Attack(wizardTarget);
wizardAttack.Heal(wizardTarget);

Samurai samuraiAttack = new Samurai("samuraiAttack");
Samurai samuraiTarget = new Samurai("samuraiTarget", 10, 10, 5, 55);
samuraiAttack.Attack(samuraiTarget);
samuraiTarget.Meditate();