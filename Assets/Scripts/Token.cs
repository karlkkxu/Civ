using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : MonoBehaviour
{
    private int max = 32;
    private int maara;
    //TODO private int vari;

    public Token()
    {
        this.maara = max;
    }

    public Token(int nro)
    {
        this.maara = nro;
    }

    public void Update()
    {
        //TODO tokenien määrän näyttäminen
    }

    public void Move(LocationTile destination)
    {
        this.transform.position = destination.GetLocation();
    }
}
