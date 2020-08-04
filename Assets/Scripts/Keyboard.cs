using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Keyboard : MonoBehaviour
{
    [SerializeField] private InputField inputField;
    private TouchScreenKeyboard keyboard;
    
    public void WriteModelAdress()
    {
        keyboard = TouchScreenKeyboard.Open("Write adress", TouchScreenKeyboardType.Default, false, false, false, false);
    }

    public void SetModelAdress()
    {
        PlayerPrefs.SetString("assetBundleURL", inputField.text.Trim());
    }
}
