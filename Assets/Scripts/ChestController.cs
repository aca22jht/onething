using UnityEngine;

public class ChestController : MonoBehaviour
{
    [SerializeField] private GameObject box;

    private void Start()
    {
        box.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
        box.SetActive(true);
    }
}
