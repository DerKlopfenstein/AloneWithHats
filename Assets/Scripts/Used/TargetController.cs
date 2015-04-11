using UnityEngine;
using System.Collections;

public class TargetController : MonoBehaviour 
{

    public GameObject weapon;
	public AudioSource breakingsound;

	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
    {
        if (GameObject.Find("MaskRoomSix").GetComponent<BoxCollider2D>().enabled == false)
        {
            Activate();     //NOT ACTING AS INTENDED
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Weapon")
        {
			breakingsound.Play ();
            other.transform.parent.gameObject.SendMessage("CompleteObjective");
            gameObject.SetActive(false);


        }
    }

    void Activate()
    {
        GetComponent<BoxCollider2D>().enabled = true;       //Add physics components
        gameObject.AddComponent<Rigidbody2D>();
    }
}
