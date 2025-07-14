using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private Animator buttonAnimator;
    [SerializeField] private Animator spike1;
    [SerializeField] private Animator spike2;
    [SerializeField] private GameObject hintCanvas;
    private bool isNearButton = false;
    private bool isButtonClicked = false;
    void OnCollisionEnter(Collision other)
    {
        void Awake()
        {

        }

        if (other.gameObject.CompareTag("Player"))
        {
            isNearButton = true;
            if (!isButtonClicked)
            {
                hintCanvas.SetActive(true);
            }
        }
    }

    void OnCollisionExit(Collision other)
    {
        isNearButton = false;
        hintCanvas.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isNearButton && !isButtonClicked)
        {
            buttonAnimator.SetTrigger("PlayAnim");
            spike1.SetTrigger("SpikeOff");
            spike2.SetTrigger("SpikeOff");
            isButtonClicked = true;
            hintCanvas.SetActive(false);
        }
    }
}
