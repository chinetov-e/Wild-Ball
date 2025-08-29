using UnityEngine;

public class WinController : MonoBehaviour
{
    [SerializeField] private GameObject winCanvas;
    [SerializeField] private ParticleSystem firework;
    public static bool isFinished;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && PlayerInput.coinsCollected == CoinCollector.coins.Length && !winCanvas.CompareTag("LastCanvas"))
        {
            Time.timeScale = 0;
            winCanvas.SetActive(true);
        }
        else if (other.CompareTag("Player") && PlayerInput.coinsCollected == CoinCollector.coins.Length && winCanvas.CompareTag("LastCanvas"))
        {
            Destroy(GameObject.FindWithTag("Player"));
            firework.Play();
            winCanvas.SetActive(true);
            isFinished = true;
        }
    }
}
