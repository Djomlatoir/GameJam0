using UnityEngine;

public class headMovement : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    public Transform playerBody;

    float xRotation = 0f;

    float yRotation = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;



        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        yRotation += mouseX;

        xRotation = Mathf.Clamp(xRotation, -30f, 30f);
        yRotation = Mathf.Clamp(yRotation, -60f, 60f);


        playerBody.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);

        playerBody.Rotate(Vector3.up * mouseX);






    }
}
