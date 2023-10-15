using UnityEngine;

public class Kolonhareketi : MonoBehaviour
{

    public float speed;
    

    private void Start()
    {
        //Destroy(gameObject, 10); bununla calismadý kolonlar yok oldu bir süre sonra 
        //bu yüzden kolon spawndaki 25 ve 27. satýrý kullandýk düzenleyip.
    }


    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
