using UnityEngine;

public enum Connection
{
    AVAIL, CONNECT, UNAVAIL
}

public class RailTile
{
    public Connection[] connections = new Connection[4];

    public virtual Sprite GetSprite()
    {
        // todo
    }

    public virtual bool isEmpty()
    {
        // return true if all connections empty
    }
}