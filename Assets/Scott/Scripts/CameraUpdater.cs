using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUpdater : MonoBehaviour
{
    private CinemachineVirtualCamera _camera;
    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<CinemachineVirtualCamera>();
        _camera.Follow = GameObject.Find("Player").transform;
        _camera.LookAt = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
