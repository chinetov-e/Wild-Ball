using UnityEngine;
using WildBall.Inputs;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerInput : MonoBehaviour
{
    public LayerMask groundLayer;
    public Transform groundCheck;
    public float groundCheckRadius = 5f;
    private bool isGrounded;
    private bool jumpRequested;

    private Vector3 movement;
    private PlayerMovement playerMovement;

    void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }
    void Update()
    {
        float horizontal = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS);
        float vertical = Input.GetAxis(GlobalStringVars.VERTICAL_AXIS);

        movement = new Vector3(horizontal, 0, vertical).normalized;

        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayer);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            jumpRequested = true;
        }
    }

    void FixedUpdate()
    {
        if (movement.sqrMagnitude > 0.01f)
        {
            playerMovement.MoveCharacter(movement);
        }
        else
        {
            playerMovement.StopHorizontalMovement();
        }

        if (jumpRequested)
        {
            playerMovement.Jump();
            jumpRequested = false;
        }
    }
}
