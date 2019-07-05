using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    public int Speed;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate (new Vector3(15,0,0) * Time.deltaTime * Speed);
    }
}
