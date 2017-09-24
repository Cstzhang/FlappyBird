using UnityEngine;
using System.Collections;

public class FollowBrid : MonoBehaviour {
    private GameObject brid;
    public Transform bridTransform;
	// Use this for initialization
	void Start () {
        brid = GameObject.FindGameObjectWithTag("Player");
        bridTransform = brid.transform;
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 bridPos = brid.transform.position;
        this.transform.position = new Vector3(bridPos.x + 3.6332f, bridPos.y - 3.5088f, -10);
	}
}
