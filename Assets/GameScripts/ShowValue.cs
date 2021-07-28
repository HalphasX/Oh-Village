using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowValue : MonoBehaviour {
    Text hpText;

    void Start()
    {
        hpText = GetComponent<Text> ();
    }

    public void textUpdate (float value) 
    {
        hpText.text = "" + (int) value;
    }
}