using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseInGame : MonoBehaviour
{
    public UnityEngine.UI.Button pauseButton;
    public GameObject panel;
    public UnityEngine.UI.Text text;
    [SerializeField]
    private bool isPause = false;


    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        if (pauseButton != null)
            pauseButton.onClick.AddListener(PauseResume);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void PauseResume()
    {
        if (isPause)
        {
            isPause = false;
            Debug.Log("Resume");
            Time.timeScale = 1f;
            panel.SetActive(false);
        }
        else
        {
            isPause = true;
            Debug.Log("Pause");
            Time.timeScale = 0f;
            panel.SetActive(true);
        }
    }
}
