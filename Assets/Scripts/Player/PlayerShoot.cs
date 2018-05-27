using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

	[SerializeField]Shooter assaultRifle;
	[SerializeField]float speed;


	void Update(){
		if (GameManager.Instance.InputController.Fire1) {
			assaultRifle.Fire();
		}
	}
}
