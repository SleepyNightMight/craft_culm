using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPController : MonoBehaviour
{
    [SerializeField] Transform mainCamera;
    [SerializeField] LayerMask layerMask;
    float angle = 0;
    Rigidbody playerRigidbody;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate right left
        transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * 5);

        //Rotate up down
        angle = Mathf.Clamp(Input.GetAxis("Mouse Y") * -2.5f + angle, -60, 60);
        mainCamera.localRotation = Quaternion.Euler(new Vector3(angle, 0, 0));

        //Movement
        Vector3 velocity = transform.rotation * new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * 3;
        velocity.y = Input.GetKeyDown(KeyCode.Space) & Physics.SphereCast(transform.position,.23f,Vector3.down,out hit,.3f,layerMask) ? 5 : playerRigidbody.velocity.y;
        playerRigidbody.velocity = velocity;
    }
}
