using UnityEngine;

public class BridgeScript : MonoBehaviour
{
    [SerializeField] private Animator animator;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetTrigger("BridgeOn");
        }
    }
}
