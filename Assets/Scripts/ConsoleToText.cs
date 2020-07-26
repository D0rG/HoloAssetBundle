using UnityEngine;
using UnityEngine.UI;

public class ConsoleToText : MonoBehaviour
{
    string myLog;

    void OnEnable()
    {
        Application.logMessageReceived += HandleLog;
    }

    void OnDisable()
    {
        Application.logMessageReceived -= HandleLog;
    }

    void HandleLog(string logString, string stackTrace, LogType type)
    {
        myLog = logString;
        string newString = "\n [" + type + "] : " + myLog;
        gameObject.GetComponent<Text>().text = newString + gameObject.GetComponent<Text>().text;
    }
}
