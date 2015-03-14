using UnityEngine;
using System.Collections;

public class CrateController : MonoBehaviour 
{
    float groundRadius = 0.2f;              //radius of collision circle with crateRepeller
    bool crateStuck;                        //true when crate hits crateRepeller
    LayerMask box;                          //layer mask for collision detection (only things in this layer collide with repeller)

    public Transform crateRepeller;         
    public GameObject boxTrigger, mask3;    //trigger to open the next room, mask of the next room
	public AudioSource roomopensound;
	bool roomplayed = false;


	// Use this for initialization
	void Start () 
    {
        box = gameObject.layer;
	}
	
	// Update is called once per frame
	void Update () 
    {
        crateStuck = Physics2D.OverlapCircle(crateRepeller.position, groundRadius, box);        //false if nothing in the layer is within groundRadius of crateRepeller)

        if (crateStuck)
        {
            rigidbody2D.AddForce(new Vector2(3.0f, 0.0f), ForceMode2D.Impulse);
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other == boxTrigger.GetComponent<BoxCollider2D>())
        {
            mask3.GetComponent<Appear>().enabled = true;        //if the box hits the trigger, open the room
			if (!roomplayed)
			{
				roomopensound.pitch = Random.Range(.3f, 3f);
				roomopensound.Play();
				roomplayed = true;
			}
        }
    }
}
