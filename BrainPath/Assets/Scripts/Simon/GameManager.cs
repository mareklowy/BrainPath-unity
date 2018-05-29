using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	[SerializeField]
	private Button[] buttons;
	[SerializeField]
	float delay = 1.0f;
	[SerializeField]
	List<int> pattern = new List<int>();
	private int pickIdx;
	[SerializeField]
	StartPanel panel;
	[SerializeField]
	Score score;
	[SerializeField]
	AudioSource gameOverSound;
	[SerializeField]
	Text retryText;

	public void StartGame ()
	{
		SetId();
		ResetGame();
		StartCoroutine("Play");
	}

	void AddColor()
	{
		int rand = Random.Range(0, 3);
		Button current = buttons[rand];
		pattern.Add(rand);
		current.ActivateButton();
	}

	IEnumerator Play ()
	{
		pickIdx = 0;
		yield return new WaitForSeconds(delay);
		foreach (int patternIdx in pattern)
		{
			buttons[patternIdx].ActivateButton();
			yield return new WaitForSeconds(delay);
		}
			AddColor();
	}

	void SetId()
	{
		for (int i = 0; i < buttons.Length; i++)
		{
			buttons[i].buttonID = i;
		}
	}

	public void Choose(int chosen)
	{
		if(chosen == pattern[pickIdx])
		{
			pickIdx += 1;
			
			if(pickIdx == pattern.Count)
			{
				score.Increment();
				StartCoroutine("Play");
				delay = (delay * 0.8f);
			}
		}
		else
		{
			gameOverSound.Play();
			ResetGame();
		}
	}

	void ResetGame()
	{
		pattern.Clear();
        var scoreStr = score.GetComponent<Text>().text;
		retryText.text = string.Concat("Your score was ", scoreStr);
		panel.Activate();
		score.Reset();
		delay = 1.0f;
	}

}
