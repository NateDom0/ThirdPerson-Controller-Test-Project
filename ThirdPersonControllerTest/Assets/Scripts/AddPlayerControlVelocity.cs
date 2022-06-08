using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AddPlayerControlVelocity : MonoBehaviour
{
    [SerializeField] // allows us to edit within the editor
    Vector3 v3Force;

    [SerializeField]  //make sure spelled correctly : SerializeField
        KeyCode keyPositive;

    [SerializeField]
    KeyCode keyNegative; 

    // Update is called once per frame
    void Update()
    {
        //    GetComponent<Rigidbody>().velocity += v3Force;
        if (Input.GetKey(keyPositive))
            GetComponent<Rigidbody>().velocity += v3Force;

         if (Input.GetKey(keyNegative))
            GetComponent<Rigidbody>().velocity -= v3Force;
    }
}
