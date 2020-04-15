using System;

namespace GeometricObject
{
  public class CGeometricCircle : CGeometricObject
  {

    public double dCenterX { get; set; }
    public double dCenterY { get; set; }
    public double dRadius { get; set; }
    public bool bClockwise { get; set; } // G32 CCW, G33 CW

    public CGeometricCircle()
    {
      Console.WriteLine("CGeometricCircle");
    }


    CGeometricCircle(double dCX, double dCY, double dRad)
    {
      init();

      this.dCenterX          = dCX;
      this.dCenterY          = dCY;
      this.dRadius           = dRad;
    }

    CGeometricCircle(double dCX, double dCY, double dRad, bool bCW)
    {
      init();

      this.dCenterX          = dCX;
      this.dCenterY          = dCY;
      this.dRadius           = dRad;
      this.bClockwise        = bCW;
    }

    private void init()
    {
      this.eGeometricType      = EnumGeometricType.CIRCLE;
      this.bIsEndObject        = true;
      this.bIsStartObject      = true;
      this.iDiamCompensation   = 40;
      this.bClockwise          = false;
    }

    public override string ToString()
    {
      return this.eGeometricType.ToString();
    }
  }
}
