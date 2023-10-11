class Stat
{
    public string Name { get; set; }
    public double Value { get; set; }
}

class Health : Stat
{
    public Health(string name, double value)
    {
        Name = name;
        Value = value;
    }
}

class Damage : Stat
{
    public Damage(string name, double value)
    {
        Name = name;
        Value = value;
    }
}

class Strength : Stat
{
    public Strength(string name, double value)
    {
        Name = name;
        Value = value;
    }
}

class Agility : Stat
{
    public Agility(string name, double value)
    {
        Name = name;
        Value = value;
    }
}

class Hero
{
    public string Name { set; get; }
    public Health Health { set; get; }
    public Strength Strength { get; set; }
    public Agility Agility { get; set; }
    public Damage Damage { get; set; }

    public Hero(Health health, Strength strength, Damage damage, Agility agility, string name)
    {
        Name = name;
        Health = health;
        Strength = strength;
        Damage = damage;
        Agility = agility;

        Health.Value = health.Value + strength.Value * 1.6;
        Damage.Value = damage.Value + agility.Value * 1.2;
    }

    public void Attack(Hero hero)
    {
        Console.WriteLine($"{Name} with {Health.Value}HP attacked {hero.Name} with {hero.Health.Value}HP");
        Console.WriteLine($"{hero.Name} -{Damage.Value}hp\n");
        hero.Health.Value -= Damage.Value;

        if (hero.Health.Value <= 0)
        {
            Console.WriteLine($"{hero.Name} killed by {Name} in the battle");
        }
        else
        {
            Console.WriteLine($"{hero.Name} now have {hero.Health.Value}HP\n");
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    { 
        Hero axe = new Hero(new Health("hp", 100), new Strength("strength", 2),
                            new Damage("damage", 13), new Agility("agility", 4), "Axe");

        Hero lina = new Hero(new Health("hp", 56), new Strength("strength", 1),
                            new Damage("damage", 13), new Agility("agility", 8), "Lina");

        axe.Attack(lina);

        axe.Attack(lina);
    }
}