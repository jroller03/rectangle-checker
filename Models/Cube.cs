
namespace RectanglesChecker.Models
{
  public class Cube
  {
    private Rectangles _face;
    public Cube (Rectangles side)
    {
      _face = side;
    }
    public int GetVolume()
    {
      int length = _face.GetLength();
      return length * length * length;
    }
    public int GetSurfaceArea()
    {
      return _face.GetArea() * 6;
    }
  }
}
