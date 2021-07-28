using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueCond : MonoBehaviour
{
    public Button myButton;

    public void uninteractable() 
    {
        myButton.interactable = false;
    }
    
}
