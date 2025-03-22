using UnityEngine;
using UnityEngine.UI;

public class PuzzleController : MonoBehaviour
{
    public Button button;
    [SerializeField] private GameObject input;
    [SerializeField] private GameObject box;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button.onClick.AddListener(submitClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        button.onClick.RemoveListener(submitClicked);
    }

    public void submitClicked()
    {
        Debug.Log("hide");
        box.SetActive(false);
        if (input.GetComponent<InputField>().text == "111") {
            Debug.Log("correct");
        }
    }
}
