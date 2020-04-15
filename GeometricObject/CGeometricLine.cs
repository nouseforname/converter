using System;

namespace GeometricObject
{
  public class CGeometricLine : CGeometricObject
  {

    public double dStartPointX { get; set; }
    public double dStartPointY { get; set; }
    public double dEndPointX { get; set; }
    public double dEndPointY { get; set; }
    public double dDirectionX { get; set; }
    public double dDirectionY { get; set; }


    CGeometricLine(double dStartX, double dStartY, double dEndX, double dEndY)
    {
      this.dStartPointX       = dStartX;
      this.dStartPointY       = dStartY;
      this.dEndPointX         = dEndX;
      this.dEndPointY         = dEndY;
      this.eGeometricType     = EnumGeometricType.LINE;
      this.bIsEndObject       = false;
      this.bIsStartObject     = false;
      this.iDiamCompensation  = 40;
    }
  }
}
