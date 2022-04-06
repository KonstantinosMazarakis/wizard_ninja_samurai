using System;

class Ninja :Human
{
    

    public Ninja(string name) : base(name ,3,3,175,100 ){}



public void NinjaAttack(Human target)
{
    int damage = 0;
    Random rand = new Random();
    int chance = rand.Next(1,10);
    if(chance < 3)
    {
    damage = (this.Dexterity * -5) - 10;
    }else{
    damage = (this.Dexterity) * -5;
    }
    target.changeHealth(damage);
    this.changeHealth(damage * -1);
    Console.WriteLine($"Target's got {damage*-1} of damage and his health is {target.Health} and {this.Name} got healed for {damage*-1} and his new health is : {this.Health}");
}

public void Steal(Human target)
{
    target.changeHealth(-5);
    this.changeHealth(5);
    Console.WriteLine($"{this.Name} stole 5 health from {target.Name} and his health is now {this.Health}. Target's health is now at {target.Health} ");
}


}
