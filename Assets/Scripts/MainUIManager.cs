using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI topMessage;

    // Start is called before the first frame update
    void Start()
    {
        UpdateMessage();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void UpdateMessage()
    {
        topMessage.text = $"Best Score : {GameManager.Instance.playerName} : {GameManager.Instance.score}";
    }
}
