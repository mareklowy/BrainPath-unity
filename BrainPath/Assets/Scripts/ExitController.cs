using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitController : MonoBehaviour {
   
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            print("Here");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
