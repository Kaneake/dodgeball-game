using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloScript : MonoBehaviour
{
    public Text helloTitle;
    public InputField textBox;
    public string playerName;

    // void onUpdate ()
    // {
    //     helloTitle.text = $"Hello, {playerName}!";
    // }
    void Start ()
    {
        string playerPrefString = PlayerPrefs.GetString("name");
        playerName = string.IsNullOrEmpty(playerPrefString) ? "Friend" : playerPrefString;
        helloTitle.text = $"Hello {playerName}!";
        //PlayerPrefs.GetString("name");
        
    }

    //Save the entered name
    public void saveNameInput () {
        PlayerPrefs.SetString("name", textBox.text);
        
        //Debug.Log("Your name is " + PlayerPrefs.GetString("name"));
        
        string playerPrefString = PlayerPrefs.GetString("name");
        playerName = string.IsNullOrEmpty(playerPrefString) ? "Friend" : playerPrefString;
        helloTitle.text = $"Hello {playerName}!";
    }
}
