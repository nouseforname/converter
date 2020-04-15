using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.FileExtensions;
using Microsoft.Extensions.Configuration.Json;

using GeometricObject;
using Excelon2;

namespace Converter
{
  public class CConverter
  {
    public IConfigurationRoot configuration;


    List<CGeometricObject> listGeometricObject;
    CExcelon2 ex2;



    public CConverter(string[] args)
    {
      Console.WriteLine("CConverter(args)");

      var configuration = new ConfigurationBuilder()
                      .SetBasePath(Directory.GetCurrentDirectory())
                      .AddJsonFile("appsettings.json", false).Build();


      var section = configuration.GetSection("default");

      Console.WriteLine(section.Get<string>());

      listGeometricObject = new List<CGeometricObject>();

      Console.WriteLine("1: " + listGeometricObject.Count);
      ex2 = new CExcelon2(ref listGeometricObject);
      Console.WriteLine("2: " + listGeometricObject.Count);


      foreach (CGeometricObject geometricObject in listGeometricObject)
        Console.WriteLine(geometricObject.ToString());

    }


    bool checkArgs(string[] args)
    {

      return false;
    }



  }
}
