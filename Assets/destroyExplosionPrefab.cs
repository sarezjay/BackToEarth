using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyExplosionPrefab : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("destroy", 0.65f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void destroy() {
        Destroy(gameObject);
    }
}
