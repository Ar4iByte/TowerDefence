using UnityEngine;
using System.Collections;

public class Wears : MonoBehaviour {

    public bool go=false;

    public float timer;
    private float _timerDown;
    
    public int wear;

    private GlobalDataBase GDB;

    public GameObject lvl1;
    public GameObject lvl2;
    public GameObject lvl3;

    private int lvlCount=0;

	void Start ()
    {
        GDB = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GlobalDataBase>();
       // _timerDown = timer;
	}
	
	
	void Update () 
    {
        if (_timerDown < 0&&go==true)
        {
            lvlCount++;
            if(lvlCount<5)
            {
                Instantiate(lvl1);
               
            }
            else if(lvlCount>5&&lvlCount<10)
            {
                Instantiate(lvl2);
                
            }
            else if(lvlCount>10&&lvlCount<20)
            {
                Instantiate(lvl3);
                
            }
            else
            {
               // Debug.Log("Win");//Написать окно победы
            }_timerDown = timer;
        }
        else
        {
            _timerDown -= Time.deltaTime;
        }


    }
	
    void OnMouseDown()
    {
        GDB.WaweNum = wear;
        go = true;
    }
}
