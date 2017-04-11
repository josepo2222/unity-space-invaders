using System.Collections;using System.Collections.Generic;using UnityEngine;using UnityEngine.SceneManagement;public class ControlDrop : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {        if (transform.position.y < -6)        {            Destroy(gameObject);        }        
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Nave")
        {
            Destroy(gameObject);

        }
    }
}