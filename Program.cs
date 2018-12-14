using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progr_framework_11g
{
  static class ez
  {
    static string body;
    public static void Write(string text)
    {
      body += text;
      Console.Write(text);
    }
    public static void Write<T>(T text)
    {
      ez.Write(text.ToString());
    }
    public static void WriteLine(string text)
    {
      ez.Write(text + "\n");
    }
    public static void WriteLine<T>(T text)
    {
      ez.Write(text.ToString() + "\n");
    }

    public static string ReadLine()
    {
      return Console.ReadLine();
    }

    public static T Get<T>()
    {
      return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
    }
    public static T Get<T>(string text)
    {
      ez.WriteLine(text);
      return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
    }
    public static T BegFor<T>()
    {
      t:
      try
      {
        T r = Get<T>();
        return r;
      }
      catch
      {
        Console.Clear();
        Console.Write(body);
        goto t;
      }
    }
    public static T BegFor<T>(string text)
    {
      ez.WriteLine(text);
    t:
      try
      {
        T r = Get<T>();
        return r;
      }
      catch
      {
        Console.Clear();
        Console.Write(body);
        goto t;
      }
    }


    public static List<int>  szamok_nulla_vegjelig(int max=Int32.MaxValue)
    {
      int t,i=0;
      var ret = new List<int>();
      while (((t = Get<int>()) != 0 )&& i < max)
      {
        ret.Add(t);
        i++;
      }
      return ret;
    }


    public static string[] txt_soronkent_olvas(string elérési_út)
    {
      return System.IO.File.ReadAllLines(elérési_út);
    }

    public static int[] random_szamos_tomb(int darabszam,int min_ami_benne_van,int max_ami_BENNE_VAN)
    {
      var hs = new HashSet<int>();
      var rnd = new Random();
      while (hs.Count < darabszam)
      {
        hs.Add(rnd.Next(min_ami_benne_van, max_ami_BENNE_VAN + 1));
      }
      return hs.ToArray();
    }

    public static void kiír<T>(this T[] self)
    {
      for (int i = 0; i < self.Length; i++)
      {
        ez.Write(self[i].ToString() + " ");
      }
    }

    public static T[] rendez<T>(this T[] self)
    {
      var r = self.ToList();
      r.Sort();
      return r.ToArray();
    }
    public enum Rendezés
    {
      Növekvő,
      Csökkenő
    }
    public static T[] rendez<T>(this T[] self, Rendezés r)
    {
      switch (r)
      {
        case Rendezés.Növekvő:
          return self.rendez<T>();
        case Rendezés.Csökkenő:
          return self.rendez().Reverse().ToArray();
      }
      return null;
    }
  }


  class Program
  {
    static void Main(string[] args)
    {
      var random_szamos_tomb = ez.random_szamos_tomb(5, 1, 10);
      random_szamos_tomb.rendez(ez.Rendezés.Csökkenő).kiír();
      


      Console.ReadLine();
    }
  }
}
