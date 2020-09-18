using UnityEngine;
using UnityEngine.UI;

public class ConsoleToText : MonoBehaviour
{
    string myLog;
    Text textUi;

    private void Awake()
    {
        textUi = gameObject.GetComponent<Text>();
    }

    private void OnEnable()
    {
        Application.logMessageReceived += HandleLog;
    }

    private void OnDisable()
    {
        Application.logMessageReceived -= HandleLog;
    }

    private void HandleLog(string logString, string stackTrace, LogType type)
    {
        string newString = "\n [" + type + "] : " + logString;
        textUi.text = newString + textUi.text;
    }
}
