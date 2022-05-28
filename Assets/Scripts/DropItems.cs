using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItems : MonoBehaviour
{
    //public List<Transform> packagesPosition;
    [SerializeField] GameObject moneys;
    [SerializeField] Material material;
    public Transform packages;
    public GameObject test;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //Destroy(test);
            //Instantiate(moneys, packages.position, Quaternion.identity);
        }
    }
}
