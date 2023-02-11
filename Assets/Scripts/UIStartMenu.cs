using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class UIStartMenu : MonoBehaviour
{
    [SerializeField] private Text highScoreText;
    [SerializeField] private InputField inputName;

    private void Start()
    {
        if (SessionManager.instance != null)
        {
            if (SessionManager.instance.currentHighScoreOwnerName != null)
            {
                highScoreText.text = "Best Score : " + SessionManager.instance.currentHighScoreOwnerName + ": " + SessionManager.instance.currentHighScore;
            }
        }
    }

    public void StartGame()
    {
        SessionManager.instance.currentName = inputName.text;
        SceneManager.LoadScene(1);
    }
}
