using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSizeUp : MonoBehaviour
{
    [SerializeField] private float _sizeUpSpeed;

    private void FixedUpdate()
    {
        transform.localScale += new Vector3(_sizeUpSpeed, _sizeUpSpeed, _sizeUpSpeed);
    }
}
