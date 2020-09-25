using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformTriggerBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ball"))
        {
            gameObject.GetComponentInParent<Rigidbody>().isKinematic = false;
        }
    }
}