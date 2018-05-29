using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SailorPuzzleController : MonoBehaviour {
    [SerializeField] private GameObject _title;
    [SerializeField] private GameObject _story1;
    [SerializeField] private GameObject _story2;
    [SerializeField] private GameObject _story3;
    [SerializeField] private GameObject _mapImage;
    [SerializeField] private GameObject _map;

    [SerializeField] private GameObject _btn1;
    [SerializeField] private GameObject _btn2;
    [SerializeField] private GameObject _btn3;

    public void PlayGame() {
        _title.SetActive(false);
        _story1.SetActive(true);
    }

    public void ShowMap() {
        _story1.SetActive(false);
        _story2.SetActive(false);
        _story3.SetActive(false);
        _map.SetActive(true);
        _mapImage.SetActive(true);
    }

    public void FirstStory() {
        _map.SetActive(false);
        _mapImage.SetActive(false);
        _story1.SetActive(true);
    }

    public void SecondStory() {
        _btn1.SetActive(false);
        _map.SetActive(false);
        _mapImage.SetActive(false);
        _story2.SetActive(true);
    }

    public void ThirdStory() {
        _btn2.SetActive(false);
        _map.SetActive(false);
        _mapImage.SetActive(false);
        _story3.SetActive(true);
    }

    public void GameWin() {
        _btn3.SetActive(false);
        GameObject go = GameObject.FindGameObjectWithTag("FireScore");
        go.GetComponent<FireScore>().addFire();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-3);
    }
}