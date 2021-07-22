using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public float speed = 200;
    private Rigidbody enemyRb;
    protected GameObject player;

    // Start is called before the first frame update
    protected void Start()
    {
        player = GameObject.Find("Player");
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
        else
        {
            Move();
        }
    }

    protected abstract void Move();

    // ABSTRACTION
    protected void MoveTowards(Vector3 target)
    {
        enemyRb.AddForce(target * Time.deltaTime * speed);
    }

    protected Vector3 GetPlayerTargetVector()
    {
        Vector3 norzalizedTargetVector = (player.transform.position - transform.position).normalized;
        return norzalizedTargetVector;
    }
}
