using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winController : MonoBehaviour {

	public static void Win() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
	}
	
}
