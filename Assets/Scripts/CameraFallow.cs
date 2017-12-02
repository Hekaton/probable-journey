using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFallow : MonoBehaviour {

    public GameObject pubTarget;
    public float height;
    public float compX;
    public float compZ;

    private Vector3 pos;

	// Use this for initialization
	void Start () {
        pos = new Vector3( pubTarget.transform.position.x + compX, height, pubTarget.transform.position.z+ compZ);
        transform.position = pos;   
	}
	
	// Update is called once per frame
	void Update () {
        pos.x = pubTarget.transform.position.x + compX;
        pos.z = pubTarget.transform.position.z + compZ;
        transform.position = pos;
    }
}
