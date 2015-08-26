using UnityEngine;
using System.Collections;

public class Map1WearPoint : MonoBehaviour {

    public GameObject point0;
    public GameObject point1;
    public GameObject point2;
   

    public GameObject point10;
    public GameObject point11;
    public GameObject point12;
  

    public GameObject point20;
    public GameObject point21;
    public GameObject point22;


    public GameObject point30;
    public GameObject point31;
    public GameObject point32;


    private GlobalDataBase GDB;

    private int log;

    Transform[] allPoint = new Transform[3];

    private Vector3 targetPos;

    private int i = 0;

    public float speedMove = 5f;

    void Start()
    {
        // GDB.enemyList.Add(gameObject);
        GDB = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GlobalDataBase>();
        log = GDB.WaweNum;
        switch (log)
        {
            case 1:
                allPoint[0] = point0.transform;
                allPoint[1] = point1.transform;
                allPoint[2] = point2.transform;
                Debug.Log("1");
                break;
            case 2:
                allPoint[0] = point10.transform;
                allPoint[1] = point11.transform;
                allPoint[2] = point12.transform;
                Debug.Log("2");
                break;
            case 3:
                allPoint[0] = point20.transform;
                allPoint[1] = point21.transform;
                allPoint[2] = point22.transform;
                Debug.Log("3");
                break;
            case 4:
                allPoint[0] = point30.transform;
                allPoint[1] = point31.transform;
                allPoint[2] = point32.transform;
                Debug.Log("4");
                break;
        }
    }

    void Update()
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
