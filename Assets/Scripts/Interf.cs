using UnityEngine;
using System.Collections;

public class Interf : MonoBehaviour {

    public GameObject Archer;
    public GameObject Mag;

    public int costArch;
    public int costMag;

    private GlobalDataBase GDB;
	void Start ()
    {
        GDB = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GlobalDataBase>();
	}
	
	
	void Update () 
    {
	
	}
    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width + 10 - Screen.width, Screen.height - 90, 105, 40), "Башня лучника"))
        {
            if(GDB.money>costArch)
            {
                Camera.main.GetComponent<Build>().setBuild(Archer);
                GDB.money -= costArch;
            }
        }
        if (GUI.Button(new Rect(Screen.width + 10 - Screen.width, Screen.height - 40, 105, 40), "Башня мага"))
        {
            if (GDB.money > costMag)
            {
                Camera.main.GetComponent<Build>().setBuild(Mag);
                GDB.money -= costMag;
            }
        }
        if (GUI.Button(new Rect(Screen.width - 150, Screen.height + 20 - Screen.height, 110, 40), "Главное меню"))
        {
            Application.LoadLevel(0);
        }
       
        GUI.Label(new Rect(Screen.width +10 - Screen.width,Screen.height + 20 - Screen.height, 150, 30), "Деньги: " + GDB.money);
        GUI.Label(new Rect(Screen.width + 10 - Screen.width, Screen.height + 35 - Screen.height, 150, 30), "Прочность: " + GDB.protection);
    }

}
