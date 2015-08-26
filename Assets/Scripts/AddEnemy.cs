using UnityEngine;
using System.Collections;

public class AddEnemy : MonoBehaviour {

    private GlobalDataBase GDB;
    public int health;
    public int MoneyReward;
    public int RedDamage;
    public int BlueDamage;
	void Start () 
    {
        GDB = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GlobalDataBase>(); 
        GDB.enemyList.Add(gameObject);
	}
	void Update () 
    {
	   if(health<=0)
       {
           GDB.enemyList.Remove(gameObject);
           Destroy(gameObject);
           GDB.money += MoneyReward;
       }
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "RedBall")
        {
            health -= RedDamage;
        }
        else if(col.tag == "BlueBall")
        {
            health -= BlueDamage;
        }
    }
    

}
