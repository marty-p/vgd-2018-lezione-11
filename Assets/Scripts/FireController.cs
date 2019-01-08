using Unity;
public class FireController : MonoBehavior {
    private ParticleSystem ps;
    private float lifetime = 15.0f;
  
    void Start() {
        ps = GetComponent<ParticleSystem>();
    }

    void Update() {
        lifetime -= Time.deltaTime;
        if (lifetime < 0)
        {
            ps.Stop();
        }
    }
}
