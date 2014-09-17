using UnityEngine;
using System.Collections;

public class actorControl : MonoBehaviour {
	// Update is called once per frame
	public float turnSpeed = 5f;
	private Animator anim;

	void Start() {
		anim = this.GetComponent<Animator> ();
	}
	void Update () {
		//animActor animActor = GetComponent<animActor> ();
		Screen.showCursor = false;
		if (Input.GetAxis("Horizontal")<0) {
			anim.SetBool("run", true);
			anim.SetBool("stop", false);
			transform.Rotate(0, 0, -3);
		} else if (Input.GetAxis("Horizontal")>0) {
			anim.SetBool("run", true);
			anim.SetBool("stop", false);
			transform.Rotate(0, 0, 3);
		} else if(Input.GetAxis("Vertical")>0){
			anim.SetBool("run", true);
			anim.SetBool("stop", false);
			transform.position += transform.up * turnSpeed * Time.deltaTime;
		}else if(Input.GetAxis("Vertical")<0){
			anim.SetBool("run", true);
			anim.SetBool("stop", false);
			transform.position -= transform.up * turnSpeed * Time.deltaTime;
		} else {
			anim.SetBool("run", false);
			anim.SetBool("stop", true);
		}
		transform.Rotate( Vector3.forward*turnSpeed*Input.GetAxis("Mouse Y")*(-3), Space.World);
		transform.Rotate( Vector3.forward*turnSpeed*Input.GetAxis("Mouse X")*(-3), Space.World);
		//transform.Rotate( Vector3.forward*turnSpeed*Input.GetAxis("Horizontal")*(-3), Space.World);
		//transform.Rotate( Vector3.forward*turnSpeed*Input.GetAxis("V")*(-3), Space.World);
	}
}
