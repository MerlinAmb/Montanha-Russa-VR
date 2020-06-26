using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventLook : MonoBehaviour
{
	public GameObject bait;
	public GameObject menu;
	public int number;

	public void ChangeScene()
	{
		if (bait)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + number);
		}

		if (menu)
		{
			SceneManager.LoadScene("MENU");
		}

	}
}
