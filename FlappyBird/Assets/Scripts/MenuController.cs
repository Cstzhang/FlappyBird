using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour {
    public Text nowScore;
    public Text bestScore;
    public Button startBtn;
    public static MenuController _instance;
    private void Awake()
    {
        _instance = this;
        this.gameObject.SetActive(false);
		//添加点击侦听
		       startBtn.onClick.AddListener(onClick);
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void UpdateScore(float newcore)
    {
        float heightScore = PlayerPrefs.GetFloat("score", 0);

        if (newcore > heightScore)
        {
            heightScore = newcore;
        }
        PlayerPrefs.SetFloat("score", heightScore);
        this.nowScore.text = newcore.ToString();
        this.bestScore.text = heightScore.ToString();

        //重新开始
       


    }

    void onClick(){
        print("click start");
		if (GameManager._intance.GameStatus == GameManager.GAMESTATUS_END)
		{
            print("click start");
            //Application.LoadLevel(0);
            SceneManager.LoadScene("MainScene");
           

		}

    } 




}
