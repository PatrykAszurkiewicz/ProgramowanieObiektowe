using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceArea : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("RemoveArea", 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RemoveArea()
    {
        Destroy(gameObject);
    }
}
