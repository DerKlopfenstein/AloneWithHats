using UnityEngine;
using System.Collections;

public class switchhat : MonoBehaviour {
	
	public Sprite tophat;
	public Sprite strawhat;
	public Sprite minimi;
	public Sprite fungi;
	public Sprite fedora;
	public Sprite crown;
	public Sprite propeller;
    public GameObject player;
	public AudioSource hatfallsoff;
	public AudioSource gethatback;
	
	private SpriteRenderer sprite;

	
	
	// Use this for initialization
	void Start () {
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		sprite = GetComponent<SpriteRenderer>();


		if (Input.GetKeyDown(KeyCode.T)) 
        {
			sprite.sprite = tophat;
		} 

        else if (Input.GetKeyDown(KeyCode.C)) 
        {
			sprite.sprite = strawhat;
		} 

        else if (Input.GetKeyDown (KeyCode.F)) 
        {
			sprite.sprite = fedora;
		} 

        else if (Input.GetKeyDown (KeyCode.Y)) 
        {
			sprite.sprite = minimi;
		} 

        else if (Input.GetKeyDown (KeyCode.M)) 
        {
			sprite.sprite = fungi;
		} 

        else if (Input.GetKeyDown (KeyCode.K)) 
        {
			sprite.sprite = crown;
		} 

        else if (Input.GetKeyDown(KeyCode.B)) 
        {
			sprite.sprite = propeller;
		}
	}

    void Escape()
    {
        if (transform.parent != null)
        {
            Vector2 initialPos = transform.parent.position;
            transform.parent = null;
            GetComponent<BoxCollider2D>().enabled = true;
            gameObject.AddComponent<Rigidbody2D>();
            transform.position = initialPos + new Vector2(1.0f, 0.0f);
            rigidbody2D.AddForce(Vector2.right * 130, ForceMode2D.Force);
			hatfallsoff.Play ();
        }
        
    }

    void Return()
    {
        transform.parent = player.transform;
        GetComponent<BoxCollider2D>().enabled = false;
        Object.Destroy(GetComponent<Rigidbody2D>());
        transform.localPosition = new Vector2(0.0f, 0.16f);
        transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
		gethatback.Play();
    }
}
