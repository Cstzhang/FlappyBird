using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    //first bg
    public Transform firstBg;
    // score
    public int totalScore = 0;
    //单例对象
    public static GameManager _intance;
    //启动
    private void Awake()
    {
        _intance = this;
    }


}
