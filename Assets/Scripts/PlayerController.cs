using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject[] wayPoints;
    [SerializeField] float speed = 8;
    private float distance = 1f;
    private int currentWayPoint = 0;
    public bool isCollide = false;
    //public Transform SpawnPosition;
    //public GameObject ObjectToCreate;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            isCollide = true;
            //Destroy(collision.gameObject);
            //Instantiate(ObjectToCreate, SpawnPosition.position, Quaternion.identity);
            //collision.gameObject.transform.position = SpawnPosition.position;
        }
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
}
