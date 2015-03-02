using UnityEngine;
using System.Collections;

public class BoulderController : MonoBehaviour 
{
    float startSpeed = 2.0f;
    float increaseSpeed = 3.5f;
    float currSpeed;
    bool flat = true;
    bool stopped = false;
    bool landed = false;
    Animator anim;

	public AudioSource rollsound;
	public AudioSource stopsound;

    public GameObject hallTrigger;
    public GameObject stopTrigger;

	// Use this for initialization
	void Start () 
    {
        currSpeed = 1.0f;
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (!landed)
        {

        }

        else if(!stopped && landed)
        {
            if ((flat && currSpeed < startSpeed) || (!flat && currSpeed < increaseSpeed))
            {
                currSpeed += 0.1f;
            }

            rigidbody2D.velocity = new Vector2(currSpeed, rigidbody2D.velocity.y);
        }

        else if (stopped)
        {
            rigidbody2D.velocity = new Vector2(0.0f, 0.0f);
            anim.SetBool("Stopped", true);
        }
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        landed = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other == hallTrigger.GetComponent<BoxCollider2D>())
        {
            flat = false;
        }

        if (other == stopTrigger.GetComponent<BoxCollider2D>())
        {
            stopped = true;
			rollsound.mute = true;
			stopsound.Play();
        }
    }

    public bool IsStopped()
    {
        return stopped;
    }
}
