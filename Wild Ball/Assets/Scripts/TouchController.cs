using UnityEngine;

public class TouchController : MonoBehaviour
{
    [SerializeField] private GameObject loseCanvas;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            if (loseCanvas != null)
            {
                loseCanvas.SetActive(true);
            }
        }
    }
}
