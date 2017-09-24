using UnityEngine;
using System.Collections;

public class MoveTrigger : MonoBehaviour {
    public Transform currentBg;
    public PipeController pipe1;
	public PipeController pipe2;
    //当一个碰撞去进入碰撞去
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            //Move th bg to the first transform
            //1 get the first transtorm
            Transform firstBg =   GameManager._intance.firstBg;
            //2 move 
            currentBg.position = new Vector3(firstBg.position.x + 10, currentBg.position.y, currentBg.position.z);
            //3 update firstBg
            GameManager._intance.firstBg = currentBg;
            //4 new position for pipe
            pipe1.RandomGeneratePosition();
            pipe2.RandomGeneratePosition();
        }
    }
}
