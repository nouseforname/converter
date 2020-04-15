using System;

namespace GeometricObject
{
  public class CGeometricPoint : CGeometricObject
  {
    public double dPointX { get; set; }
    public double dPointY { get; set; }


    public CGeometricPoint(double dCX, double dCY)
    {
      this.dPointX             = dCX;
      this.dPointY             = dCY;
      this.eGeometricType      = EnumGeometricType.POINT;
      this.bIsEndObject        = false;
      this.bIsStartObject      = false;
      this.iDiamCompensation   = 40;
    }

    public override string ToString()
    {
      return this.eGeometricType.ToString();
    }
  }
}
