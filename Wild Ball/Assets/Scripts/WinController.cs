using UnityEngine;

public class WinController : MonoBehaviour
{
    [SerializeField] private GameObject winCanvas;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && PlayerInput.coinsCollected == CoinCollector.coins.Length)
        {
            Time.timeScale = 0;
            winCanvas.SetActive(true);
        }
    }
}
