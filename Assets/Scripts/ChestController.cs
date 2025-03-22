using UnityEngine;

public class ChestController : MonoBehaviour
{
    [SerializeField] private GameObject puzzleBox;
    [SerializeField] private GameObject afterPuzzleUI;

    private void Start()
    {
        puzzleBox.SetActive(false);
        afterPuzzleUI.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
        puzzleBox.SetActive(true);
    }

}
