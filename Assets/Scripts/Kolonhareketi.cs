using UnityEngine;

public class Kolonhareketi : MonoBehaviour
{

    public float speed;
    

    private void Start()
    {
        //Destroy(gameObject, 10); bununla calismad� kolonlar yok oldu bir s�re sonra 
        //bu y�zden kolon spawndaki 25 ve 27. sat�r� kulland�k d�zenleyip.
    }


    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
