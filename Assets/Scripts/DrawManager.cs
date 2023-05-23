using UnityEngine;

public class DrawManager : MonoBehaviour
{
    private Camera _cam;
    [SerializeField] private Line _linePrefab;
    public const float RESOULUTION = 0.1f;

    private Line _currentLine;

    private void Start()
    {
        _cam = Camera.main;
    }

    private void Update()
    {
       
        Ray ray = _cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            if (Input.GetMouseButtonDown(0)) _currentLine = Instantiate(_linePrefab, new Vector3(raycastHit.point.x,0.1f,raycastHit.point.z), Quaternion.identity);
            if (Input.GetMouseButton(0)) _currentLine.SetPosition(new Vector3(raycastHit.point.x,0.1f,raycastHit.point.z));
        }
        
    }
}
