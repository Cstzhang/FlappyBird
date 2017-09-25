using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    //define  status of game 
    public static int GAMESTATUS_MENU = 0;//菜单状态
    public static int GAMESTATUS_PLAYING = 1;//游戏状态
    public static int GAMESTATUS_END = 2;//游戏结束

    public int GameStatus = GAMESTATUS_MENU;
    //first bg
    public Transform firstBg;
    // score
    public int totalScore = 0;
    //单例对象
    public static GameManager _intance;
    //brid 
    private GameObject brid;
    //启动
    private void Awake()
    {
        _intance = this;
		brid = GameObject.FindGameObjectWithTag("Player");
    }


    private void Update()
    {
        if(GameStatus == GAMESTATUS_MENU){
            if(Input.GetMouseButtonDown(0)){
                GameStatus = GAMESTATUS_PLAYING;
                //添加重力
                brid.SendMessage("getLife");
                // 天津爱

            }


        }

        //显示
        if(GameStatus == GameManager.GAMESTATUS_END){
            MenuController._instance.gameObject.SetActive(true);

            MenuController._instance.UpdateScore(totalScore);

        }
 
    }


}
