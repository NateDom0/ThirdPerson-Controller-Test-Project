using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //new library, adding packages of scripts

public class RestartLevelWithButton : MonoBehaviour
{
    [SerializeField]
    KeyCode keyRestart;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyRestart))
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        //needs .name for it to be an acceptable function; can't just use SceneManager
                                                                                                             
    }
}
