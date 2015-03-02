using UnityEngine;
using System.Collections;

public class IncrementalAppear : MonoBehaviour {

	Appear appearScript;

	void Start() 
    {
		appearScript = GetComponent<Appear>();
	}

	void Update() 
    {
		/*if (Input.anyKeyDown) 
        {
			appearScript.maximum += .3f;
		}*/
	}

    void AddTransparency(float num)
    {
        appearScript.maximum -= num;
    }
}
