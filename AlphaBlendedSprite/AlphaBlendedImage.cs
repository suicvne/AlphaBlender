using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;


namespace MikeSantiago.AlphaBlender
{
    public class AlphaBlendedImage
    {
        Bitmap _image;
        Bitmap _mask;
        Bitmap preparedMask;
        Bitmap preparedImage;
        Bitmap finalMaskedImage;

        public AlphaBlendedImage(Bitmap image, Bitmap mask)
        {
            _image = Create32bppImageAndClearAlpha(image);
            _mask = Create32bppImageAndClearAlpha(mask);
        }

        public Bitmap AlphaBlendSprites()
        {
            PrepareMaskImage();
            return finalMaskedImage;
        }

        #region This is ugly stuff
        private void PrepareMaskedImage()
        {
            if (this._image != null && this.preparedMask != null)
            {
                if (this._image.Width != this.preparedMask.Width || this._image.Height != this.preparedMask.Height)
                {
                    throw new BadImageFormatException("Mask and image must be the same size");
                }
                else
                {
                    this.finalMaskedImage = Create32bppImageAndClearAlpha(this._image);

                    BitmapData bmpData1 = finalMaskedImage.LockBits(new Rectangle(0, 0, finalMaskedImage.Width, finalMaskedImage.Height), System.Drawing.Imaging.ImageLockMode.ReadWrite, finalMaskedImage.PixelFormat);
                    byte[] finalMaskedImageRGBAData = new byte[bmpData1.Stride * bmpData1.Height];
                    System.Runtime.InteropServices.Marshal.Copy(bmpData1.Scan0, finalMaskedImageRGBAData, 0, finalMaskedImageRGBAData.Length);

                    BitmapData bmpData2 = preparedMask.LockBits(new Rectangle(0, 0, preparedMask.Width, preparedMask.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, preparedMask.PixelFormat);
                    byte[] preparedMaskRGBAData = new byte[bmpData2.Stride * bmpData2.Height];
                    System.Runtime.InteropServices.Marshal.Copy(bmpData2.Scan0, preparedMaskRGBAData, 0, preparedMaskRGBAData.Length);

                    //copy the mask to the Alpha layer
                    for (int i = 0; i + 2 < finalMaskedImageRGBAData.Length; i += 4)
                    {
                        finalMaskedImageRGBAData[i + 3] = preparedMaskRGBAData[i];

                    }
                    System.Runtime.InteropServices.Marshal.Copy(finalMaskedImageRGBAData, 0, bmpData1.Scan0, finalMaskedImageRGBAData.Length);
                    this.finalMaskedImage.UnlockBits(bmpData1);
                    this.preparedMask.UnlockBits(bmpData2);
                }
            }
        }

        private void PrepareMaskImage()
        {
            if (_mask != null)
            {

                this.preparedMask = Create32bppImageAndClearAlpha(_mask);

                BitmapData bmpData = preparedMask.LockBits(new Rectangle(0, 0, preparedMask.Width, preparedMask.Height), System.Drawing.Imaging.ImageLockMode.ReadWrite, preparedMask.PixelFormat);

                byte[] preparedMaskRGBData = new byte[bmpData.Stride * bmpData.Height];

                System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, preparedMaskRGBData, 0, preparedMaskRGBData.Length);


                byte greyLevel;
                bool opaque = false;
                //int OpacityThreshold = this.trackBar1.Value;
                bool invertedMask = true;//this.checkBoxInvertMask.Checked;
                for (int i = 0; i + 2 < preparedMaskRGBData.Length; i += 4)
                {
                    //convert to gray scale R:0.30 G=0.59 B 0.11
                    greyLevel = (byte)(0.3 * preparedMaskRGBData[i + 2] + 0.59 * preparedMaskRGBData[i + 1] + 0.11 * preparedMaskRGBData[i]);

                    if (opaque)
                    {
                        greyLevel = ((int)greyLevel < 420/*OpacityThreshold*/) ? byte.MinValue : byte.MaxValue;
                    }
                    if (invertedMask)
                    {
                        greyLevel = (byte)(255 - (int)greyLevel);
                    }

                    preparedMaskRGBData[i] = greyLevel;
                    preparedMaskRGBData[i + 1] = greyLevel;
                    preparedMaskRGBData[i + 2] = greyLevel;

                }
                System.Runtime.InteropServices.Marshal.Copy(preparedMaskRGBData, 0, bmpData.Scan0, preparedMaskRGBData.Length);
                this.preparedMask.UnlockBits(bmpData);
                //this.spriteMask.Image = preparedMask;
                // if the loaded image is available, we have everything to compute the masked image
                if (this._image != null)
                {
                    PrepareMaskedImage();
                }
            }
        }

        private Bitmap Create32bppImageAndClearAlpha(Bitmap tmpImage)
        {
            // declare the new image that will be returned by the function
            Bitmap returnedImage = new Bitmap(tmpImage.Width, tmpImage.Height, PixelFormat.Format32bppArgb);

            // create a graphics instance to draw the original image in the new one
            Rectangle rect = new Rectangle(0, 0, tmpImage.Width, tmpImage.Height);
            Graphics g = Graphics.FromImage(returnedImage);

            // create an image attribe to force a clearing of the alpha layer
            ImageAttributes imageAttributes = new ImageAttributes();
            float[][] colorMatrixElements = {
                        new float[] {1,0,0,0,0},
                        new float[] {0,1,0,0,0},
                        new float[] {0,0,1,0,0},
                        new float[] {0,0,0,0,0},
                        new float[] {0,0,0,1,1}};

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            // draw the original image 
            g.DrawImage(tmpImage, rect, 0, 0, tmpImage.Width, tmpImage.Height, GraphicsUnit.Pixel, imageAttributes);
            g.Dispose();
            return returnedImage;
        }
        #endregion
    }
}
