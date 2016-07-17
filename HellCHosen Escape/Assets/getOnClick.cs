using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class getOnClick : MonoBehaviour {

    public void getonClick(string Check) {
        var A = GameObject.Find("UI Manager").GetComponent<UIManager>();
        if (Check.Equals("E2T")) {
            A.Go_Title();
        }
        else if (Check.Equals("Special")) {
            A.Go_Special();
        }
        else if (Check.Equals("General")) {
            A.Go_General();
        }
        else if (Check.Equals("Graduate")) {
            A.Go_University();
        }
        else if (Check.Equals("Job")) {
            A.Go_Job();
        }
        else if (Check.Equals("Lab")) {
            A.Go_Lab();
        }
        else if (Check.Equals("Suicide")) {
            A.Go_Mini_game();
        }
    }
}
