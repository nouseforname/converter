using System;
using GeometricObject;

namespace Excelon2
{
  public class CExcelon2
  {
    public CExcelon2()
    {
      Console.WriteLine("Ex2");
    }

    public CExcelon2(ref System.Collections.Generic.List<GeometricObject.CGeometricObject> listGeometricObjects)
    {
      Console.WriteLine("Ref Ex2");
      listGeometricObjects.Add(new CGeometricObject(EnumGeometricType.CIRCLE));
      listGeometricObjects.Add(new CGeometricObject(EnumGeometricType.LINE));
    }

  }
}
