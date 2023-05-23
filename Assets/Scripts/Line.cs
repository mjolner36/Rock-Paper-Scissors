using UnityEngine;

public class Line : MonoBehaviour
{
   private LineRenderer _renderer;

   private void OnEnable()
   {
      _renderer = GetComponent<LineRenderer>();
   }

   public void SetPosition(Vector3 pos)
   {
      if (!CanAppend(pos)) return;
      _renderer.positionCount++;
      _renderer.SetPosition(_renderer.positionCount-1,pos);
   }

   private bool CanAppend(Vector3 pos)
   {
      if (_renderer.positionCount == 0) return true;
      return Vector3.Distance(_renderer.GetPosition(_renderer.positionCount - 1), pos) > DrawManager.RESOULUTION;
   }
}
