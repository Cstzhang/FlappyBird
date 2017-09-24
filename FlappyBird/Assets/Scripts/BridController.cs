using UnityEngine;
using System.Collections;

public class BridController : MonoBehaviour {
	//帧数计数器
	public int frameCount = 0;
    // fram number one seconds 每秒显示帧数
    public int frameNumber = 15;
    //时间计数器 通过时间流逝判断当前是第几帧。
    public float timer;
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer >= 1.0f / frameNumber){
            frameCount++;//帧数加一
            timer -= 1.0f / frameNumber;
            //update material's offset x
            int frameIndex = frameCount % 3;//"图片有3帧"

			// how to set the property offset "_MainTex",new Vector2(0.33333f * frameIndex,0)
            this.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(0.33333f * frameIndex, 0));
        }
	
	}


}
