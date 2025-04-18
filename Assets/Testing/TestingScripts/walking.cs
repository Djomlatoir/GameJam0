using UnityEngine;

public class Walking : MonoBehaviour
{
    private Vector3 Velocity;
    public float walkSpeed = 10;
    public float sprintSpeed = 10;
    public float jumpUp = 10;



    public CharacterController controller;
    public GameObject face;
    private float Gravity = -9.81f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = face.transform.right * x + face.transform.forward * z;

        if (controller.isGrounded)
        {
            Velocity.y = -1f;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Velocity.y = jumpUp;
            }
        }
        else
        {
            Velocity.y -= Gravity * -4f * Time.deltaTime;
        }

        controller.Move(move * walkSpeed * Time.deltaTime);

        controller.Move(Velocity * Time.deltaTime);



    }
}
