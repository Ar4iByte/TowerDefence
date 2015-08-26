using UnityEngine;
using System.Collections;

public class Build : MonoBehaviour {


    private GameObject go;
    private GlobalDataBase GDB;

    void Start()
    {
        GDB = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GlobalDataBase>();
    }
    void Update()
    {
            if (go != null)
            {
                Ray ray;
                RaycastHit2D Hit;
                ray = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity))
                {
                    go.transform.position = Hit.point;
                    //CorX = Hit.point.x;
                    //  CorY = Hit.point.y;
                }
                if (Input.GetMouseButtonDown(0) && GDB.numIntersection == 0)
                {
                    go.tag = "Untagged";
                    go = null;
                    GDB.deActivationTrigger();
                }
            }
        
    }
    void OnGUI()
    {

    }
    public void setBuild(GameObject House)
    {
        go = (GameObject)Instantiate(House);
        go.tag = "Bild";
        GDB.activationTrigger();
    }


}
