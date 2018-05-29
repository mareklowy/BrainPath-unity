using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPanel : MonoBehaviour {
	public GameManager gameLogic;

	public void StartButton () {
		gameLogic.StartGame();
		Deactivate();
	}

	public void Deactivate ()
	{
		gameObject.SetActive(false);
	}

	public void Activate ()
	{
		gameObject.SetActive(true);
	}
}
