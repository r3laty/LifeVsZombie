using UnityEngine;

public class NormalTree : MonoBehaviour, IColectable
{
    public void Chop()
    {
        Destroy(gameObject);
    }
}
