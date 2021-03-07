using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace Henxun.Cms.Core.Helper
{
    public static class CaptchaHelper
    {
        public static string Letters = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static int CodeLength = 4;

        public static string GenerateCaptchaCode()
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            var maxRand = Letters.Length - 1;

            var sb = new StringBuilder();

            for(int i = 0;i< CodeLength;i++)
            {
                var index = random.Next(maxRand);
                sb.Append(Letters[index]);
            }

            return sb.ToString();
        
        }

        public static CaptchaResult GetImage(int width, int height, string captchaCode, bool drawBezier=false)
        {
            using(var baseMap = new Bitmap(width, height))
            {
                using(var graph = Graphics.FromImage(baseMap))
                {
                    var random = new Random();

                    graph.Clear(GetRandomLightColor());

                    DrawCaptchaCode();

                    //DrawDisorderLine(); 
                    
                    //AdjustRippleEffect();

                    var ms = new MemoryStream();
                    baseMap.Save(ms, ImageFormat.Png);

                    return new CaptchaResult
                    {
                        CaptchaCode = captchaCode,
                        CaptchaByteData = ms.ToArray(),
                        Timestamp = DateTime.UtcNow
                    };

                    Color GetRandomLightColor()
                    {
                        int low = 180, high = 255;
                        var nRed = random.Next(high) % (high - low) + low;
                        var nGreen = random.Next(high) % (high - low) + low;
                        var nBlue = random.Next(high) % (high - low) + low;

                        return Color.FromArgb(nRed, nGreen, nBlue);
                    }

                    void DrawCaptchaCode()
                    {
                        var fontBrush = new SolidBrush(Color.Black);
                        var fontSize = GetFontSize(width, captchaCode.Length);
                        var font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold, GraphicsUnit.Pixel);
                        for (int i = 0; i < captchaCode.Length; i++)
                        {
                            fontBrush.Color = GetRandomDeepColor();

                            var shiftPx = fontSize;
                            float x = i * shiftPx + 2 /*+ random.Next(-shiftPx, shiftPx) + random.Next(-shiftPx, shiftPx)*/;

                            var maxY = height - fontSize;
                            if (maxY < 0) maxY = 0;
                            float y = random.Next(0, maxY);
                            graph.DrawString(captchaCode[i].ToString(), font, fontBrush, x, y);
                        }
                    }

                    int GetFontSize(int imageWidth, int captchaCount)
                    {
                        var avg = imageWidth / captchaCount;
                        return Convert.ToInt32(avg);
                    }

                    Color GetRandomDeepColor()
                    {
                        int redLow = 160, greenLow = 100, blueLow = 160;
                        return Color.FromArgb(random.Next(redLow), random.Next(greenLow), random.Next(blueLow));
                    }

                    void DrawDisorderLine()
                    {
                        var linePen = new Pen(new SolidBrush(Color.Black), 3);
                        for (var i = 0; i < random.Next(3, 5); i++)
                        {
                            linePen.Color = GetRandomDeepColor();

                            var startPoint = new Point(random.Next(0, width), random.Next(0, height));
                            var endPoint = new Point(random.Next(0, width), random.Next(0, height));
                            graph.DrawLine(linePen, startPoint, endPoint);

                            if (drawBezier)
                            {
                                var bezierPoint1 = new Point(random.Next(0, width), random.Next(0, height));
                                var bezierPoint2 = new Point(random.Next(0, width), random.Next(0, height));

                                graph.DrawBezier(linePen, startPoint, bezierPoint1, bezierPoint2, endPoint);
                            }
                        }
                    }
                    void AdjustRippleEffect()
                    {
                        short nWave = 6;
                        var nWidth = baseMap.Width;
                        var nHeight = baseMap.Height;

                        var pt = new Point[nWidth, nHeight];

                        for (var x = 0; x < nWidth; ++x)
                        {
                            for (var y = 0; y < nHeight; ++y)
                            {
                                var xo = nWave * Math.Sin(2.0 * 3.1415 * y / 128.0);
                                var yo = nWave * Math.Cos(2.0 * 3.1415 * x / 128.0);

                                var newX = x + xo;
                                var newY = y + yo;

                                if (newX > 0 && newX < nWidth)
                                {
                                    pt[x, y].X = (int)newX;
                                }
                                else
                                {
                                    pt[x, y].X = 0;
                                }


                                if (newY > 0 && newY < nHeight)
                                {
                                    pt[x, y].Y = (int)newY;
                                }
                                else
                                {
                                    pt[x, y].Y = 0;
                                }
                            }
                        }

                        var bSrc = (Bitmap)baseMap.Clone();

                        var bitmapData = baseMap.LockBits(new Rectangle(0, 0, baseMap.Width, baseMap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                        var bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                        var scanline = bitmapData.Stride;

                        var scan0 = bitmapData.Scan0;
                        var srcScan0 = bmSrc.Scan0;

                        unsafe
                        {
                            var p = (byte*)(void*)scan0;
                            var pSrc = (byte*)(void*)srcScan0;

                            var nOffset = bitmapData.Stride - baseMap.Width * 3;

                            for (var y = 0; y < nHeight; ++y)
                            {
                                for (var x = 0; x < nWidth; ++x)
                                {
                                    var xOffset = pt[x, y].X;
                                    var yOffset = pt[x, y].Y;

                                    if (yOffset >= 0 && yOffset < nHeight && xOffset >= 0 && xOffset < nWidth)
                                    {
                                        if (pSrc != null)
                                        {
                                            if (p != null)
                                            {
                                                p[0] = pSrc[yOffset * scanline + xOffset * 3];
                                                p[1] = pSrc[yOffset * scanline + xOffset * 3 + 1];
                                                p[2] = pSrc[yOffset * scanline + xOffset * 3 + 2];
                                            }
                                        }
                                    }

                                    p += 3;
                                }
                                p += nOffset;
                            }
                        }

                        baseMap.UnlockBits(bitmapData);
                        bSrc.UnlockBits(bmSrc);
                        bSrc.Dispose();
                    }
                }
            }
        }

    }
    public class CaptchaResult
    {
        public string CaptchaCode { get; set; }

        public byte[] CaptchaByteData { get; set; }

        public string CaptchBase64Data => Convert.ToBase64String(CaptchaByteData);

        public DateTime Timestamp { get; set; }
    }
}
