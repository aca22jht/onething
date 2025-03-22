using Cainos.PixelArtTopDown_Basic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public TopDownCharacterController characterController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(characterController.levelComplete);


    }
}
