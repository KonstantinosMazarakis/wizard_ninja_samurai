using System;

class Wizard :Human
{
    

    public Wizard(string name) : base(name ,3,25,3,50 ){}


public void WizardAttack(Human target)
{
    int damage = this.Intelligence * -5;
    target.changeHealth(damage);
    this.changeHealth(damage * -1);
    Console.WriteLine($"Target's got {damage*-1} of damage and his health is {target.Health} and {this.Name} got healed for {damage*-1} and his new health is : {this.Health}");
}

public void Heal(Human target)
{
    int heal = this.Intelligence * 10;
    target.changeHealth(heal); 
    Console.WriteLine($"Wake UP lazy ass!! {this.Name} heal {target.Name} and his health is now at {target.Health}");
}
}
