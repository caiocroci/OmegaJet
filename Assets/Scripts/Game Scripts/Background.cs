using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

	public float speed;
	public Material material;

    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		Vector2 offset = new Vector2(0, Time.deltaTime * speed);
		material.mainTextureOffset -= offset * Time.deltaTime;
    }
}
