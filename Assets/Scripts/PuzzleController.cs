using Cainos.PixelArtTopDown_Basic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PuzzleController : MonoBehaviour
{
    public Button submitButton;
    public Button closeButton;
    [SerializeField] private InputField input;
    [SerializeField] private GameObject puzzleUI;
    [SerializeField] private GameObject afterPuzzleUI;
    [SerializeField] private TMP_Text closingText;
    [SerializeField] private TMP_Text puzzleText;
    public bool levelComplete = false;
    int currentLevel;
    string currentPuzzle;
    string currentAnswer;
    public TopDownCharacterController characterController;
    string[,] puzzleQuestionsAndAnswers = { { "   1      1   \r\n  11     11   \r\n   1      1   \r\n   1      1   \r\n 11111  11111 ", "11"},
                                            { ".11111..11111.\r\n.1......1...1.\r\n.11111..11111.\r\n.....1..1...1.\r\n.11111..11111.", "58"}};

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        submitButton.onClick.AddListener(submitClicked);
        closeButton.onClick.AddListener(closeDialogue);
        string sceneN = SceneManager.GetActiveScene().name;
        Debug.Log(characterController.levelComplete);
        if (sceneN == "Level1")
        {
            currentLevel = 1; // go through level 1 door to level 2
        }
        else if (sceneN == "Level2")
        {
            currentLevel = 2; // go through level 1 door to level 2
        }
        //else if (sceneN == "Level3")
        //{
        //    currentLevel = 3; // go through level 1 door to level 2
        //}
        currentPuzzle = puzzleQuestionsAndAnswers[currentLevel-1, 0];
        currentAnswer = puzzleQuestionsAndAnswers[currentLevel - 1, 1];
        puzzleText.SetText(currentPuzzle);
    }

    // Update is called once per frame
    void Update()
    {

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
        if (input.text == currentAnswer) {
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
