using System;

namespace GeometricObject
{
  public class CGeometricArc : CGeometricObject
  {
    public double dStartPointX { get; set; }
    public double dStartPointY { get; set; }
    public double dEndPointX { get; set; }
    public double dEndPointY { get; set; }
    public double dRadius { get; set; }
    public bool bClockwise { get; set; }
    public double dStartAngle { get; set; }
    public double dDeltaAngle { get; set; }
    public double dCenterX { get; set; }
    public double dCenterY { get; set; }


    public CGeometricArc(double dStartX, double dStartY, double dEndX, double dEndY, double dRadius, bool bClockwise)
    {
      this.dStartPointX       = dStartX;
      this.dStartPointY       = dStartY;
      this.dEndPointX         = dEndX;
      this.dEndPointY         = dEndY;
      this.dRadius            = dRadius;
      this.bClockwise         = bClockwise;
      this.eGeometricType     = EnumGeometricType.ARC;
      this.bIsEndObject       = false;
      this.bIsStartObject     = false;
      this.iDiamCompensation  = 40;
    }

    public override string ToString()
    {
      return this.eGeometricType.ToString();
    }
  }
}
