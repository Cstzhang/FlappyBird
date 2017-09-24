using UnityEngine;
using System.Collections;

public class BridController : MonoBehaviour {
	//帧数计数器
	public int frameCount = 0;
    // fram number one seconds 每秒显示帧数
    public int frameNumber = 15;
    //时间计数器 通过时间流逝判断当前是第几帧。
    public float timer;
    //是否有动画
    public bool whetherAnimation = false;
    //是否可以跳跃
	public bool canJump = false;
     // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //向左速度
        //Vector3 vel = this.GetComponent<Rigidbody>().velocity;
        //this.GetComponent<Rigidbody>().velocity = new Vector3(5, vel.y, vel.z);
        // aniamtion
        if(GameManager._intance.GameStatus == GameManager.GAMESTATUS_PLAYING){
			timer += Time.deltaTime;
			if (timer >= 1.0f / frameNumber)
			{
				frameCount++;//帧数加一
				timer -= 1.0f / frameNumber;
				//update material's offset x
				int frameIndex = frameCount % 3;//"图片有3帧"

				// how to set the property offset "_MainTex",new Vector2(0.33333f * frameIndex,0)
				this.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(0.33333f * frameIndex, 0));
			}


        }


        if(GameManager._intance.GameStatus == GameManager.GAMESTATUS_PLAYING){

			//control jump
			if (Input.GetMouseButton(0))
			{//lett mause bt down
				Vector3 vel2 = this.GetComponent<Rigidbody>().velocity;
				// 加一个向上的速度
				this.GetComponent<Rigidbody>().velocity = new Vector3(vel2.x, 5, vel2.z);
			};

        }

	}


    public void getLife(){
        //重力
        this.GetComponent<Rigidbody>().useGravity = true;
		//速度
		  this.GetComponent<Rigidbody>().velocity = new Vector3(2, 0, 0);

	}





}
