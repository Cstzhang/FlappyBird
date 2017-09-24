using UnityEngine;
using System.Collections;

public class PipeController : MonoBehaviour {
     void Start()
    { 
        RandomGeneratePosition();  
    }



    // 生成随机数用来控制管道位置
    public void RandomGeneratePosition(){
        //random a number
        float pos_y = Random.Range(-0.4f, -0.1f);
        this.transform.localPosition = new Vector3(this.transform.localPosition.x, pos_y, this.transform.localPosition.z);



    }

 




}
