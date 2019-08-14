using System;

namespace Problem1
{
  class Box
  {
    public Box(decimal l, decimal w, decimal h)
    {
      this.height = l;
      this.width = w;
      this.length = h;
    }

    public decimal length { get; private set; }
    public decimal width { get; private set; }
    public decimal height { get; private set; }

    public decimal VolumeDiff()
    {
      decimal volumeI = length * width * height;
      decimal volumeM = volumeI * (decimal)2.54;

      decimal volumeL = volumeM / 1000;
      decimal diff = Math.Ceiling(volumeM) - volumeM;

      return Math.Round(diff, 4);
    }
  }
}