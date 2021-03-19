using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Camera : MonoBehaviour
{
    public GameObject Player;
    void Update()
    {
        transform.position = Player.transform.position;
    }
}
