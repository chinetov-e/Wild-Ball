using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public void OnClick()
    {
        GameObject clickedObject = EventSystem.current.currentSelectedGameObject;
        string buttonText = clickedObject.GetComponentInChildren<TextMeshProUGUI>().text;
        SceneManager.LoadScene($"Level{buttonText}");
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void NextLevel()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        int nextIndex = currentIndex + 1;

        if (nextIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextIndex);
            Time.timeScale = 1;
        }
        else
        {
            Debug.Log("Game Over");
        }
    }
}
