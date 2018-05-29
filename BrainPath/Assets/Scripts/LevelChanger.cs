using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {
    
    [SerializeField] private Animator _animator;
    private int _fadeToIndex;

    public void FadeToLevel(int index) {
        _fadeToIndex = index;
        _animator.SetTrigger("FadeOut");
        GameObject go = GameObject.FindGameObjectWithTag("PosMan");
        go.GetComponent<PlayerPosManager>().savePosition();
    }

    public void OnFadeComplete() {
        SceneManager.LoadScene(_fadeToIndex);
    }

    public void LoadMiniGame(String statueType) {
        switch (statueType) {
            case "Angel": {
                FadeToLevel(2);
                break;
            }
            case "Lion": {
                FadeToLevel(3);
                break;
            }
            case "Greek Man": {
                FadeToLevel(4);
                break;
            }
            default:
                Debug.Log("Error");
                break;
        }
    }
}