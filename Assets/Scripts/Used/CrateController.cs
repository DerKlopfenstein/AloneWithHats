using UnityEngine;
using System.Collections;

public class CrateController : MonoBehaviour 
{
    float groundRadius = 0.2f;              //radius of collision circle with crateRepeller
    bool crateStuck;                        //true when crate hits crateRepeller

    public Transform crateRepeller;
    public LayerMask box;                   //layer mask for collision detection (
    public GameObject boxTrigger, mask3;
	public AudioSource roomopensound;
	bool roomplayed = false;


	// Use this for initialization
	void Start () 
    {
	    
	}
	
	// Update is called once per frame
	void Update () 
    {

        crateStuck = Physics2D.OverlapCircle(crateRepeller.position, groundRadius, box);        //false if 

        Debug.Log(Physics2D.OverlapCircle(crateRepeller.position, groundRadius, box));

        if (crateStuck)
        {
            rigidbody2D.AddForce(new Vector2(3.0f, 0.0f), ForceMode2D.Impulse);
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other == boxTrigger.GetComponent<BoxCollider2D>())
        {
            mask3.GetComponent<Appear>().enabled = true;
			if (!roomplayed)
			{
				roomopensound.pitch = Random.Range(.3f, 3f);
				roomopensound.Play();
				roomplayed = true;
			}
        }
    }
}
