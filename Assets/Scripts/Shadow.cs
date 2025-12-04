using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public float speed = 8f;
    private bool triggered = false;

    void Update()
    {
        if (triggered)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPoint.position, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, endPoint.position) < 0.1f)
            {
                Destroy(gameObject, 0.2f);
            }
        }
    }

    public void TriggerShadow()
    {
        triggered = true;
    }
}

