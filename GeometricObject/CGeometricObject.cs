using System;

namespace GeometricObject
{
  public enum EnumGeometricType
  {
    POINT,
    LINE,
    ARC,
    CIRCLE,

    dummy_last_entry
  }


  public class CGeometricObject
  {
    public EnumGeometricType eGeometricType { get; set; }
    public bool bIsStartObject { get; set; }
    public bool bIsEndObject { get; set; }
    public int iDiamCompensation { get; set; }
    public int iLayer { get; set; }
    public string sTool { get; set; }
    public int iAmount { get; set; }
    public double dPitch { get; set; }
    public int iDialationType { get; set; }
    public double dToolCP { get; set; }


    public CGeometricObject()
    {
      init();
    }

    public CGeometricObject(EnumGeometricType eType)
    {
      init();

      eGeometricType = eType;
    }

    private void init()
    {
      this.bIsStartObject      = false;
      this.bIsEndObject        = false;
      this.iDiamCompensation   = 40;
      this.sTool               = "";
      this.iAmount             = 0;
      this.dPitch              = 0.02;
      this.iDialationType      = 40;
      this.dToolCP             = 0.02;
    }


    public override string ToString()
    {
      return this.eGeometricType.ToString();
    }
  }
}
