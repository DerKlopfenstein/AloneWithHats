using UnityEngine;
using System.Collections;

public class SwordController : MonoBehaviour 
{
    bool swinging = false;
    bool reachedApex = false;
    float elapsTime = 0.0f;
    float curr, apex;
    Transform t;

	// Use this for initialization
	void Start () 
    {
        t = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        //Debug.Log("Time = " + elapsTime);
        //Debug.Log("Position = " + transform.localPosition.x);

        if (swinging && elapsTime < 1 && !reachedApex)
        {
            elapsTime += (Time.deltaTime * 4);
            
        }
        else if(swinging)
        {
            reachedApex = true;
            elapsTime -= (Time.deltaTime * 4);
        }

        if (reachedApex && elapsTime <= 0)
        {
            swinging = false;
            reachedApex = false;
            t.localPosition = new Vector3(curr, t.localPosition.y, t.localPosition.z);
        }

        if (swinging)
        {
            t.localPosition = new Vector3(Mathf.Lerp(curr, apex, elapsTime), t.localPosition.y, t.localPosition.z);
        }

        
       // Debug.Log(transform.localPosition);
        //if(Input.
        /*transform.localPosition = new Vector2(-0.2f, transform.localPosition.y);

        if (transform.parent.localScale.x < 1 && !swinging)
        {
            Debug.Log("Facing Right");
            Debug.Log("Old position: " + transform.position);
            
        }
        else if (transform.parent.localScale.x > 1 && !swinging)
        {
            Debug.Log("Facing Left");
            Debug.Log("Old position: " + transform.position);
            //transform.localPosition = new Vector2(0.05f, transform.position.y);
        }*/
	}

    void SwingSword()
    {
        if (!swinging)
        {
            //Debug.Log("Swing!");
            swinging = true;
            elapsTime = 0.0f;
            curr = t.localPosition.x;
            apex = t.localPosition.x + 0.15f;
        }
    }
}
