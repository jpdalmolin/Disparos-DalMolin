using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject prefabBala;

    public Transform posicionTorreta;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CrearProyectil();
    }

    void CrearProyectil()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
        Instantiate(prefabBala,posicionTorreta.position,transform.rotation);
        }    
    }
}
