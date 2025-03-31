using UnityEngine;

public class ProjectileHero : MonoBehaviour
{
    private BoundsCheck bndCheck;
    public float speed = 40;

    void Awake() {
        bndCheck = GetComponent<BoundsCheck>();
    }

    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
        
        if (bndCheck.LocIs(BoundsCheck.eScreenLocs.offUp)) {
            Destroy(gameObject);
        }
    }
}
