using UnityEngine;
using System.Collections;

public class shooting : MonoBehaviour {

	public Transform bullet;
	public float speedBullet = 30f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) {
			Transform g = (Transform) Instantiate(bullet, transform.position, transform.rotation);
			g.rigidbody2D.AddForce(transform.up*speedBullet);
		}
		if(Input.GetMouseButtonUp(0)) {
		}
	}
}
