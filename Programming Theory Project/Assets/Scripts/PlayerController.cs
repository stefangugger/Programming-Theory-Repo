using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;

    public GameObject mainCamera;

    [SerializeField]
    private float speed = 5;

    // ENCAPSULATION
    public float Speed
    {
        get
        {
            return speed;
        }
        set
        {
            if (value > 0 && value < 1000)
            {
                speed = value;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        playerRb.AddForce(mainCamera.transform.forward * verticalInput* Time.deltaTime * speed);
        playerRb.AddForce(mainCamera.transform.right * horizontalInput * Time.deltaTime * speed);
    }
}
