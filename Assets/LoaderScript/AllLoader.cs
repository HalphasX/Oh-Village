using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllLoader : MonoBehaviour
{
    public void LocalPlay()
    {
        SceneManager.LoadScene("Local_Play");
    }
    
    public void Contin()
    {
        SceneManager.LoadScene("Continue");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Library");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("How_To_Play");
    }

    public void HowToPlay2()
    {
        SceneManager.LoadScene("HTP2");
    }

    public void HowToPlay3()
    {
        SceneManager.LoadScene("HTP3");
    }

    public void HowToPlay4()
    {
        SceneManager.LoadScene("HTP4");
    }

    public void HowToPlay5()
    {
        SceneManager.LoadScene("HTP5");
    }

    public void HowToPlay6()
    {
        SceneManager.LoadScene("HTP6");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void TwoPGameplay() {
        SceneManager.LoadScene("2_Player_Gameplay");
    } 

    public void TwoPEnterName() {
        SceneManager.LoadScene("2_Player_Enter_Name");
    }

    public void P1Card() 
    {
        SceneManager.LoadScene("P1_Card");
    }

    public void P2Card() 
    {
        SceneManager.LoadScene("P2_Card");
    }

    public void P1Heroes() 
    {
        SceneManager.LoadScene("P1_Heroes");
    }

    public void P2Heroes()
    {
        SceneManager.LoadScene("P2_Heroes");
    }

    public void CharLibrary()
    {
        SceneManager.LoadScene("CharacterLibrary");
    }
    
    public void WeaponLibrary()
    {
        SceneManager.LoadScene("WeaponLibrary");
    }
    
    public void SpellLibrary()
    {
        SceneManager.LoadScene("SpellLibrary");
    }
    
    public void Spell2Library()
    {
        SceneManager.LoadScene("Spell2Library");
    }
}
