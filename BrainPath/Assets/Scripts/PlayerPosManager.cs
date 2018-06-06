using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPosManager : MonoBehaviour {
    private GameObject _player;

    private Vector3 _playerPosition = new Vector3(0,0,0);
    private Quaternion _playerRotation;


    public void savePosition() {
        _player = GameObject.FindGameObjectWithTag("Player");
        if (_player != null) {
            _playerPosition = _player.transform.position;
            _playerRotation = _player.transform.rotation;
            _player = null;
        }
    }

    public void loadPostion() {
        _player = GameObject.FindGameObjectWithTag("Player");
        if (_player != null) {
            if (_playerPosition.Equals(new Vector3(0,0,0))) {
                _playerPosition =transform.position;
                _playerRotation = transform.rotation;
            }
            _player.transform.position = _playerPosition;
            _player.transform.rotation = _playerRotation;
            _player = null;
        }
    }

    void OnEnable() {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable() {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
        loadPostion();
    }

    public void nullPosition() {
        _playerPosition = new Vector3(0, 0, 0);
    }
}