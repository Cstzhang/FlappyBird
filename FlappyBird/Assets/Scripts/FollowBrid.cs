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
        float y = bridPos.y - 3.5088f;
        if(y >2.4f){
            y = 2.4f;
        }

		if (y < - 2.4f)
		{
			y = -2.4f;
		}



        this.transform.position = new Vector3(bridPos.x + 3.6332f, y, -10);
	}
}
