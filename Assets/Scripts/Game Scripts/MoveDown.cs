using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
	public float speed;
	public float downLimit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
	{
		transform.position = new Vector2 (transform.position.x, transform.position.y - speed * Time.deltaTime);

		if(transform.position.y <= downLimit)
		{
			Destroy(gameObject);
		}
    }
}
