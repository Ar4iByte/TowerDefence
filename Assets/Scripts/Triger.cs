using UnityEngine;
using System.Collections;

public class Triger : MonoBehaviour {
    private GlobalDataBase GDB;
    public SpriteRenderer colR;
    private bool flagColor;
    void Start()
    {
        GDB = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GlobalDataBase>();
        GDB.obj.Add(gameObject);
    }

    void Update()
    {
        if (flagColor == true)
        {
            colR.color = Color.red;

        }
        if (flagColor == false)
        {
            colR.color = Color.white;
        }
        if(GDB.protection<=0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Bild")
        {
            GDB.numIntersection++;
            flagColor = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Bild")
        {
            GDB.numIntersection--;
            flagColor = false;
        }
    }

}
