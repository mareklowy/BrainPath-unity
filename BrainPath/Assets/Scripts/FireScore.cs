using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScore : MonoBehaviour {

	private int _fireScore;

	public void addFire() {
		_fireScore++;
		print(_fireScore);
	}

	public bool HasEnoughFire() {
		return _fireScore >= 2;
	}
}
