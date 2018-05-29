using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    [SerializeField] private GameObject _posMan;
    [SerializeField] private GameObject _scoreMan;
    [SerializeField] private LevelChanger _lv;
    
    public void NewGame() {
        DontDestroyOnLoad(_posMan);
        DontDestroyOnLoad(_scoreMan);
       _lv.FadeToLevel(1);
    }

    public void ExitGame() {
        Application.Quit();
    }
}