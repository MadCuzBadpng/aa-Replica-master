using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private bool gameHasEnded = false;

	public Rotator rotator;
	public Spawner spawner;

	public Animator animator;

	void Update ()
    {
		if (LifeScript.CurrentLife <=0)
        {
			SceneManager.LoadScene(2);
		}
    }

	public void EndGame ()
	{
		if (gameHasEnded)
			return;

		rotator.enabled = false;
		spawner.enabled = false;

		LifeScript.CurrentLife -= 1;

		animator.SetTrigger("EndGame");
		
		gameHasEnded = true;
	}

	public void RestartLevel ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

}
