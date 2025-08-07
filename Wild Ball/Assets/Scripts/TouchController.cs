using System.Collections;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    [SerializeField] private GameObject loseCanvas;
    public static bool isTouched = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isTouched = true;
            StartCoroutine(StoptimeWithDelay(2f));
        }
    }

    IEnumerator StoptimeWithDelay(float delay)
    {
        yield return new WaitForSecondsRealtime(delay);
        Time.timeScale = 0f;
        
        if (loseCanvas != null)
        {
            loseCanvas.SetActive(true);
        }
    }
}
