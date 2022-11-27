using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash : MonoBehaviour
{
    public GameObject splash;

    public void SpawnPoints()
    {
        Instantiate(splash, transform.position, transform.rotation);
    }


}
