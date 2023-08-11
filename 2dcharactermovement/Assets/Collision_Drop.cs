using UnityEngine;

public class Collision_Drop : MonoBehaviour
{
    public movemntarrows movement;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.tag=="Platform"){
            other.collider.tag="Bterritory";
        }
        else if(other.collider.tag=="Aterritory"){
            movement.enabled=false;
        }
    }
}
        //   Debug.Log(other.collider.tag);
        //     movement.enabled=false;