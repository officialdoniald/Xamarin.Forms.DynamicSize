using System;
using Xamarin.Essentials;

namespace Xamarin.Forms.DynamicSize
{
    public static class DynamicSizeCalculator
    {
        /// <summary>
        /// The number you used in the design as the phone size.
        /// </summary>
        public static double DesignHeight { get; set; } = 0.0;

        /// <summary>
        /// DeviceDisplay.MainDisplayInfo.Height (Your actual mobile's screen size) / DeviceDisplay.MainDisplayInfo.Density (Your actual mobile's screen density).
        /// </summary>
        public static double PixelInHeight { get; set; } = DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density;

        /// <summary>
        /// Set the number you used in the design as the phone size.
        /// </summary>
        /// <param name="designHeight">The number you used in the design as the phone size.</param>
        public static void Init(double designHeight)
        {
            DesignHeight = designHeight;
        }

        /// <summary>
        /// This will change a double into another double dynamically.
        /// </summary>
        /// <param name="size">Input value in double.</param>
        /// <returns>Dynamic value of the input value.</returns>
        public static double GetDinamycNumber(double size)
        {
            double FigmaHeight = DesignHeight;
            double ModifiedHeight = PixelInHeight;

            double RN = FigmaHeight / size;

            if (FigmaHeight > ModifiedHeight)
            {
                RN = (FigmaHeight / ModifiedHeight) * RN;
            }
            else
            {
                RN = (ModifiedHeight / FigmaHeight) * RN;
            }

            double RFS = ModifiedHeight / RN;

            return RFS;
        }

        /// <summary>
        /// This will change a float into another float dynamically.
        /// </summary>
        /// <param name="size">Input value in float.</param>
        /// <returns>Dynamic value of the input value.</returns>
        public static float GetDinamycNumberInFloat(float size)
        {
            float FigmaHeight = Convert.ToSingle(DesignHeight);
            float ModifiedHeight = Convert.ToSingle(PixelInHeight);

            float RN = FigmaHeight / size;

            if (FigmaHeight > ModifiedHeight)
            {
                RN = (FigmaHeight / ModifiedHeight) * RN;
            }
            else
            {
                RN = (ModifiedHeight / FigmaHeight) * RN;
            }

            float RFS = ModifiedHeight / RN;

            return RFS;
        }

        /// <summary>
        /// This will change a int into another int dynamically.
        /// </summary>
        /// <param name="size">Input value in int.</param>
        /// <returns>Dynamic value of the input value.</returns>
        public static int GetDinamycNumberInInt32(int size)
        {
            int FigmaHeight = Convert.ToInt32(DesignHeight);
            int ModifiedHeight = Convert.ToInt32(PixelInHeight);

            int RN = FigmaHeight / size;

            if (FigmaHeight > ModifiedHeight)
            {
                RN = (FigmaHeight / ModifiedHeight) * RN;
            }
            else
            {
                RN = (ModifiedHeight / FigmaHeight) * RN;
            }

            int RFS = ModifiedHeight / RN;

            return RFS;
        }

        /// <summary>
        /// This will change a Thickness into another Thickness dynamically.
        /// </summary>
        /// <param name="margin">Input value in Thickness.</param>
        /// <returns>Dynamic value of the input value.</returns>
        public static Thickness GetDinamycNumberInThickness(Thickness margin)
        {
            double FigmaHeight = Convert.ToInt32(DesignHeight);
            double ModifiedHeight = Convert.ToInt32(PixelInHeight);

            double top = margin.Top != 0 ? FigmaHeight / margin.Top : 0;
            double bottom = margin.Bottom != 0 ? FigmaHeight / margin.Bottom : 0;
            double left = margin.Left != 0 ? FigmaHeight / margin.Left : 0;
            double right = margin.Right != 0 ? FigmaHeight / margin.Right : 0;

            if (FigmaHeight > ModifiedHeight)
            {
                top = (FigmaHeight / ModifiedHeight) * top;
                bottom = (FigmaHeight / ModifiedHeight) * bottom;
                left = (FigmaHeight / ModifiedHeight) * left;
                right = (FigmaHeight / ModifiedHeight) * right;
            }
            else
            {
                top = (ModifiedHeight / FigmaHeight) * top;
                bottom = (ModifiedHeight / FigmaHeight) * bottom;
                left = (ModifiedHeight / FigmaHeight) * left;
                right = (ModifiedHeight / FigmaHeight) * right;
            }

            double RFSTop = top != 0 ? ModifiedHeight / top : 0;
            double RFSBottom = bottom != 0 ? ModifiedHeight / bottom : 0;
            double RFSLeft = left != 0 ? ModifiedHeight / left : 0;
            double RFSRight = right != 0 ? ModifiedHeight / right : 0;

            return new Thickness(RFSLeft, RFSTop, RFSRight, RFSBottom);
        }
    }
}