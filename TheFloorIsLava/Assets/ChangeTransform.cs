using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTransform : MonoBehaviour
{
    [Header("Position Change Valu")]
    public Vector3 positionChange;
    [Header("")]

    [Header("Rotation Change Valu")]
    public Vector3 rotationChange;
    [Header("")]
    
    [Header("Scale Change Valu")]
    public Vector3 scaleChange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += positionChange * Time.deltaTime;

        transform.Rotate(rotationChange * Time.deltaTime);

        transform.localScale += scaleChange * Time.deltaTime;
    }
}
