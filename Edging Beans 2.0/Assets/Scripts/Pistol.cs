using UnityEngine;

public class Pistol : MonoBehaviour
{
    public float Damage = 10f;
    public float Range = 100f;
    RaycastHit hit;
    
    public GameObject pistolBarrel;

    void Update()
    {
        if (!PauseMenu.isPaused)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
        if (Physics.Raycast(pistolBarrel.transform.position, pistolBarrel.transform.forward, out hit, Range))
        {
            Debug.Log("Shoot!");
            Debug.Log(hit.transform.name);
        }
        
    }
}
