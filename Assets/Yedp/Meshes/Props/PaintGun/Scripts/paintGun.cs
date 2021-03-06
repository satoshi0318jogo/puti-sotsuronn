using UnityEngine;
using System.Collections;

public class paintGun : MonoBehaviour {

	public GameObject triggerObj;
	public GameObject sprayPart;

	void Start () 
	{
		sprayPart.active = false;
	}
	

	void Update () 
	{
		transform.Rotate(Vector3.up * Time.deltaTime*10f, Space.World);

		if (Input.GetMouseButtonDown (0)) 
		{
			triggerObj.transform.Rotate(0f, 0f, -8.5f);
			sprayPart.active = true;
		}

		if (Input.GetMouseButtonUp (0)) 
		{
			triggerObj.transform.Rotate(0f, 0f, 8.5f);
			sprayPart.active = false;
		}
	}
}
