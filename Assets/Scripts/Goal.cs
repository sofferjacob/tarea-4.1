using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Level playerLevel = player.GetComponent<Level>();
        playerLevel.IncreaseLevel();
        player.transform.position = new Vector3(1.29f, -7.18f, 0.06319202f);
    }
}
