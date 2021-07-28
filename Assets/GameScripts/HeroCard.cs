using UnityEngine;
using System;

public class HeroCard : Card {
    private int attackCost;
    private int attackPower;
    private int HP;

    public HeroCard(string name, int deploymentCost, int attackCost, int attackPower, int HP) : base(name, deploymentCost){
        this.attackCost = attackCost;
        this.attackPower = attackPower;
        this.HP = HP; 
    }

    public int getAttackCost() {
        return this.attackCost;
    }

    public int getAttackPower() {
        return this.attackPower;
    }

    public int getHP() {
        return this.HP;
    }
}