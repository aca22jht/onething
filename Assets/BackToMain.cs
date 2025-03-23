using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMain : MonoBehaviour
{
    public Button backButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        backButton.onClick.AddListener(backClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        backButton.onClick.RemoveListener(backClicked);
    }

    public void backClicked()
    {
        Debug.Log("back");
        SceneManager.LoadScene("Main Menu");
    }
}
