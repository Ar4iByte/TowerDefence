using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public Transform target;
    public int moveSpeed = 1;
    void Start()
    {
    }
    void Update()
    {
        if (target != null)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), 5 * Time.deltaTime);
            if (Vector3.Distance(target.position, transform.position) >= 1)
                transform.position += transform.forward * moveSpeed * Time.deltaTime;
            else
                Destroy(gameObject);
                
        }
        else
            Destroy(gameObject);
    }

}
