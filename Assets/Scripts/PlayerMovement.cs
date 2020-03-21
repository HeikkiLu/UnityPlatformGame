using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Speed;
    [SerializeField]
    KeyCode positiveKey;
    [SerializeField]
    KeyCode negativeKey;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(positiveKey))
            GetComponent<Rigidbody>().velocity += v3Speed;
        if (Input.GetKey(negativeKey))
            GetComponent<Rigidbody>().velocity -= v3Speed;
    }
}
