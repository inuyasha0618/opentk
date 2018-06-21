//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.OpenGL
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "PalettedTexture" in the extension "Ext".
        /// </summary>
        public static partial class Ext
        {
            /// <summary>
            /// [requires: EXT_paletted_texture]
            /// Define a color lookup table
            /// </summary>
            /// <param name="target">
            /// Must be one of ColorTable, PostConvolutionColorTable, PostColorMatrixColorTable, ProxyColorTable, ProxyPostConvolutionColorTable, or ProxyPostColorMatrixColorTable.
            /// </param>
            /// <param name="internalFormat">
            /// The internal format of the color table. The allowable values are Alpha, Alpha4, Alpha8, Alpha12, Alpha16, Luminance, Luminance4, Luminance8, Luminance12, Luminance16, LuminanceAlpha, Luminance4Alpha4, Luminance6Alpha2, Luminance8Alpha8, Luminance12Alpha4, Luminance12Alpha12, Luminance16Alpha16, Intensity, Intensity4, Intensity8, Intensity12, Intensity16, R3G3B2, Rgb, Rgb4, Rgb5, Rgb8, Rgb10, Rgb12, Rgb16, Rgba, Rgba2, Rgba4, Rgb5A1, Rgba8, Rgb10A2, Rgba12, and Rgba16.
            /// </param>
            /// <param name="width">
            /// The number of entries in the color lookup table specified by data.
            /// </param>
            /// <param name="format">
            /// The format of the pixel data in data. The allowable values are Red, Green, Blue, Alpha, Luminance, LuminanceAlpha, Rgb, Bgr, Rgba, and Bgra.
            /// </param>
            /// <param name="type">
            /// The type of the pixel data in data. The allowable values are UnsignedByte, Byte, UnsignedShort, Short, UnsignedInt, Int, Float, UnsignedByte332, UnsignedByte233Rev, UnsignedShort565, UnsignedShort565Rev, UnsignedShort4444, UnsignedShort4444Rev, UnsignedShort5551, UnsignedShort1555Rev, UnsignedInt8888, UnsignedInt8888Rev, UnsignedInt1010102, and UnsignedInt2101010Rev.
            /// </param>
            /// <param name="table">
            /// [length: COMPSIZE(format,type,width)]
            /// Pointer to a one-dimensional array of pixel data that is processed to build the color table.
            /// </param>
            [AutoGenerated(Category = "EXT_paletted_texture", Version = "", EntryPoint = "glColorTableEXT")]
            public static void ColorTable(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.InternalFormat internalFormat, int width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [CountAttribute(Computed = "format,type,width")] IntPtr table)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_paletted_texture]
            /// Define a color lookup table
            /// </summary>
            /// <param name="target">
            /// Must be one of ColorTable, PostConvolutionColorTable, PostColorMatrixColorTable, ProxyColorTable, ProxyPostConvolutionColorTable, or ProxyPostColorMatrixColorTable.
            /// </param>
            /// <param name="internalFormat">
            /// The internal format of the color table. The allowable values are Alpha, Alpha4, Alpha8, Alpha12, Alpha16, Luminance, Luminance4, Luminance8, Luminance12, Luminance16, LuminanceAlpha, Luminance4Alpha4, Luminance6Alpha2, Luminance8Alpha8, Luminance12Alpha4, Luminance12Alpha12, Luminance16Alpha16, Intensity, Intensity4, Intensity8, Intensity12, Intensity16, R3G3B2, Rgb, Rgb4, Rgb5, Rgb8, Rgb10, Rgb12, Rgb16, Rgba, Rgba2, Rgba4, Rgb5A1, Rgba8, Rgb10A2, Rgba12, and Rgba16.
            /// </param>
            /// <param name="width">
            /// The number of entries in the color lookup table specified by data.
            /// </param>
            /// <param name="format">
            /// The format of the pixel data in data. The allowable values are Red, Green, Blue, Alpha, Luminance, LuminanceAlpha, Rgb, Bgr, Rgba, and Bgra.
            /// </param>
            /// <param name="type">
            /// The type of the pixel data in data. The allowable values are UnsignedByte, Byte, UnsignedShort, Short, UnsignedInt, Int, Float, UnsignedByte332, UnsignedByte233Rev, UnsignedShort565, UnsignedShort565Rev, UnsignedShort4444, UnsignedShort4444Rev, UnsignedShort5551, UnsignedShort1555Rev, UnsignedInt8888, UnsignedInt8888Rev, UnsignedInt1010102, and UnsignedInt2101010Rev.
            /// </param>
            /// <param name="table">
            /// [length: COMPSIZE(format,type,width)]
            /// Pointer to a one-dimensional array of pixel data that is processed to build the color table.
            /// </param>
            [AutoGenerated(Category = "EXT_paletted_texture", Version = "", EntryPoint = "glColorTableEXT")]
            public static void ColorTable<T5>(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.InternalFormat internalFormat, int width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type,width")] T5[] table)
                where T5 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_paletted_texture]
            /// Define a color lookup table
            /// </summary>
            /// <param name="target">
            /// Must be one of ColorTable, PostConvolutionColorTable, PostColorMatrixColorTable, ProxyColorTable, ProxyPostConvolutionColorTable, or ProxyPostColorMatrixColorTable.
            /// </param>
            /// <param name="internalFormat">
            /// The internal format of the color table. The allowable values are Alpha, Alpha4, Alpha8, Alpha12, Alpha16, Luminance, Luminance4, Luminance8, Luminance12, Luminance16, LuminanceAlpha, Luminance4Alpha4, Luminance6Alpha2, Luminance8Alpha8, Luminance12Alpha4, Luminance12Alpha12, Luminance16Alpha16, Intensity, Intensity4, Intensity8, Intensity12, Intensity16, R3G3B2, Rgb, Rgb4, Rgb5, Rgb8, Rgb10, Rgb12, Rgb16, Rgba, Rgba2, Rgba4, Rgb5A1, Rgba8, Rgb10A2, Rgba12, and Rgba16.
            /// </param>
            /// <param name="width">
            /// The number of entries in the color lookup table specified by data.
            /// </param>
            /// <param name="format">
            /// The format of the pixel data in data. The allowable values are Red, Green, Blue, Alpha, Luminance, LuminanceAlpha, Rgb, Bgr, Rgba, and Bgra.
            /// </param>
            /// <param name="type">
            /// The type of the pixel data in data. The allowable values are UnsignedByte, Byte, UnsignedShort, Short, UnsignedInt, Int, Float, UnsignedByte332, UnsignedByte233Rev, UnsignedShort565, UnsignedShort565Rev, UnsignedShort4444, UnsignedShort4444Rev, UnsignedShort5551, UnsignedShort1555Rev, UnsignedInt8888, UnsignedInt8888Rev, UnsignedInt1010102, and UnsignedInt2101010Rev.
            /// </param>
            /// <param name="table">
            /// [length: COMPSIZE(format,type,width)]
            /// Pointer to a one-dimensional array of pixel data that is processed to build the color table.
            /// </param>
            [AutoGenerated(Category = "EXT_paletted_texture", Version = "", EntryPoint = "glColorTableEXT")]
            public static void ColorTable<T5>(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.InternalFormat internalFormat, int width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type,width")] T5[,] table)
                where T5 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_paletted_texture]
            /// Define a color lookup table
            /// </summary>
            /// <param name="target">
            /// Must be one of ColorTable, PostConvolutionColorTable, PostColorMatrixColorTable, ProxyColorTable, ProxyPostConvolutionColorTable, or ProxyPostColorMatrixColorTable.
            /// </param>
            /// <param name="internalFormat">
            /// The internal format of the color table. The allowable values are Alpha, Alpha4, Alpha8, Alpha12, Alpha16, Luminance, Luminance4, Luminance8, Luminance12, Luminance16, LuminanceAlpha, Luminance4Alpha4, Luminance6Alpha2, Luminance8Alpha8, Luminance12Alpha4, Luminance12Alpha12, Luminance16Alpha16, Intensity, Intensity4, Intensity8, Intensity12, Intensity16, R3G3B2, Rgb, Rgb4, Rgb5, Rgb8, Rgb10, Rgb12, Rgb16, Rgba, Rgba2, Rgba4, Rgb5A1, Rgba8, Rgb10A2, Rgba12, and Rgba16.
            /// </param>
            /// <param name="width">
            /// The number of entries in the color lookup table specified by data.
            /// </param>
            /// <param name="format">
            /// The format of the pixel data in data. The allowable values are Red, Green, Blue, Alpha, Luminance, LuminanceAlpha, Rgb, Bgr, Rgba, and Bgra.
            /// </param>
            /// <param name="type">
            /// The type of the pixel data in data. The allowable values are UnsignedByte, Byte, UnsignedShort, Short, UnsignedInt, Int, Float, UnsignedByte332, UnsignedByte233Rev, UnsignedShort565, UnsignedShort565Rev, UnsignedShort4444, UnsignedShort4444Rev, UnsignedShort5551, UnsignedShort1555Rev, UnsignedInt8888, UnsignedInt8888Rev, UnsignedInt1010102, and UnsignedInt2101010Rev.
            /// </param>
            /// <param name="table">
            /// [length: COMPSIZE(format,type,width)]
            /// Pointer to a one-dimensional array of pixel data that is processed to build the color table.
            /// </param>
            [AutoGenerated(Category = "EXT_paletted_texture", Version = "", EntryPoint = "glColorTableEXT")]
            public static void ColorTable<T5>(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.InternalFormat internalFormat, int width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type,width")] T5[,,] table)
                where T5 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_paletted_texture]
            /// Define a color lookup table
            /// </summary>
            /// <param name="target">
            /// Must be one of ColorTable, PostConvolutionColorTable, PostColorMatrixColorTable, ProxyColorTable, ProxyPostConvolutionColorTable, or ProxyPostColorMatrixColorTable.
            /// </param>
            /// <param name="internalFormat">
            /// The internal format of the color table. The allowable values are Alpha, Alpha4, Alpha8, Alpha12, Alpha16, Luminance, Luminance4, Luminance8, Luminance12, Luminance16, LuminanceAlpha, Luminance4Alpha4, Luminance6Alpha2, Luminance8Alpha8, Luminance12Alpha4, Luminance12Alpha12, Luminance16Alpha16, Intensity, Intensity4, Intensity8, Intensity12, Intensity16, R3G3B2, Rgb, Rgb4, Rgb5, Rgb8, Rgb10, Rgb12, Rgb16, Rgba, Rgba2, Rgba4, Rgb5A1, Rgba8, Rgb10A2, Rgba12, and Rgba16.
            /// </param>
            /// <param name="width">
            /// The number of entries in the color lookup table specified by data.
            /// </param>
            /// <param name="format">
            /// The format of the pixel data in data. The allowable values are Red, Green, Blue, Alpha, Luminance, LuminanceAlpha, Rgb, Bgr, Rgba, and Bgra.
            /// </param>
            /// <param name="type">
            /// The type of the pixel data in data. The allowable values are UnsignedByte, Byte, UnsignedShort, Short, UnsignedInt, Int, Float, UnsignedByte332, UnsignedByte233Rev, UnsignedShort565, UnsignedShort565Rev, UnsignedShort4444, UnsignedShort4444Rev, UnsignedShort5551, UnsignedShort1555Rev, UnsignedInt8888, UnsignedInt8888Rev, UnsignedInt1010102, and UnsignedInt2101010Rev.
            /// </param>
            /// <param name="table">
            /// [length: COMPSIZE(format,type,width)]
            /// Pointer to a one-dimensional array of pixel data that is processed to build the color table.
            /// </param>
            [AutoGenerated(Category = "EXT_paletted_texture", Version = "", EntryPoint = "glColorTableEXT")]
            public static void ColorTable<T5>(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.InternalFormat internalFormat, int width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type,width")] ref T5 table)
                where T5 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_paletted_texture]
            /// Retrieve contents of a color lookup table
            /// </summary>
            /// <param name="target">
            /// Must be ColorTable, PostConvolutionColorTable, or PostColorMatrixColorTable.
            /// </param>
            /// <param name="format">
            /// The format of the pixel data in table. The possible values are Red, Green, Blue, Alpha, Luminance, LuminanceAlpha, Rgb, Bgr, Rgba, and Bgra.
            /// </param>
            /// <param name="type">
            /// The type of the pixel data in table. Symbolic constants UnsignedByte, Byte, Bitmap, UnsignedShort, Short, UnsignedInt, Int, Float, UnsignedByte332, UnsignedByte233Rev, UnsignedShort565, UnsignedShort565Rev, UnsignedShort4444, UnsignedShort4444Rev, UnsignedShort5551, UnsignedShort1555Rev, UnsignedInt8888, UnsignedInt8888Rev, UnsignedInt1010102, and UnsignedInt2101010Rev are accepted.
            /// </param>
            /// <param name="data">
            /// [length: COMPSIZE(target,format,type)]
            /// Pointer to a one-dimensional array of pixel data containing the contents of the color table.
            /// </param>
            [AutoGenerated(Category = "EXT_paletted_texture", Version = "", EntryPoint = "glGetColorTableEXT")]
            public static void GetColorTable(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [OutAttribute, CountAttribute(Computed = "target,format,type")] IntPtr data)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_paletted_texture]
            /// Retrieve contents of a color lookup table
            /// </summary>
            /// <param name="target">
            /// Must be ColorTable, PostConvolutionColorTable, or PostColorMatrixColorTable.
            /// </param>
            /// <param name="format">
            /// The format of the pixel data in table. The possible values are Red, Green, Blue, Alpha, Luminance, LuminanceAlpha, Rgb, Bgr, Rgba, and Bgra.
            /// </param>
            /// <param name="type">
            /// The type of the pixel data in table. Symbolic constants UnsignedByte, Byte, Bitmap, UnsignedShort, Short, UnsignedInt, Int, Float, UnsignedByte332, UnsignedByte233Rev, UnsignedShort565, UnsignedShort565Rev, UnsignedShort4444, UnsignedShort4444Rev, UnsignedShort5551, UnsignedShort1555Rev, UnsignedInt8888, UnsignedInt8888Rev, UnsignedInt1010102, and UnsignedInt2101010Rev are accepted.
            /// </param>
            /// <param name="data">
            /// [length: COMPSIZE(target,format,type)]
            /// Pointer to a one-dimensional array of pixel data containing the contents of the color table.
            /// </param>
            [AutoGenerated(Category = "EXT_paletted_texture", Version = "", EntryPoint = "glGetColorTableEXT")]
            public static void GetColorTable<T3>(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "target,format,type")] T3[] data)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_paletted_texture]
            /// Retrieve contents of a color lookup table
            /// </summary>
            /// <param name="target">
            /// Must be ColorTable, PostConvolutionColorTable, or PostColorMatrixColorTable.
            /// </param>
            /// <param name="format">
            /// The format of the pixel data in table. The possible values are Red, Green, Blue, Alpha, Luminance, LuminanceAlpha, Rgb, Bgr, Rgba, and Bgra.
            /// </param>
            /// <param name="type">
            /// The type of the pixel data in table. Symbolic constants UnsignedByte, Byte, Bitmap, UnsignedShort, Short, UnsignedInt, Int, Float, UnsignedByte332, UnsignedByte233Rev, UnsignedShort565, UnsignedShort565Rev, UnsignedShort4444, UnsignedShort4444Rev, UnsignedShort5551, UnsignedShort1555Rev, UnsignedInt8888, UnsignedInt8888Rev, UnsignedInt1010102, and UnsignedInt2101010Rev are accepted.
            /// </param>
            /// <param name="data">
            /// [length: COMPSIZE(target,format,type)]
            /// Pointer to a one-dimensional array of pixel data containing the contents of the color table.
            /// </param>
            [AutoGenerated(Category = "EXT_paletted_texture", Version = "", EntryPoint = "glGetColorTableEXT")]
            public static void GetColorTable<T3>(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "target,format,type")] T3[,] data)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_paletted_texture]
            /// Retrieve contents of a color lookup table
            /// </summary>
            /// <param name="target">
            /// Must be ColorTable, PostConvolutionColorTable, or PostColorMatrixColorTable.
            /// </param>
            /// <param name="format">
            /// The format of the pixel data in table. The possible values are Red, Green, Blue, Alpha, Luminance, LuminanceAlpha, Rgb, Bgr, Rgba, and Bgra.
            /// </param>
            /// <param name="type">
            /// The type of the pixel data in table. Symbolic constants UnsignedByte, Byte, Bitmap, UnsignedShort, Short, UnsignedInt, Int, Float, UnsignedByte332, UnsignedByte233Rev, UnsignedShort565, UnsignedShort565Rev, UnsignedShort4444, UnsignedShort4444Rev, UnsignedShort5551, UnsignedShort1555Rev, UnsignedInt8888, UnsignedInt8888Rev, UnsignedInt1010102, and UnsignedInt2101010Rev are accepted.
            /// </param>
            /// <param name="data">
            /// [length: COMPSIZE(target,format,type)]
            /// Pointer to a one-dimensional array of pixel data containing the contents of the color table.
            /// </param>
            [AutoGenerated(Category = "EXT_paletted_texture", Version = "", EntryPoint = "glGetColorTableEXT")]
            public static void GetColorTable<T3>(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "target,format,type")] T3[,,] data)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_paletted_texture]
            /// Retrieve contents of a color lookup table
            /// </summary>
            /// <param name="target">
            /// Must be ColorTable, PostConvolutionColorTable, or PostColorMatrixColorTable.
            /// </param>
            /// <param name="format">
            /// The format of the pixel data in table. The possible values are Red, Green, Blue, Alpha, Luminance, LuminanceAlpha, Rgb, Bgr, Rgba, and Bgra.
            /// </param>
            /// <param name="type">
            /// The type of the pixel data in table. Symbolic constants UnsignedByte, Byte, Bitmap, UnsignedShort, Short, UnsignedInt, Int, Float, UnsignedByte332, UnsignedByte233Rev, UnsignedShort565, UnsignedShort565Rev, UnsignedShort4444, UnsignedShort4444Rev, UnsignedShort5551, UnsignedShort1555Rev, UnsignedInt8888, UnsignedInt8888Rev, UnsignedInt1010102, and UnsignedInt2101010Rev are accepted.
            /// </param>
            /// <param name="data">
            /// [length: COMPSIZE(target,format,type)]
            /// Pointer to a one-dimensional array of pixel data containing the contents of the color table.
            /// </param>
            [AutoGenerated(Category = "EXT_paletted_texture", Version = "", EntryPoint = "glGetColorTableEXT")]
            public static void GetColorTable<T3>(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "target,format,type")] ref T3 data)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_paletted_texture]
            /// Get color lookup table parameters
            /// </summary>
            /// <param name="target">
            /// The target color table. Must be ColorTable, PostConvolutionColorTable, PostColorMatrixColorTable, ProxyColorTable, ProxyPostConvolutionColorTable, or ProxyPostColorMatrixColorTable.
            /// </param>
            /// <param name="pname">
            /// The symbolic name of a color lookup table parameter. Must be one of ColorTableBias, ColorTableScale, ColorTableFormat, ColorTableWidth, ColorTableRedSize, ColorTableGreenSize, ColorTableBlueSize, ColorTableAlphaSize, ColorTableLuminanceSize, or ColorTableIntensitySize.
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// A pointer to an array where the values of the parameter will be stored.
            /// </param>
            [AutoGenerated(Category = "EXT_paletted_texture", Version = "", EntryPoint = "glGetColorTableParameterfvEXT")]
            public static void GetColorTableParameter(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.GetColorTableParameterPNameSgi pname, [OutAttribute, CountAttribute(Computed = "pname")] float[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_paletted_texture]
            /// Get color lookup table parameters
            /// </summary>
            /// <param name="target">
            /// The target color table. Must be ColorTable, PostConvolutionColorTable, PostColorMatrixColorTable, ProxyColorTable, ProxyPostConvolutionColorTable, or ProxyPostColorMatrixColorTable.
            /// </param>
            /// <param name="pname">
            /// The symbolic name of a color lookup table parameter. Must be one of ColorTableBias, ColorTableScale, ColorTableFormat, ColorTableWidth, ColorTableRedSize, ColorTableGreenSize, ColorTableBlueSize, ColorTableAlphaSize, ColorTableLuminanceSize, or ColorTableIntensitySize.
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// A pointer to an array where the values of the parameter will be stored.
            /// </param>
            [AutoGenerated(Category = "EXT_paletted_texture", Version = "", EntryPoint = "glGetColorTableParameterfvEXT")]
            public static void GetColorTableParameter(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.GetColorTableParameterPNameSgi pname, [OutAttribute, CountAttribute(Computed = "pname")] out float @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_paletted_texture]
            /// Get color lookup table parameters
            /// </summary>
            /// <param name="target">
            /// The target color table. Must be ColorTable, PostConvolutionColorTable, PostColorMatrixColorTable, ProxyColorTable, ProxyPostConvolutionColorTable, or ProxyPostColorMatrixColorTable.
            /// </param>
            /// <param name="pname">
            /// The symbolic name of a color lookup table parameter. Must be one of ColorTableBias, ColorTableScale, ColorTableFormat, ColorTableWidth, ColorTableRedSize, ColorTableGreenSize, ColorTableBlueSize, ColorTableAlphaSize, ColorTableLuminanceSize, or ColorTableIntensitySize.
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// A pointer to an array where the values of the parameter will be stored.
            /// </param>
            [AutoGenerated(Category = "EXT_paletted_texture", Version = "", EntryPoint = "glGetColorTableParameterfvEXT")]
            public static unsafe void GetColorTableParameter(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.GetColorTableParameterPNameSgi pname, [OutAttribute, CountAttribute(Computed = "pname")] float* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_paletted_texture]
            /// Get color lookup table parameters
            /// </summary>
            /// <param name="target">
            /// The target color table. Must be ColorTable, PostConvolutionColorTable, PostColorMatrixColorTable, ProxyColorTable, ProxyPostConvolutionColorTable, or ProxyPostColorMatrixColorTable.
            /// </param>
            /// <param name="pname">
            /// The symbolic name of a color lookup table parameter. Must be one of ColorTableBias, ColorTableScale, ColorTableFormat, ColorTableWidth, ColorTableRedSize, ColorTableGreenSize, ColorTableBlueSize, ColorTableAlphaSize, ColorTableLuminanceSize, or ColorTableIntensitySize.
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// A pointer to an array where the values of the parameter will be stored.
            /// </param>
            [AutoGenerated(Category = "EXT_paletted_texture", Version = "", EntryPoint = "glGetColorTableParameterivEXT")]
            public static void GetColorTableParameter(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.GetColorTableParameterPNameSgi pname, [OutAttribute, CountAttribute(Computed = "pname")] int[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_paletted_texture]
            /// Get color lookup table parameters
            /// </summary>
            /// <param name="target">
            /// The target color table. Must be ColorTable, PostConvolutionColorTable, PostColorMatrixColorTable, ProxyColorTable, ProxyPostConvolutionColorTable, or ProxyPostColorMatrixColorTable.
            /// </param>
            /// <param name="pname">
            /// The symbolic name of a color lookup table parameter. Must be one of ColorTableBias, ColorTableScale, ColorTableFormat, ColorTableWidth, ColorTableRedSize, ColorTableGreenSize, ColorTableBlueSize, ColorTableAlphaSize, ColorTableLuminanceSize, or ColorTableIntensitySize.
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// A pointer to an array where the values of the parameter will be stored.
            /// </param>
            [AutoGenerated(Category = "EXT_paletted_texture", Version = "", EntryPoint = "glGetColorTableParameterivEXT")]
            public static void GetColorTableParameter(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.GetColorTableParameterPNameSgi pname, [OutAttribute, CountAttribute(Computed = "pname")] out int @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_paletted_texture]
            /// Get color lookup table parameters
            /// </summary>
            /// <param name="target">
            /// The target color table. Must be ColorTable, PostConvolutionColorTable, PostColorMatrixColorTable, ProxyColorTable, ProxyPostConvolutionColorTable, or ProxyPostColorMatrixColorTable.
            /// </param>
            /// <param name="pname">
            /// The symbolic name of a color lookup table parameter. Must be one of ColorTableBias, ColorTableScale, ColorTableFormat, ColorTableWidth, ColorTableRedSize, ColorTableGreenSize, ColorTableBlueSize, ColorTableAlphaSize, ColorTableLuminanceSize, or ColorTableIntensitySize.
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// A pointer to an array where the values of the parameter will be stored.
            /// </param>
            [AutoGenerated(Category = "EXT_paletted_texture", Version = "", EntryPoint = "glGetColorTableParameterivEXT")]
            public static unsafe void GetColorTableParameter(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.GetColorTableParameterPNameSgi pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(260)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glColorTableEXT(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.InternalFormat internalFormat, int width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [CountAttribute(Computed = "format,type,width")] IntPtr table);

            [Slot(729)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glGetColorTableEXT(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [OutAttribute, CountAttribute(Computed = "target,format,type")] IntPtr data);

            [Slot(731)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetColorTableParameterfvEXT(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.GetColorTableParameterPNameSgi pname, [OutAttribute, CountAttribute(Computed = "pname")] float* @params);

            [Slot(734)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetColorTableParameterivEXT(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.GetColorTableParameterPNameSgi pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params);
        }
    }
}