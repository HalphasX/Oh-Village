using UnityEngine;
using System;

public class Card {
    public string name; 
    public int deploymentCost; 

    public Card(string name, int deploymentCost){
        this.name = name;
        this.deploymentCost = deploymentCost;
    }

    public string getName() {
        return this.name;
    }
    public int getDeploymentCost() {
        return this.deploymentCost;
    }
}