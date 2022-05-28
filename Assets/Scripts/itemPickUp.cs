using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemPickUp : MonoBehaviour
{
    public Transform SpawnPosition;
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Vector3 pos = transform.position;
            //pos.y += 1;
            //transform.position = pos;
            transform.position = SpawnPosition.position;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transform.position = SpawnPosition.position;
        }
    }
    public void packagesPickUp(Transform transform)
    {
        count++;
        transform.SetParent(SpawnPosition, true);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
    }
}
