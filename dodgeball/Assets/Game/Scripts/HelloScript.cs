using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloScript : MonoBehaviour
{
    public Text helloTitle;
    public string playerName = "Friend";

    void onUpdate ()
    {
        helloTitle.text = $"Hello, {playerName}!";
    }
    public void updateHelloTitle()
    {
        helloTitle.text = $"Hello, {playerName}!";
        Debug.Log("New hello text is: " + helloTitle.text);
    }

    //check if name is entered and saved
    public void readNameInput (string nameInput) {
        playerName = nameInput;
        Debug.Log("nameInput saved: " + playerName);
        helloTitle.text = $"Hello, {playerName}!";
    }
}
