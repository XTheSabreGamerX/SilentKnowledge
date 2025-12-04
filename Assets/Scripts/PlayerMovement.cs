using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(AudioSource))]
public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float gravity = -9.81f;
    public float stepDistance = 1f;

    private CharacterController controller;
    private AudioSource footstepAudio;
    private Vector3 velocity;

    private Vector3 lastPos;
    private float traveled;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        footstepAudio = GetComponent<AudioSource>();
        lastPos = transform.position;
    }

    void Update()
    {
        // Movement input
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 move = transform.right * h + transform.forward * v;
        controller.Move(move * speed * Time.deltaTime);

        // Footstep handling
        traveled += Vector3.Distance(transform.position, lastPos);
        if (traveled >= stepDistance && move.magnitude > 0.1f) // only if moving
        {
            footstepAudio.PlayOneShot(footstepAudio.clip);
            traveled = 0f;
        }
        lastPos = transform.position;

        // Gravity handling
        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // keeps grounded
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
