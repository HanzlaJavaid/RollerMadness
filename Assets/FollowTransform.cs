using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTransform : MonoBehaviour
{
    [SerializeField] GameObject ToFollow;
    Transform targetTransform;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        targetTransform = ToFollow.transform;
        offset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = targetTransform.position+offset;
    }
}
