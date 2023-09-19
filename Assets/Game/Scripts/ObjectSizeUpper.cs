using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSizeUpper : MonoBehaviour
{
    [SerializeField] private float _sizeUpSpeed;

    private void Update()
    {
        transform.localScale += new Vector3(_sizeUpSpeed, _sizeUpSpeed, _sizeUpSpeed) * Time.deltaTime;
    }
}
