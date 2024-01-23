using System;

public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    public Player(string name, float maxHp)
    {
        this.name = "Player";
        this.maxHp = (100f);

        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.")
        }
        
        if (hp != maxHp)
        {
            this.hp = maxHp;
        }
        
    }
    public void PrintHealth()
    {
        console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp)
    }
}