using UnityEngine;
using System.Collections;

public class PipeCollision : MonoBehaviour {
    public AudioSource hitMusic;
	public AudioSource dieMusic;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//碰撞检测
	private void OnCollisionEnter(Collision collision)
	{
		print("OnCollisionEnter");
		if (collision.gameObject.tag == "Player")
		{

			GameManager._intance.GameStatus = GameManager.GAMESTATUS_END;

            //this.GetComponent<AudioSource>().Play();
            hitMusic.Play();
            dieMusic.Play();
		}
	}

}
