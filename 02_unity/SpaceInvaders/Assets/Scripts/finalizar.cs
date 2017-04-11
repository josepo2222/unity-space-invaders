using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalizar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E)==true)        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;


#else
         Application.Quit();
#endif        }
    }
}
