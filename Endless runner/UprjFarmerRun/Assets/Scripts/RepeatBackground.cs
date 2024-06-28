using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    [SerializeField] private float offset;
    private Vector3 startPos;
    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
        offset = repeatWidth;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > startPos.x + offset)
        {
            transform.position = startPos;
        }
    }
}
