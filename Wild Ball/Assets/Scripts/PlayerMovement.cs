using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float speed = 10f;
        public float jumpForce = 5f;
        private Rigidbody playerRB;


        private void Awake()
        {
            playerRB = GetComponent<Rigidbody>();
        }

        public void MoveCharacter(Vector3 movement)
        {
            playerRB.AddForce(movement * speed, ForceMode.Force);
        }

        public void Jump()
        {
            Vector3 vel = playerRB.linearVelocity;
            vel.y = 0f;
            playerRB.linearVelocity = vel;

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

