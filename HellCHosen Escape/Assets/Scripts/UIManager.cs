using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    private static UIManager _instance = null;
    public static UIManager I {
        get{
            if (_instance == null) {
                Debug.LogError("error");
            }
            return _instance;
        }
    }
    void Awake() {
        _instance = this;
    }

    // Use this for initialization

    /*void Start () {
        if (_instance != null) {
            Destroy(this.gameObject);
        }
        else {
            _instance = this;

            DontDestroyOnLoad(this.gameObject);

            if (transform.parent != null) {
                DontDestroyOnLoad(transform.parent.gameObject);
            }

        }
    }*/
	
	// Update is called once per frame
	void Update () {
	
	}
    
    public void Game_Start() {
        /*if(게임을 플레이한 기록이 있으면){
            //TODO : 세이브에서 레벨을 가져와서
            Application.LoadLevel("해당 레벨");
        }
        else{*/
        Application.LoadLevel("Prologue");
        GameFlowManager.I.ChangeState(GameFlowManager.STATE.st_Prologue);
        //}
    }

    public void Go_Extra() {
        Application.LoadLevel("Extra");
        GameFlowManager.I.ChangeState(GameFlowManager.STATE.st_Extra);
    }

    public void Go_Title() {
        Application.LoadLevel("Title");
        GameFlowManager.I.ChangeState(GameFlowManager.STATE.st_Title);
    }
    public void Go_General() {
        Application.LoadLevel("General_high_school");
        GameFlowManager.I.ChangeState(GameFlowManager.STATE.st_General_high_school);
    }
    public void Go_Special() {
        Application.LoadLevel("Special_high_school");
        GameFlowManager.I.ChangeState(GameFlowManager.STATE.st_Special_high_school);
    }
    public void Go_University() {
        Application.LoadLevel("University");
        GameFlowManager.I.ChangeState(GameFlowManager.STATE.st_University);
    }
    public void Go_Job() {
        Application.LoadLevel("Company");
        GameFlowManager.I.ChangeState(GameFlowManager.STATE.st_Company);
    }
    public void Go_Lab() {
        Application.LoadLevel("Graduate_school");
        GameFlowManager.I.ChangeState(GameFlowManager.STATE.st_Graduate_school);
    }
    public void Go_Mini_game() {
        Application.LoadLevel("Mini_game");
        GameFlowManager.I.ChangeState(GameFlowManager.STATE.st_Mini_game);
    }
}


