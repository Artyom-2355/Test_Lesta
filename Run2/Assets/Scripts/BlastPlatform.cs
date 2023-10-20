using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Blast"))
            {
                Destroy(collision.transform.parent.gameObject);
                Debug.Log("sdf");
            }
        }
    }
}
