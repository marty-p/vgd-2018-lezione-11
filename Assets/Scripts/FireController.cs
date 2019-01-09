using UnityEngine;
public class FireController : MonoBehaviour {
    private ParticleSystem ps;
    private float lifetime = 15.0f;

    void Start() {
        ps = GetComponent<ParticleSystem>();
        var module = ps.shape;
        module.enabled = true;
        module.shapeType = ParticleSystemShapeType.Cone;
    }

    void Update() {
        lifetime -= Time.deltaTime;
        if (lifetime < 0)
        {
            ps.Stop();
        }
    }
}
