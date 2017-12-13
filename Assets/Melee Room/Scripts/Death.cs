using UnityEngine;

public class Death : MonoBehaviour {

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Lava")
            Destroy(gameObject);
    }

}