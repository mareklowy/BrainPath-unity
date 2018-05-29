using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PexesoWinCotroller : MonoBehaviour {

	public static void Win() {
		GameObject go = GameObject.FindGameObjectWithTag("FireScore");
		go.GetComponent<FireScore>().addFire();
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
	}
}
