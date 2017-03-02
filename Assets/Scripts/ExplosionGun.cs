using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionGun : MonoBehaviour {

	public GameObject explosion;
	public Camera cam;

	public TimeManager timeManager;
	
	void Update () {
		if (Input.GetButtonDown("Fire1")) Shoot();
	}

	void Shoot() {
		RaycastHit _hitInfo;

		if (Physics.Raycast(cam.transform.position, cam.transform.forward, out _hitInfo)) {
			GameObject _effect = (GameObject) Instantiate(explosion, _hitInfo.point, Quaternion.LookRotation(_hitInfo.normal));

			timeManager.SlowMotion();

			Destroy(_effect, 5f);
		}
	}
}
