using Cainos.PixelArtTopDown_Basic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleController : MonoBehaviour
{
    public Button submitButton;
    public Button closeButton;
    [SerializeField] private InputField input;
    [SerializeField] private GameObject puzzleUI;
    [SerializeField] private GameObject afterPuzzleUI;
    [SerializeField] private TMP_Text closingText;
    public bool levelComplete = false;
    public TopDownCharacterController characterController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        submitButton.onClick.AddListener(submitClicked);
        closeButton.onClick.AddListener(closeDialogue);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(levelComplete);
    }

    private void OnDestroy()
    {
        submitButton.onClick.RemoveListener(submitClicked);
        closeButton.onClick.RemoveListener(closeDialogue);
    }

    public void submitClicked()
    {
        Debug.Log("hide");
        puzzleUI.SetActive(false);
        afterPuzzleUI.SetActive(true);
        if (input.text == "111") {
            closingText.SetText("Well Done! You have unlocked the key to move into the next stage!");
            levelComplete = true;
        }
        else
        {
            closingText.SetText("Hmmm! That's not right!");
        }
        characterController.levelComplete = levelComplete;
       
    }

    public void closeDialogue()
    {
        Debug.Log("hide.pt2");
        afterPuzzleUI.SetActive(false);

    }
}
