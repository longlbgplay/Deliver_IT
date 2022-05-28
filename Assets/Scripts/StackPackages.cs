using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackPackages : MonoBehaviour
{
    public Transform spawnPosition;
    private Vector3 newPos;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Box"))
        {
            //Transform packages = other.transform.parent;
            newPos = spawnPosition.localPosition;
            newPos.y += 1;
            newPos.x = 0;
            newPos.z = 0;
            spawnPosition.localPosition = newPos;
            other.transform.SetParent(spawnPosition);
            other.transform.localPosition = newPos;
            other.transform.localRotation = Quaternion.identity; 
        }
    }
}
