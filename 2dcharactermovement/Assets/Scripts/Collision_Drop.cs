using UnityEngine;

public class Collision_Drop : MonoBehaviour
{
    public movemntarrows movement;
    public movemntwasd movementw;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.tag=="Platform"){
            other.collider.tag="Bterritory";
        }
        else if(other.collider.tag=="Aterritory"){
            movement.enabled=false;
            movementw.enabled=false;
            Destroy(other.gameObject);
        }
    }
}
        //   Debug.Log(other.collider.tag);
        //     movement.enabled=false;