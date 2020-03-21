using UnityEngine;
using System.Collections;


//[RequireComponent(typeof(Rigidbody))]

public class Jump : MonoBehaviour
{

    [SerializeField]
    float fJumpSpeed;

    [SerializeField]
    KeyCode jumpKey;

    [SerializeField]
    string strTag;

    private bool onGround = false;

    Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    float movementSpeed;
    // Update is called once per frame
    void Update()
    {
        float amountToMove = movementSpeed * Time.deltaTime;
        Vector3 movement = (Input.GetAxis("Horizontal") * -Vector3.left * amountToMove) + (Input.GetAxis("Vertical") * Vector3.forward * amountToMove);
        rb.AddForce(movement, ForceMode.Force);

        if (onGround)
        {
            if (Input.GetKeyDown(jumpKey))
            {
                rb.AddForce(Vector3.up * fJumpSpeed);

            }
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == strTag)
            onGround = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == strTag)
            onGround = false;
    }
}