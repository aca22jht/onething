using UnityEngine;
using UnityEngine.UI;

public class PuzzleController : MonoBehaviour
{
    public Button button;
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
    }
}
