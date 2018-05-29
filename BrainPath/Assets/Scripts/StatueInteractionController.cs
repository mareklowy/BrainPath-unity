using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class StatueInteractionController : MonoBehaviour {

    [SerializeField] private LevelChanger _lv;
    private Transform _player;
    
    private bool _interact;

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.F))
            Interact();
    }

    private void Interact() {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Statue");
        _player = gameObject.transform;
        foreach (var obj in objs) {
            if (Vector3.Distance(_player.position, obj.transform.position) < 4) {
               _lv.LoadMiniGame(obj.name);
            }
        }
    }
}