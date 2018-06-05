using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TempleFireCOntroller : MonoBehaviour {

	void OnEnable() {
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	void OnDisable() {
		SceneManager.sceneLoaded -= OnSceneLoaded;
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
		GameObject go = GameObject.FindGameObjectWithTag("FireScore");
		FireScore fs = go.GetComponent<FireScore>();

		if (fs._fireScore >= 5) {
			Transform[] trans = GameObject.Find("Temple").GetComponentsInChildren<Transform>(true);
			foreach (Transform t in trans) {
				if (t.gameObject.name == "Lights") {
					t.gameObject.SetActive(true);
				}
			}
		}
	}
}
