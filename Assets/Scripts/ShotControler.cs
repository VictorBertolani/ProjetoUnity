using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotControler : MonoBehaviour
{
    public GameObject TiroPrefab;
    public float forceSpeedFire;
    public bool isPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && isPlayer)
        {
            Atirar();
        }
    }

    public void Atirar()
    {
        GameObject tempTiro = Instantiate(TiroPrefab) as GameObject;
        tempTiro.transform.position = transform.position;

        tempTiro.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, forceSpeedFire));
    }
}
