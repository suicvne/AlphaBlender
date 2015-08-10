# What is this?
A small C# library for alpha blending images based on a mask (transparency)

# Why do I need it?
You probably don't, but I know certain people (including myself) that do.

# How do I use it?

## C-Sharp

  1. Add a reference to the library
  
  `using MikeSantiago.AlphaBlender`
  
  2. Make an object
  
  `AlphaBlendedImage alphaBlendedImage = new AlphaBlendedImage(imageAsBitmap, maskAsBitmap);`
  
  3. Use the alphaBlendedImage.AlphaBlendImages() function to return the combined images as a bitmap.
  
  `pictureBox1.Image = alphaBlendedImage.AlphaBlendImages();`
  
## Visual Basic
  1. Add a reference to the library
  
  `Imports MikeSantiago.AlphaBlender`
  
  2. Dim an object
  
  `Dim alphaBlendedImage As New AlphaBlendedImage(image, mask)`
  
  3. Use the alphaBlendedImage.AlphaBlendImages() function to return the combined images as a bitmap.
  
  `PictureBox1.Image = alphaBlendedImage.AlphaBlendImages()`
  
# Does this bitblt?

**No** *god no*. This does not use VB6/GDI's godawful AND->OR/bitbltting/whatever method to prepare this image. Thus, true transparency can be achieved. And it looks pretty nice, and works quickly even with large images.

# License?

GPL. Redistribue however you want, include the class in your project. Just give a little kickback to me (link to this repo, my name somewhere, whatever you want).
