using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{
    public bool hit;

    void Update()
    {
        hit = Physics.Raycast(transform.position, transform.forward, 1 << 8);
    
if( hit == true){
    Debug.LogWarning("Be careful!");
}else {
    Debug.Log("All good!");
}

}
}