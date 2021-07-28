using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class CardManager {
    public Card Villager = new HeroCard("Villager", 2, 1, 2, 1);
    public Card Knight = new HeroCard("Knight", 3, 3, 4, 1);
    public Card Guardian = new HeroCard("Guardian", 4, 0, 0, 7);
    public Card Cleric = new HeroCard("Cleric", 6, 0, 0, 2);
    public Card LightningSpell = new SpellCard("LightningSpell", 1);
    public Card FireballSpell = new SpellCard("FireballSpell", 2);
    public Card TornadoSpell = new SpellCard("TornadoSpell", 10);
    public Card HellfireSpell = new SpellCard("HellfireSpell", 15);
    public Card HealSpellS = new SpellCard("HealSpellS", 3);
    public Card HealSpellM = new SpellCard("HealSpellM", 5);
    public Card HealSpellL = new SpellCard("HealSpellL", 7);
    public Card DoubleSlashSpell = new SpellCard("DoubleSlashSpell", 8);
    public Card Sword = new WeaponCard("Sword", 3);
    public Card Shield = new WeaponCard("Shield", 1);
    public Card Staff = new WeaponCard("Staff", 2);
     
    public Card draw() {
        float r = Random.Range(0f, 100.0f);
        Debug.Log(r);
        if (r <= 15) {
            return Villager;
        } else if (r <= 25) {
            return Knight;
        } else if (r <= 35) {
            return Guardian;
        } else if (r <= 45) {
            return Cleric;
        } else if (r <= 50) {
            return Sword;
        } else if (r <= 54) {
            return Shield;
        } else if (r <= 58) {
            return Staff;
        } else if (r <= 68) {
            return HealSpellS;
        } else if (r <= 76) {
            return HealSpellM;
        } else if (r <= 81) {
            return HealSpellL;
        } else if (r <= 86) {
            return LightningSpell;
        } else if (r <= 90) {
            return FireballSpell;
        } else if (r <= 92) {
            return TornadoSpell;
        } else if (r <= 94) {
            return HellfireSpell;
        } else {
            return DoubleSlashSpell;
        } 
    }
}