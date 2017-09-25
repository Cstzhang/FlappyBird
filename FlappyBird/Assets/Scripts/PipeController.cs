using UnityEngine;
using System.Collections;

public class PipeController : MonoBehaviour {




     void Start() { 
        RandomGeneratePosition();  
    }



    // 生成随机数用来控制管道位置
    public void RandomGeneratePosition(){
        //random a number
        float pos_y = Random.Range(-0.4f, -0.1f);
        this.transform.localPosition = new Vector3(this.transform.localPosition.x, pos_y, this.transform.localPosition.z);



    }

    //经过触发器后计分
    private void OnTriggerExit(Collider other) {
        if(other.tag == "Player"){
            GameManager._intance.totalScore++;
            this.GetComponent<AudioSource>().Play();
        }

        
    }

    //显示分数
    //private void OnGUI()
    //{
    //    GUILayout.Label("Score:" + GameManager._intance.totalScore);
    //}

   


}
