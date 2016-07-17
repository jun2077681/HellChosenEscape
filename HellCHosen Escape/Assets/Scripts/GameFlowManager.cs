using UnityEngine;
using System.Collections;

public class GameFlowManager : MonoBehaviour {



    private static GameFlowManager _instance = null; //초기화 전까진 null 상태
    public static GameFlowManager I { get { return _instance; } }

    public enum STATE {

        none,
        st_App_Start,
        st_Title,
        st_Extra,
        st_Prologue,
        st_Young_age,
        st_General_high_school,
        st_Special_high_school,
        st_University,
        st_Graduate_school,
        st_Company,
        st_Mini_game
    }

    private STATE Current_State;
    private STATE Next_State = STATE.none;
    private bool FirstFrame = true; //첫 시작이면 첫 프레임이니까 true;

    // Use this for initialization
    void Start () {
        Current_State = STATE.st_App_Start; //시작 스테이트 지정

        //singleton Init
        if (_instance != null) { //만약 이미 static 변수가 존재한다면

            Destroy(this.gameObject); // 이 스크립트가 붙은 게임오브젝트를 Destroy

        }
        else { //만약 static 변수가 존재하지 않는다면, 즉, 내가 처음 만들어진거라면

            _instance = this; //_instance가 가리키는 값은 나

            DontDestroyOnLoad(this.gameObject); //그리고 나는 씬이 옮겨져도 지워지면 안됨.

            if (transform.parent != null) { //만약 상위 계층이 있다면
                DontDestroyOnLoad(transform.parent.gameObject); // parent도 지우지 마라
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        switch (Current_State) {

            case STATE.none: // Do nothing
                break;
            case STATE.st_App_Start:
                Funct_App_Start();
                break;
            case STATE.st_Title:
                Funct_Title();
                break;
            case STATE.st_Extra:
                Funct_Extra();
                break;
            case STATE.st_Prologue:
                Funct_Prologue();
                break;
            case STATE.st_Young_age:
                Funct_Young_age();
                break;
            case STATE.st_General_high_school:
                Funct_General_high_school();
                break;
            case STATE.st_Special_high_school:
                Funct_Special_high_school();
                break;
            case STATE.st_University:
                Funct_University();
                break;
            case STATE.st_Graduate_school:
                Funct_Graduate_school();
                break;
            case STATE.st_Company:
                Funct_Company();
                break;
            case STATE.st_Mini_game:
                Funct_Mini_game();
                break;
        }

        if (FirstFrame) {
            FirstFrame = false;
        }
    }
    
    void LateUpdate() { //Update가 끝나면 실행된다
        if (Next_State != STATE.none) {
            Current_State = Next_State; //다음 frame의 update 때 바뀐 State의 함수가 실행된다
            Next_State = STATE.none;
            FirstFrame = true;
        }
        else {
            FirstFrame = false;
        }
    }

    void Funct_App_Start() {
        if (FirstFrame) {
            //게임 시작시 필요한것들 초기화, 로딩 등
        }
        Debug.Log("State Title");
        ChangeState(STATE.st_Title);
    }
    void Funct_Title() {
        if (FirstFrame) {

        }
        //TODO : 게임 시작 엑스트라 게임 종료 등
        Debug.Log("State Title");
    }
    void Funct_Extra() {
        if (FirstFrame) {

        }
        Debug.Log("State Extra");
    }
    
    void Funct_Prologue() {
        if (FirstFrame) {

        }
        //할거 다 하고
        Debug.Log("State Prologue");
        Application.LoadLevel("Young_age");
        ChangeState(STATE.st_Young_age);
    }
    void Funct_Young_age() {
        if (FirstFrame) {

        }
        Debug.Log("State Young_age");
    }
    void Funct_General_high_school() {
        if (FirstFrame) {

        }
        Debug.Log("State General_high_school");
    }
    void Funct_Special_high_school() {
        if (FirstFrame) {

        }
        Debug.Log("State Special_high_school");
    }
    void Funct_University() {
        if (FirstFrame) {

        }
        Debug.Log("State University");
    }
    void Funct_Graduate_school() {
        if (FirstFrame) {

        }
        Debug.Log("State Graduate_school");
    }
    void Funct_Company() {
        if (FirstFrame) {

        }
        Debug.Log("State Company");
    }
    void Funct_Mini_game() {
        if (FirstFrame) {

        }
        Debug.Log("State Mini_game");
    }
    public void ChangeState(System.Object _next) {

        Next_State = (STATE)_next; //다음 스테이트를 지정한다. 이 스테이트는 다음 프레임에 바뀐다.

    }
}
