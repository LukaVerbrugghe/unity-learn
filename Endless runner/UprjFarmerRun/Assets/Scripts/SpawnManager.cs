using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject m_Spawn;
    private Vector3 m_SpawnPosition = new Vector3(19, 2.384186e-07f, 9);

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(m_Spawn, m_SpawnPosition, m_Spawn.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
