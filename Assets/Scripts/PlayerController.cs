using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject[] wayPoints;
    [SerializeField] float speed = 8;
    [SerializeField] Transform spawnPosition;

    private float distance = 1f;
    private int currentWayPoint = 0;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        playerMovement();
    }
    private void playerMovement()
    {
        if (Input.GetMouseButton(0))
        {
            if (Vector3.Distance(wayPoints[currentWayPoint].transform.position, transform.position) < distance)
            {
                currentWayPoint++;
                if (currentWayPoint >= wayPoints.Length) currentWayPoint = 0;
            }
            transform.position = Vector3.MoveTowards(transform.position, wayPoints[currentWayPoint].transform.position, Time.deltaTime * speed);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            Vector3 newPos = spawnPosition.localPosition;
            newPos.y += 1;
            newPos.x = 0;
            newPos.z = 0;
            spawnPosition.localPosition = newPos;
            other.transform.SetParent(spawnPosition);
            //newPos.y *= -1;
            other.transform.localPosition = newPos;
            other.transform.localRotation = Quaternion.identity;
        }
    }
}
