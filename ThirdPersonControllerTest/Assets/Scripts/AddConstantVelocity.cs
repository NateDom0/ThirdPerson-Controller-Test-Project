using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AddConstantVelocity : MonoBehaviour
{
    [SerializeField] // allows us to edit within the editor
    Vector3 v3Force;

    // Start is called before the first frame update
  //  void Start()
  //  {}


    // Update is called once per frame
    void Update()                          //may use FixedUpdate
    {
        //GetComponent<Rigidbody>().velocity = new Vector3(1, 0, 0); 
        //GetComponent<Rigidbody>().velocity += new Vector3(0.01f, 0, 0); 
        //if you use decimal, i.e. 0.5f - float
        GetComponent<Rigidbody>().velocity += v3Force;
    }
}
