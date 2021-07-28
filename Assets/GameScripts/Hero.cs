using UnityEngine;
using System;

public class Hero : IComparable {
    public string name;
    public int attackCost;
    public int attackPower;
    public int HP;

    public Hero(string name, int attackCost, int attackPower, int HP){
        this.name = name;
        this.attackCost = attackCost;
        this.attackPower = attackPower;
        this.HP = HP; 
    }

    public int getHP() {
        return this.HP;
    }

    public int CompareTo (object obj) {
        if (obj == null) return 1;

        Hero other = obj as Hero;
        if (other != null)
            return this.HP.CompareTo(other.getHP());
        else
           throw new ArgumentException("Object is not a Hero!");
    }

    public Hero attacked(int hp) {
        if (this.HP <= hp) {
            return null;
        } else {
            return new Hero(this.name, this.attackCost, this.attackPower, this.HP - hp);
        }
    }
}