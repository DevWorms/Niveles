using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class KeyboardController : MonoBehaviour {
    [SerializeField]
    Text inputField;
    string inputString;
    public void ButtomPressed()
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);
        string ButtonValue = EventSystem.current.currentSelectedGameObject.name;
        inputString += ButtonValue;
        inputField.text = inputString;
    }
    public void ActionPressed()
    {
        string action = EventSystem.current.currentSelectedGameObject.name;
        if (action == "Space")
        {
            inputString += " ";
        }
        else if (action == "Delete")
        {
            inputString = inputString.Substring(0, inputString.Length - 1);
        }
        inputField.text = inputString;
    }


}

