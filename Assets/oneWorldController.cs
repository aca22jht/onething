using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class oneWorldController : MonoBehaviour
{
    public Button oneButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        oneButton.onClick.AddListener(oneClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        oneButton.onClick.RemoveListener(oneClicked);
    }

    public void oneClicked()
    {
        Debug.Log("one");
        SceneManager.LoadScene("One World Win");
    }
}
