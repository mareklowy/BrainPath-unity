using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {
	public int score = 0;
	public int highScore = 0;
	[SerializeField]
	Text scoreLabel;

	void Awake () {
		scoreLabel = GetComponent<Text>();
	}

	public void Increment (int i = 1)
	{
		score += 1;
		scoreLabel.text = score.ToString();
		if (score == 10) {
			SimonWinCotroller.Win();
		}
	}

	public void Set (int scr=0)
	{
		score = scr;
		scoreLabel.text = score.ToString();
	}

	public void Reset()
	{
		score = 0;
		scoreLabel.text = "0";
	}

}
