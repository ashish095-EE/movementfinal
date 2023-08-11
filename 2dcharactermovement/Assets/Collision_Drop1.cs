using UnityEngine;

public class Collision_Drop1 : MonoBehaviour
{
    public movemntwasd movement;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.tag=="Platform"){
            other.collider.tag="Aterritory";
        }
        else if(other.collider.tag=="Bterritory"){
            movement.enabled=false;
        }
    }
}
        //   Debug.Log(other.collider.tag);
        //     movement.enabled=false;