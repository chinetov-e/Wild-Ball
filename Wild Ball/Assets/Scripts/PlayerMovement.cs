using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float speed = 5f;
        public float jumpForce = 5f;
        private Rigidbody playerRB;


        private void Awake()
        {
            playerRB = GetComponent<Rigidbody>();
        }

        public void MoveCharacter(Vector3 movement)
        {
            playerRB.MovePosition(playerRB.position + movement * speed * Time.fixedDeltaTime);
        }

        public void Jump()
        {
            playerRB.linearVelocity = new Vector3(playerRB.linearVelocity.x, 0f, playerRB.linearVelocity.z);
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        [ContextMenu("Reset values")]
        public void ResetValues()
        {
            speed = 2;
        }

        public void StopHorizontalMovement()
        {
            playerRB.linearVelocity = new Vector3(0f, playerRB.linearVelocity.y, 0f);
        }
    }
    
}

