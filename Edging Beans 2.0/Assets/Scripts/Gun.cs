using UnityEngine;

public class Gun : MonoBehaviour
{
    public float Damage = 10f;
    public float Range = 100f;
    public static GameObject hittedObject;
    
    public Camera Camera;
    public GameObject bulletSpawnPivot;

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
        if (Physics.Raycast(bulletSpawnPivot.transform.position, Camera.transform.forward, out RaycastHit hit, Range))
        {
            hittedObject = hit.transform.gameObject;
            Debug.Log("Hitted " + hittedObject);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(Damage);
            }
        }

    }
}
