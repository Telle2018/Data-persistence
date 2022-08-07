using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] private TMP_InputField playerNameField;
    public string playerName;

    public string PlayerName
    {
        get => playerName;
    }


    public void StartNew()
    {
        playerName = playerNameField.GetComponent<TMP_InputField>().text;
        ScoreSaver.Instance.PlayerName = playerName;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        //MainManager.Instance.SaveHighScore();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
