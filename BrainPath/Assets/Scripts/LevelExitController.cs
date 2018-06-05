using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExitController : MonoBehaviour {
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            print("Here");
            if (SceneManager.GetActiveScene().buildIndex < SceneManager.sceneCountInBuildSettings - 5) {
                GameObject go = GameObject.FindGameObjectWithTag("PosMan");
                go.GetComponent<PlayerPosManager>().nullPosition();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
            }
            else {
                SceneManager.LoadScene(0);
            }
        }
    }
}