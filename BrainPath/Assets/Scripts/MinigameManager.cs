using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinigameManager : MonoBehaviour {

	private GameObject _angel;
	private GameObject _lion;
	private GameObject _lady;
	private GameObject _greek;
	private GameObject _dragon;
	
	void OnEnable() {
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	void OnDisable() {
		SceneManager.sceneLoaded -= OnSceneLoaded;
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
		GameObject go = GameObject.FindGameObjectWithTag("FireScore");
		FireScore fs = go.GetComponent<FireScore>();

		_angel = GameObject.Find("Angel");
		_lady = GameObject.Find("Screaming Lady");
		_lion = GameObject.Find("Lion");
		_greek = GameObject.Find("Greek Man");
		_dragon = GameObject.Find("Dragon");

		if (fs.angelFinished) {
			_angel.SetActive(false);
			fs.angelFinished = false;
		}
		if (fs.ladyFinished) {
			_lady.SetActive(false);
			fs.ladyFinished = false;
		}
		if (fs.dragonFinished) {
			_dragon.SetActive(false);
			fs.dragonFinished = false;
		}
		if (fs.lionFinished) {
			_lion.SetActive(false);
			fs.lionFinished = false;
		}
		if (fs.greekFinished) {
			_greek.SetActive(false);
			fs.greekFinished = false;
		}
	}
}
