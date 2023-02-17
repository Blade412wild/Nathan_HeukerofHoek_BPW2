 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceUp : MonoBehaviour
{
    Rigidbody ThisObject;
    public float Power = 18.0f;


    // Start is called before the first frame update
    void Start()
    {
        this.ThisObject = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ThisObject.AddForce(transform.up * Power);
   
    }
}
