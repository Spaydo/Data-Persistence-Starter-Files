using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI topMessage;
    [SerializeField] TMP_InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        topMessage.text = $"Best Score : {GameManager.Instance.playerName} : {GameManager.Instance.score}";
    }

    public void StartGameClick()
    {
        GameManager.Instance.tempPlayerName = inputField.text;
        SceneManager.LoadScene(1);
    }

    public void QuitGameClick()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
