using Cainos.PixelArtTopDown_Basic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    public TopDownCharacterController characterController;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    { // 3 levels in total
        string sceneN = SceneManager.GetActiveScene().name;
        Debug.Log(characterController.levelComplete);

        if (characterController.levelComplete)
        {
            if (sceneN == "Level1")
            {
                SceneManager.LoadScene("Level2"); // go through level 1 door to level 2
            }
            else if (sceneN == "Level2")
            {
                SceneManager.LoadScene("Level3"); // go through level 1 door to level 2
            }
            else if (sceneN == "Level2")
            {
                SceneManager.LoadScene("Level3"); // go through level 1 door to level 2
            }
        }        
    }
}
