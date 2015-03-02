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
        //Physics2D.IgnoreLayerCollision(10, 11);
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
}
