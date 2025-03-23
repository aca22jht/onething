using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button playButton;
    public Button controlsButton;
    public Button howToButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playButton.onClick.AddListener(playClicked);
        controlsButton.onClick.AddListener(controlsClicked);
        howToButton.onClick.AddListener(howToClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDestroy()
    {
        playButton.onClick.RemoveListener(playClicked);
        controlsButton.onClick.RemoveListener(controlsClicked);
        howToButton.onClick.RemoveListener(howToClicked);
    }

    public void playClicked()
    {
        Debug.Log("play");
        SceneManager.LoadScene("Level1");
    }

    public void controlsClicked()
    {
        Debug.Log("controls");
        SceneManager.LoadScene("Controls");
    }

    public void howToClicked()
    {
        Debug.Log("how to");
        SceneManager.LoadScene("How To Play");
    }
}
