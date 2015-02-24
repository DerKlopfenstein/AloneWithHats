using UnityEngine;
using System.Collections;

public class CreditsScreen : MonoBehaviour {

    //I am adding a comment to test GIT integration
    //More testing is being made

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
	}
}
