using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject m_Spawn;
    private Vector3 m_SpawnPosition = new Vector3(10, 2.384186e-07f, 9);
    [SerializeField] private float startDelay = 2;
    [SerializeField] private float repeatRate = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        Instantiate(m_Spawn, m_SpawnPosition, m_Spawn.transform.rotation);
    }
}
