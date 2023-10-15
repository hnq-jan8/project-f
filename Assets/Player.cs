using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [field: SerializeField]
    public float Pac { get; private set; }

    [field: SerializeField]
    public float Sho { get; private set; }

    [field: SerializeField]
    public float Pas { get; private set; }

    [field: SerializeField]
    public float Dri { get; private set; }

    [field: SerializeField]
    public float Def { get; private set; }

    [field: SerializeField]
    public float Phy { get; private set; }

    [field: SerializeField]
    //Better if the type is "Ball" or something
    public GameObject Ball { get; private set; }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Attack()
    {

    }

    public virtual void Defend()
    {

    }
}
