using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevelMenu : MonoBehaviour {

	[SerializeField] private GameObject _posMan;
	[SerializeField] private GameObject _scoreMan;
	[SerializeField] private LevelChanger _lv;
    
	public void Level01() {
		DontDestroyOnLoad(_posMan);
		DontDestroyOnLoad(_scoreMan);
		_lv.FadeToLevel(2);
	}
	public void Level02() {
		DontDestroyOnLoad(_posMan);
		DontDestroyOnLoad(_scoreMan);
		_lv.FadeToLevel(8);
	}

	public void Back() {
		_lv.FadeToLevel(0);
	}
}
