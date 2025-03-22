using Cainos.PixelArtTopDown_Basic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    [SerializeField] private GameObject puzzleBox;
    [SerializeField] private GameObject afterPuzzleUI;
    [SerializeField] private GameObject chestClosed;
    [SerializeField] private GameObject chestOpen;
    public TopDownCharacterController characterController;

    private void Start()
    {
        chestOpen.SetActive(false);
        chestClosed.SetActive(true);
        puzzleBox.SetActive(false);
        afterPuzzleUI.SetActive(false);
    }

    private void Update()
    {
        if (characterController.levelComplete) {
            chestClosed.SetActive(false);
            chestOpen.SetActive(true) ;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(characterController.levelComplete);
        if (characterController.levelComplete == false) {
            puzzleBox.SetActive(true);
        }
        
    }

}
