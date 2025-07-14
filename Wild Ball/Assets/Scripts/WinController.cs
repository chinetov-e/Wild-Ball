using UnityEngine;

public class WinController : MonoBehaviour
{
    [SerializeField] private GameObject winCanvas;
    void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0;

        if (other.CompareTag("Player"))
        {
            winCanvas.SetActive(true);
        }
    }
}
