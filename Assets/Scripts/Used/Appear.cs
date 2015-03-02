using UnityEngine;
using System.Collections;

public class Appear : MonoBehaviour 
{
	public float minimum = 0.0f;
	public float maximum = 1f;
	public float duration = 5.0f;
    public SpriteRenderer sprite;

	private float startTime;


	void Start() 
    {
		startTime = Time.time;
	}

	void Update() 
    {
		float t = (Time.time - startTime) / duration;
        sprite.color = new Color(1f, 1f, 1f, Mathf.SmoothStep(minimum, maximum, t));
        if (sprite.color.a <= 0.2f)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
	}
}
