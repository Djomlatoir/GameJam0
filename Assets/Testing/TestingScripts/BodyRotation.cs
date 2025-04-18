using UnityEngine;

public class bodyRotation : MonoBehaviour
{



    public float mouseSensitivity = 100f;

    public Transform playerBody;
    //  public Transform face;

    float xRotation = 0f;

    float yRotation = 0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;



        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;

        yRotation += mouseX;

        playerBody.localRotation = Quaternion.Euler(0f, yRotation, 0f);

        if (Mathf.Abs(xRotation) > 30f)
        {
            // Rotiraj telo oko Y ose u zavisnosti od mouseX
            yRotation += mouseX;
            playerBody.localRotation = Quaternion.Euler(0f, yRotation, 0f);
        }

    }
}
