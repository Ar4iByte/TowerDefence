using UnityEngine;
using System.Collections;

public class Map2WearPoint : MonoBehaviour {
    public GameObject point0;
    public GameObject point1;
    public GameObject point2;
    public GameObject point3;

    public GameObject point10;
    public GameObject point11;
    public GameObject point12;
    public GameObject point13;

    public GameObject point20;
    public GameObject point21;
    public GameObject point22;
    public GameObject point23;

    private GlobalDataBase GDB;

    private int log;

    Transform[] allPoint = new Transform[4];

    private Vector3 targetPos;

    private int i = 0;

    public float speedMove = 5f;
   
	void Start () 
    {
       // GDB.enemyList.Add(gameObject);
        GDB = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GlobalDataBase>();
        log = GDB.WaweNum;
        switch(log)
        {
            case 1:
                allPoint[0] = point0.transform;
                allPoint[1] = point1.transform;
                allPoint[2] = point2.transform;
                allPoint[3] = point3.transform;
                break;
            case 2:
                allPoint[0] = point10.transform;
                allPoint[1] = point11.transform;
                allPoint[2] = point12.transform;
                allPoint[3] = point13.transform;
                break;
            case 3:
                allPoint[0] = point20.transform;
                allPoint[1] = point21.transform;
                allPoint[2] = point22.transform;
                allPoint[3] = point23.transform;
                break;
        }
	}

	void Update () 
    {
        
        targetPos = allPoint[i].transform.position;
        transform.Translate(Vector3.Normalize(targetPos - transform.position) * Time.deltaTime * speedMove);
        float distance = Vector3.Distance(targetPos, transform.position);
        if (distance < 0.5f)
        {
            if (i < allPoint.Length - 1)
            {
                i++;
            }
            else
            {
                GDB.enemyList.Remove(gameObject);
                Destroy(gameObject);
                GDB.protection--;
            }
        }
	}
}
