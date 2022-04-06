using System;

class Samurai :Human
{
    

    public Samurai(string name) : base(name ,3,3,3,200){}

public void SamuraiAttack(Human target)
{
    this.Attack(target);
    if(target.Health < 50)
    {
        target.changeHealth(target.Health - target.Health - target.Health);
        Console.WriteLine($"Special Samurai attack Activated targets heath: {target.Health}. Instant DEATH");
    }
}


public void Meditate()
{
    int num = 200 - this.Health;
    this.changeHealth(num);
}


}

