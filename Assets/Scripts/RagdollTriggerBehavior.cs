using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class RagdollTriggerBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("ball"))
                {
            gameObject.GetComponentInParent<CharacterController>().enabled = false;
            gameObject.GetComponentInParent<Animator>().enabled = false;
            
            
                }
    }
}
