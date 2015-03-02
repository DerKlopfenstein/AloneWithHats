using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour {

	public AudioSource enterSound;
	public AudioSource exitSound;

	public AudioSource underwatermusic;
	public AudioSource normalmusic;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) 
	{

		if (other.tag == "Player") {

			enterSound.Play();
			normalmusic.mute = true;
			underwatermusic.mute = false;

		}


	}

	void OnTriggerExit2D(Collider2D other) 
	{

		if (other.tag == "Player") {


			exitSound.Play();
			underwatermusic.mute = true;
			normalmusic.mute=false;

		}

	}

}
