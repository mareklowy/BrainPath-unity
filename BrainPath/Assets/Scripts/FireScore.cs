using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScore : MonoBehaviour {

	public int _fireScore;

	public bool angelFinished;
	public bool lionFinished;
	public bool dragonFinished;
	public bool ladyFinished;
	public bool greekFinished;
	
	public void addFire(string statueType) {
		_fireScore++;
		print(_fireScore);
		
		switch (statueType) {
			case "Angel": {
				angelFinished = true;
				break;
			}
			case "Lion": {
				lionFinished = true;
				break;
			}
			case "Greek Man": {
				greekFinished = true;
				break;
			}
			case "Screaming Lady": {
				ladyFinished = true;
				break;
			}
			case "Dragon": {
				dragonFinished = true;
				break;
			}
			default:
				Debug.Log("Error");
				break;
		}
	}

	public bool HasEnoughFire() {
		return _fireScore >= 2;
	}
}
