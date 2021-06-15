using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeDropdownLanguage : MonoBehaviour
{
    public Text playText;
    public Text optionsText;
    public Text settingsText;
    public Text exitText;
    public Dropdown languagedd; 

    public void UpdateText()
    {
        if (languagedd.value == 1)
        {
            playText.text = "Play";
            optionsText.text = "Options";
            settingsText.text = "Settings";
            exitText.text = "Exit";
        }

        if (languagedd.value == 2)
        {
            playText.text = "Abspielen";
            optionsText.text = "Optionen";
            settingsText.text = "Einstellungen";
            exitText.text = "Ausgang";
        }

        if (languagedd.value == 3)
        {
            playText.text = "Jouer";
            optionsText.text = "Options";
            settingsText.text = "Réglages";
            exitText.text = "Sortie";
        }
    }
}