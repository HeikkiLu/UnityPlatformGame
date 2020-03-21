using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedPlate : MonoBehaviour
{
    [SerializeField]
    float fTimer;
    [SerializeField]
    string strTag;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == strTag)
        {
            Rigidbody gameObject = this.gameObject.AddComponent<Rigidbody>();
            this.gameObject.GetComponent<Rigidbody>().mass = 5;
            Destroy(this.gameObject, fTimer);
        }
    }
}
