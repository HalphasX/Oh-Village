using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameInputGet : MonoBehaviour
{
    public InputField inputField1;
    string username1;
    public InputField inputField2;
    string username2;

    public void Start() 
    {
        username1 = PlayerPrefs.GetString("Username1");
        inputField1.text = username1;
        username1 = PlayerPrefs.GetString("Username2");
        inputField1.text = username2;
    }

    public void fieldSaver()
    {
        username1 = inputField1.text;
        username2 = inputField2.text;
        PlayerPrefs.SetString("Username1", username1);
        PlayerPrefs.SetString("Username2", username2);
    }
}
