using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    private Transform playerTransform;
    private Vector3 offset;
    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            playerTransform = player.GetComponent<Transform>();
        }

        offset = transform.position - playerTransform.position;
    }

    void FixedUpdate()
    {
        transform.position = playerTransform.position + offset;
    }
}
