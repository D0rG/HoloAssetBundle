using UnityEngine;

public class Recycle : MonoBehaviour
{
    public bool isCatched = false;

    public void updCatchedStatus(bool isCatched)
    {
        this.isCatched = isCatched;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "recycle" && !isCatched)
        {
            Destroy(gameObject);
        }
    }
}
