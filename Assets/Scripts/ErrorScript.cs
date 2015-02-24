using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ErrorScript : MonoBehaviour 
{
    public Text text;

	// Use this for initialization
	void Start () 
    {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ReturnToGame()
    {
        Debug.Log("Returning");
        Debug.Log(text.text);
    }
}
