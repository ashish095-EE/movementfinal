using UnityEngine;

public class collision_change : MonoBehaviour
{
    SpriteRenderer sr;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.tag=="PlayerA"){
            sr = GetComponent<SpriteRenderer>();
            sr.color = new Color(2,0,0);
            Debug.Log(other.collider.tag);
    }
        if(other.collider.tag=="PlayerB"){
            sr = GetComponent<SpriteRenderer>();
            sr.color = new Color(0,0,2);
            Debug.Log(other.collider.tag);
    }
    }
}
