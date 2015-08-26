using UnityEngine;
using System.Collections;

public class shot : MonoBehaviour {

    public Transform point;
    public GameObject bolt;

    public int ReactionDistance;

    public float timer = 1;
    private float _timerDown = 0;
    private GlobalDataBase GDB;

	void Start () 
    {
        GDB = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<GlobalDataBase>();
	}
	
	void Update () 
    {
        if (_timerDown > 0)
        {
            _timerDown -= Time.deltaTime;
        }
        if (GDB.enemyList.Count > 0 && _timerDown <= 0)
        {
            float _enemyDist = -1;
            GameObject _enemyNear = null;
            foreach (var enemy in GDB.enemyList)
            {
                float _tempDist = Vector3.Distance(enemy.transform.position, transform.position);
                if (_tempDist < ReactionDistance && (_tempDist < _enemyDist || _enemyDist == -1))
                {
                    _enemyDist = _tempDist;
                    _enemyNear = enemy;
                }
            }
            if (_enemyDist != -1)
            {
                _timerDown = timer;
                GameObject bul = (GameObject)Instantiate(bolt, point.transform.position, transform.rotation);
                bul.GetComponent<Bullet>().target = _enemyNear.transform;
            }
        }
	}
}
