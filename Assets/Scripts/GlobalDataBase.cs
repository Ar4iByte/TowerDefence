using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GlobalDataBase : MonoBehaviour {
    public GameObject MainTower;
    public int money;
    public int protection;
    public int WaweNum=3;
    public List<GameObject> obj = new List<GameObject>();
    public List<GameObject> enemyList=new List<GameObject>();
    public int numIntersection;


	void Start () 
    {

	}
	
	
	void Update () 
    {
	
	}
    public void activationTrigger()
    {
        for (int i = 0; i < obj.Count; i++)
        {
            obj[i].GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }
    public void deActivationTrigger()
    {
        for (int i = 0; i < obj.Count; i++)
        {
            obj[i].GetComponent<BoxCollider2D>().isTrigger = false;
        }
    }

}
