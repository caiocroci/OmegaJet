using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerMove : MonoBehaviour
{
	public float speed;
	GameObject player;
	public GameObject deathUi;

	public Score scoreText;

	public Text score;
	public Text highScore;



    // Start is called before the first frame update
    void Start()
    {
		player = GameObject.FindGameObjectWithTag("Player");
		highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

	private void Update()
	{
		HighScore();
	}
	public void Left()
	{
		transform.position = new Vector2(transform.position.x - speed, transform.position.y * Time.deltaTime);
	}

	public void Right()
	{
		transform.position = new Vector2(transform.position.x + speed, transform.position.y * Time.deltaTime);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Obstaculos"))
		{
			scoreText.ScoreUp();
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Death"))
		{
			Time.timeScale = 0f;
			deathUi.SetActive(true);
		}
	}

	public void HighScore()
	{
		if(scoreText.score > PlayerPrefs.GetInt("HighScore", 0))
		{
			PlayerPrefs.SetInt("HighScore", scoreText.score);
			highScore.text = scoreText.score.ToString();
		}
	}

	public void Replay()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1;
	}
}
