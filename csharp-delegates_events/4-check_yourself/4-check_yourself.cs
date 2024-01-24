﻿using System;

/// <summary>
/// class player
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>A player's class</summary>

    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        
        this.maxHp = maxHp;
        this.name = name;
        this.hp = maxHp;
        
    }

    delegate void CalculateHealth(float health);

/// <summary>damages player</summary>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
        {
            Console.WriteLine("{0} takes 0 damage!", this.name);
        }
        else
        {
            Console.WriteLine("{0} takes {1} damage!", this.name, damage);
            this.hp -= damage;
            ValidateHP(this.hp);
        }
    }
    ///<summary> Heals player</summary>
    public void HealDamage(float heal)
    {
        if (heal <= 0)
        {
            Console.WriteLine("{0} heals 0 HP!", this.name);
        }
        else
        {
            Console.WriteLine("{0} heals {1} HP!", this.name, heal);
            this.hp += heal;
            ValidateHP(this.hp);
        }
    }
/// <summary>makes sure to validate hp </summary>

    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            this.hp = 0;
        }
        else if (newHp > this.maxHp)
        {
            this.hp = this.maxHp;
        }
        else
        {
            this.hp = newHp;
        }
    }
    
    /// <summary>Modifies damage output</summary>

    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return (baseValue * 0.5f);
        if (modifier == Modifier.Base)
            return (baseValue);
        if (modifier == Modifier.Strong)
            return (baseValue * 1.5f);
        return baseValue;
    }
    /// <summary>prints health</summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }
}

class CurrentHPArgs : EventArgs
{
    float currentHp;
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }

}
public enum Modifier
{
    Weak,
    Base,
    Strong
};
public delegate float CalculateModifier(float baseValue, Modifier modifier);