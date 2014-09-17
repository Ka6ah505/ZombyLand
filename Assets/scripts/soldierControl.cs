using UnityEngine;
using System.Collections;

public class soldierControl : MonoBehaviour {

	public float turnSpeed = 5f;
	private Animator anim;
	//public AudioClip myClip;
	
	void Start() {
		anim = this.GetComponent<Animator> ();
	}

	void Update () {
		Screen.showCursor = false;

		if(Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") == 0 ) {
			anim.SetBool("run", false);
			anim.SetBool("stop", true);
			//audio.Stop();
		} else {
			anim.SetBool("run", true);
			anim.SetBool("stop", false);
			//audio.PlayOneShot(myClip);
			float vectV = Input.GetAxis("Vertical") * turnSpeed * Time.deltaTime;
			float vectH = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
			transform.Translate(new Vector3(vectH, vectV, 0));
		}
		transform.Rotate(Vector3.forward*turnSpeed*Input.GetAxis("Mouse Y")*(-3));
		transform.Rotate(Vector3.forward*turnSpeed*Input.GetAxis("Mouse X")*(-3));
	}
}
