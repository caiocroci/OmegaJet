using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public float minX;
	public float maxX;

	private float timer;
	public float maxTime;

	public GameObject obstaculoPrefab;
    // Start is called before the first frame update
    void Start()
    {
		SpawnObstaculo();
    }

    // Update is called once per frame
    void Update()
    {
		timer += Time.deltaTime;
		if(timer >= maxTime)
		{
			SpawnObstaculo();
			timer = 0;
		}
    }

	void SpawnObstaculo()
	{
		float randomXPos = Random.Range(minX, maxX);
		GameObject novoObstaculo = Instantiate(obstaculoPrefab);
		novoObstaculo.transform.position = new Vector2(randomXPos, transform.position.y);

	}
}
