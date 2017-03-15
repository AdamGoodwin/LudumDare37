using UnityEngine;
using System.Collections;

public class Collapse : MonoBehaviour
{
    public Transform target;
    public float speed;
    public Controller controller;

    void FixedUpdate()
    {
        if(!controller.hasWon)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }
}
