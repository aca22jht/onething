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
    public bool activePuzzle;
    int currentLevel;
    string currentPuzzle;
    string currentAnswer;
    public TopDownCharacterController characterController;
    string[,] puzzleQuestionsAndAnswers = { { "  1      1   \r\n 11     11   \r\n  1      1   \r\n  1      1   \r\n  11111  11111", "11"},
                                            { ".11111..11111.\r\n.1......1...1.\r\n.11111..11111.\r\n.....1..1...1.\r\n.11111..11111.", "58"},
                                            { "01111100111110\r\n00000100100010\r\n01111100100010\r\n00000100100010\r\n01111100111110" , "30"},
                                            { "J11111JJ11111J\r\nJ1JJJ1JJJJJJ1J\r\nJ11111JJ11111J\r\nJJJJJ1JJ1JJJJJ\r\nJ11111JJ11111J", "92" },
                                            { "l1lll1ll11111l\r\nl1lll1llllll1l\r\nl11111lllll1ll\r\nlllll1llll1lll\r\nlllll1lll1llll", "47"} };

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
        else if (sceneN == "Level3")
        {
            currentLevel = 3; // go through level 1 door to level 2
        }
        else if (sceneN == "Level4")
        {
            currentLevel = 4; // go through level 1 door to level 2
        }
        else if (sceneN == "Level5")
        {
            currentLevel = 5; // go through level 1 door to level 2
        }
        currentPuzzle = puzzleQuestionsAndAnswers[currentLevel-1, 0];
        currentAnswer = puzzleQuestionsAndAnswers[currentLevel - 1, 1];
        puzzleText.SetText(currentPuzzle);
        activePuzzle = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDestroy()
    {
        submitButton.onClick.RemoveListener(submitClicked);
        closeButton.onClick.RemoveListener(closeDialogue);
        activePuzzle = false;
    }

    public void submitClicked()
    {
        Debug.Log("hide");
        puzzleUI.SetActive(false);
        afterPuzzleUI.SetActive(true);
        if (input.text == currentAnswer) {
            if (currentLevel == 5)
            {
                SceneManager.LoadScene("Main Menu");
            }
            else
            {
                closingText.SetText("Well Done! You have unlocked the key to move into the next stage!");
                levelComplete = true;
            }
            
        }

        else
        {
            closingText.SetText("Hmmm! That's not right!");
        }
        characterController.levelComplete = levelComplete;
        activePuzzle = false;
    }

    public void closeDialogue()
    {
        Debug.Log("hide.pt2");
        if (currentLevel != 5)
        {
            Debug.Log("hide.pt2");
            afterPuzzleUI.SetActive(false);
        }
        else
        {
            Debug.Log("move to end screen");
        }
            

    }
}
