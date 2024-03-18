using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform Ninplayer;
    [SerializeField] private Transform RoninTarget;
    public GameObject CameraTargetPrefab;
    private void Update()
    { if (CameraTargetPrefab.activeInHierarchy)
        {
            transform.position = new Vector3(Ninplayer.position.x,transform.position.y, transform.position.z);
        }
    else
        {
            transform.position = new Vector3(RoninTarget.position.x, transform.position.y, transform.position.z);
        }
        

    }
}
