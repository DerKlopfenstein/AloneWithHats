using UnityEngine;
using System.Collections;

public class IncrementalAppear : MonoBehaviour 
{
    //I HAVE ADDED A COMMENT!

	Appear appearScript;

	void Start() 
    {
		appearScript = GetComponent<Appear>();
	}

	void Update() 
    {

	}

    void AddTransparency(float num)
    {
        appearScript.maximum -= num;            //reduces maximum value (inverted Appear)
    }
}
